using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRP.GUI
{
    internal class Menutrip
    {
        public class MovieMenuRenderer : ToolStripProfessionalRenderer
        {
            // 1. Đổi màu chữ và màu nền cho mục Menu
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color backColor = e.Item.Selected ? Color.FromArgb(62, 88, 113) : Color.FromArgb(31, 40, 51);

                using (SolidBrush brush = new SolidBrush(backColor))
                {
                    e.Graphics.FillRectangle(brush, rc);
                }

                // Đảm bảo chữ vẫn trắng
                e.Item.ForeColor = Color.White;


            }

            // 2. Xóa bỏ cái viền (border) bao quanh menu khi click
            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
                // Để trống để không vẽ viền trắng mặc định
            }

            // Vẽ lại nền nhưng giữ nguyên độ trong suốt của Icon

            protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
            {
                if (e.Image != null)
                {

                    Rectangle rect = e.ImageRectangle;
                    e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;e.Graphics.DrawImage(e.Image, rect);
                    e.Graphics.DrawImage(e.Image, rect);
                    // 1. Tạo Ma trận màu để biến mọi thứ thành màu TRẮNG
                    // Ma trận này sẽ ghi đè giá trị R, G, B thành 255 (Trắng) 
                    // nhưng giữ nguyên độ trong suốt (Alpha) của file PNG.
                    var colorMatrix = new System.Drawing.Imaging.ColorMatrix(new float[][]
                    {
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 1, 0}, // Giữ nguyên độ trong suốt
                new float[] {1, 1, 1, 0, 1}  // Ép R, G, B lên tối đa (Trắng)
                    });

                    var imageAttributes = new System.Drawing.Imaging.ImageAttributes();
                    imageAttributes.SetColorMatrix(colorMatrix);

                    // 2. Vẽ lại icon với bộ lọc màu trắng
                    e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    e.Graphics.DrawImage(
                        e.Image,
                        e.ImageRectangle,
                        0, 0, e.Image.Width, e.Image.Height,
                        GraphicsUnit.Pixel,
                        imageAttributes
                    );
                }
            }

        }
    }
}
