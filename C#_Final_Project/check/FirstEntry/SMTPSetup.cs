using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class SMTPSetup : Form
    {
        string smtpverificationcode = "Flying Spaggehti is real";
        SQLFuncs sqlfuncs = new SQLFuncs();
        smtpHandler smtp = new smtpHandler(true);
        public SMTPSetup()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
            GUI();

        }

        void GUI() //SETUP GUI DESIGN
        {
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            SMTPVerificationButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            SkipButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            ConfirmButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
        }
        private void SkipButton_MouseClick(object sender, MouseEventArgs e) //SKIP SMTP AND GO TO LOGIN FORM
        {
            this.Hide();
            Login f2 = new Login();
            f2.ShowDialog();
            this.Close();
        }


        private void EmailVerificationButton_MouseClick(object sender, MouseEventArgs e) //SENDING A CODE TO MAIL
        {
            if (EmailPassword.Text == "" || EmailIDTextBox.Text == "")
            {
                MessageBox.Show("please make sure the ID and password are filled ");

            }
            else
            {
                smtpverificationcode = smtp.VerifyEmail(EmailIDTextBox.Text, "@" + comboBox1.Text, EmailPassword.Text);
                // MessageBox.Show(smtpverificationcode + " check");
                VerificationCodeLabel.Visible = true;
                ConfirmSMTPTextBox.Visible = true;
            }
        }


        private void ConfirmButton_MouseClick(object sender, MouseEventArgs e) // CHECKING IF THE CODE IS RIGHT AND ADDING TO SQL
        {
            if (ConfirmSMTPTextBox.Text == smtpverificationcode)
            {
                 string  sql = "UPDATE  EmailLogin SET [Email] = '"+ EmailIDTextBox.Text+"' WHERE [Email] = 'N/A';";
               // string sql = "INSERT INTO `EmailLogin`(`Email`, `SecurePassword`,`EmailType`) VALUES('" + EmailIDTextBox.Text + "', '" + EmailPassword.Text + "', '@" + comboBox1.Text + "'); ";
                sqlfuncs.AddRemoveChange(sql);
                string sql2 = "UPDATE  EmailLogin SET [SecurePassword] = '" + EmailPassword.Text + "' WHERE [SecurePassword] = 'N/A';";
                string sql3 = "UPDATE  EmailLogin SET [EmailType] =  '@" + comboBox1.Text + "' WHERE [EmailType] = 'N/A';";
                sqlfuncs.AddRemoveChange(sql2);
                sqlfuncs.AddRemoveChange(sql3);
                MessageBox.Show("SMTP is Registred!!!");
                this.Hide();
                Login f2 = new Login();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("SMTP Code is incurrect try again !!!");
            }

        }
    }
}
