using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRP.DAO
{
    internal class DAO_Movie
    {
        public class MovieDAO
        {
            private static MovieDAO instance;
            public static MovieDAO Instance
            {
                get { if (instance == null) instance = new MovieDAO(); return instance; }
                private set { instance = value; }
            }

            private MovieDAO() { }

            public DataTable GetListMovie()
            {
                // Sử dụng DataProvider của bạn để lấy dữ liệu
                return DataProvider.Instance.ExecuteQuery("SELECT id AS [Mã phim], Name AS [Tên phim], Time AS [Thời lượng], Genre AS [Thể loại] FROM Movie");
            }

            public bool InsertMovie(string name, float time, string genre)
            {
                string query = "INSERT INTO Movie ( Name , Time , Genre ) VALUES ( @name , @time , @genre )";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, time, genre });
                return result > 0;
            }
        }
    }
}
