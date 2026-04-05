using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

public class DataProvider
{
    // Chuỗi kết nối (Thay đổi tên Database của bạn ở đây)
    private string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=CinemaManagement;Integrated Security=True";
    //private string connectionSTR = @"Data Source=.;Initial Catalog=CinemaManagement;Integrated Security=True";

    // Thiết kế theo mẫu Singleton (Chỉ duy nhất 1 thực thể được tạo ra)
    private static DataProvider instance;
    public static DataProvider Instance
    {
        get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
        private set { DataProvider.instance = value; }
    }

    private DataProvider() { }

    // Dùng cho câu lệnh SELECT (Trả về một bảng dữ liệu)
    public DataTable ExecuteQuery(string query, object[] parameter = null)
    {
        DataTable data = new DataTable();
        using (SqlConnection connection = new SqlConnection(connectionSTR))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            if (parameter != null)
            {
                // Thay thế đoạn tách tham số cũ bằng đoạn này
                if (parameter != null)
                {
                    // Tách chuỗi theo dấu cách, dấu phẩy, xuống dòng...
                    string[] listPara = query.Split(new char[] { ' ', ',', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            // Loại bỏ các ký tự thừa dính vào tham số (như dấu phẩy, ngoặc đơn)
                            string cleanParam = item.Replace(",", "").Replace("(", "").Replace(")", "");
                            command.Parameters.AddWithValue(cleanParam, parameter[i]);
                            i++;
                        }
                    }
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
        }
        return data;
    }

    public object ExecuteScalar(string query, object[] parameter = null)
    {
        object data = 0;
        using (SqlConnection connection = new SqlConnection(connectionSTR))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }
            data = command.ExecuteScalar(); // Hàm này lấy giá trị duy nhất trả về từ SQL
            connection.Close();
        }
        return data;
    }

    // Dùng cho câu lệnh INSERT, UPDATE, DELETE (Trả về số dòng thành công)
    public int ExecuteNonQuery(string query, object[] parameter = null)
    {
        int data = 0;
        using (SqlConnection connection = new SqlConnection(connectionSTR))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            if (parameter != null)
            {
                string[] listPara = query.Split(new char[] { ' ', ',', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains("@"))
                    {
                        string cleanParam = item;

                        int index = cleanParam.IndexOf('@');
                        if (index >= 0)
                        {
                            cleanParam = cleanParam.Substring(index);
                        }

                        cleanParam = cleanParam.Replace(",", "").Replace("(", "").Replace(")", "");

                        command.Parameters.AddWithValue(cleanParam, parameter[i]);
                        i++;
                    }
                }
            }
         
            data = command.ExecuteNonQuery();
            connection.Close();
        }
        return data;
    }
}