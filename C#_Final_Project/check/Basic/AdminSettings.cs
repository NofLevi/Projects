using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class AdminSettings : Form
    {
        string name;
        LogoImageHandler logoHand = new LogoImageHandler();
        public AdminSettings(string name)
        {
            InitializeComponent();
            this.name = name;
            GUI();
        }
        void GUI() //SETUP GUI DESIGN
        {
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            EmailSettingsButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            button1.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            LogInfoButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            BackUpToMailButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            button3.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = logoHand.ChangeLogoImage();
        }
        private void EmailSettingsButton_MouseClick(object sender, MouseEventArgs e) //OPEN EMAIL SETTINGS
        {
            emailSetting f2 = new emailSetting();
            f2.ShowDialog();
        }

        private void LogInfoButton_MouseClick(object sender, MouseEventArgs e) //OPEN LOGS 
        {
            LogsTable f2 = new LogsTable();
            f2.ShowDialog();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e) //OPEN WORKERS MANIPULATION
        {
            UpdateWorkers f2 = new UpdateWorkers(name);
            f2.ShowDialog();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e) //OPEN STATS 
        {
            Stats f2 = new Stats();
            f2.ShowDialog();
        }

        private void BackUpToMailButton_MouseClick(object sender, MouseEventArgs e) //SENDING BACK UP TO MAIL  
        {
            smtpHandler smtp = new smtpHandler();
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT bin directory (ie ../bin/)
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            // This will get the current PROJECT directory
            projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            DateTime dateTime = DateTime.UtcNow.Date;
            projectDirectory += "\\BackUps\\Database1.accdb";
            string SQL = "SQL BackUp " + dateTime.ToString("M - d - yyyy");
            smtp.BackupSender(SQL, SQL, projectDirectory);
            MessageBox.Show("Mail was sented succsesfully!!!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            logoHand.ChangePathOfLogo();
            pictureBox1.Image = logoHand.ChangeLogoImage();
        }
    }
}
