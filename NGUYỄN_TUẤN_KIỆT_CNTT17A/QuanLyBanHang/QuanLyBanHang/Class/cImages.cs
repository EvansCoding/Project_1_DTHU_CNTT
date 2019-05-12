using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanHang.Class
{
    class cImages
    {
        private const string STRPNG = ".png";
        private const string STRJPG = ".jpg";

        public void Images(PictureBox pictureBox, string _Images)
        {
            try
            {
                pictureBox.Image = Image.FromFile(Application.StartupPath+"\\Images\\" + _Images + STRPNG);
            }
            catch (Exception)
            {
                pictureBox.Image = Image.FromFile(Application.StartupPath + "\\Images\\" + _Images + STRJPG);
            }
        }

        public string pathImagesPNG(string _Images)
        {

            return Application.StartupPath + "\\Images\\" + _Images + STRPNG;
        }

        public string pathImagesJPG(string _Images)
        {
            return Application.StartupPath + "\\Images\\" + _Images + STRJPG;
        }
    }
}
