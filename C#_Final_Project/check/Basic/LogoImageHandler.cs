using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    class LogoImageHandler
    {
        private string connString;

        public LogoImageHandler()
        {

        }
        public Image ChangeLogoImage()
        {

            string workingDirectory = Environment.CurrentDirectory;

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;


            projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            //  MessageBox.Show(projectDirectory);

            Bitmap bmp;
            using (Image image = Image.FromFile(projectDirectory + "\\LogoImage\\LogoImage.jpg"))
            {

                string workingDirectory2 = Environment.CurrentDirectory;

                string projectDirectory2 = Directory.GetParent(workingDirectory).Parent.FullName;


                projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

                //  File.Delete(projectDirectory + "\\LogoImage\\LogoImage.jpg");



                bmp = new Bitmap(image);
                bmp.Save(projectDirectory + "\\LogoImage\\ImageTemp\\1.jpg", System.Drawing.Imaging.ImageFormat.Gif);

            }

            return bmp;
        }
        public void ChangePathOfLogo()
        {
          
            OleDbConnection con;
            HttpClient httpClient = new HttpClient();
            connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new OleDbConnection(connString);
            string thePath= "ERROR";

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                thePath =  dlg.FileName.ToString();
              //  MessageBox.Show(thePath);
            }
            string workingDirectory = Environment.CurrentDirectory;

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
           

            projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            //  File.Delete(projectDirectory + "\\LogoImage\\LogoImage.jpg");

            try
            {
                File.Copy(thePath, projectDirectory + "\\LogoImage\\LogoImage.jpg", true);

            }
            catch
            {
                MessageBox.Show("no image was selected");
            }
        }


    }
}
