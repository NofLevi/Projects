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
    public partial class FirstEntryForm : Form
    {
        string emailverificationcode = "";
        string smtpverificationcode = "";
        int smtpflag = 0;
        SQLFuncs sqlfuncs = new SQLFuncs();
        public FirstEntryForm()
        {
            InitializeComponent();
            GUI();
        }

        void GUI() //SETUP GUI DESIGN
        {
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            MailVerificationButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            ConfirmButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        //Sending Code to user email
        private void MailVerificationButton_MouseClick(object sender, MouseEventArgs e)
        {
            smtpHandler smtp = new smtpHandler(true);
            emailverificationcode = smtp.PersonalAccountEmailChack(EmailTextBox.Text);
            MailVerificationButton.Text = "Resend";
            MessageBox.Show("Mail Sent!!!");
        }

        //Registaring User to the software
        private void ConfirmButton_MouseClick(object sender, MouseEventArgs e) 
        {
            if (PasswordTextBox.Text != RepeatPasswordTextBox.Text)
            {
                MessageBox.Show("The passwords arent similar");
            }
            else if (label1.ForeColor == System.Drawing.Color.Lime && label2.ForeColor == System.Drawing.Color.Lime && PasswordTextBox.Text == RepeatPasswordTextBox.Text && EmailVerificationTextBox.Text == emailverificationcode && FullNameTextBox.Text.Length > 4)
            {
                string sql = "INSERT INTO `LoginTable`(`LoginName`, `Password`,`Permission`,`Email`,`FullName`) VALUES('" + Encryption.Base64Encode(IDTextField.Text) + "', '" + Encryption.Base64Encode(PasswordTextBox.Text) + "', '3', '" + EmailTextBox.Text + "','" + FullNameTextBox.Text + "'); ";
                sqlfuncs.AddRemoveChange(sql);
                sql = "UPDATE Settings SET [FirstLogin] = '1' WHERE [FirstLogin] = '0';";
                sqlfuncs.AddRemoveChange(sql);
                MessageBox.Show("Registration Completed");
                this.Hide();
                SMTPSetup f2 = new SMTPSetup();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Make sure all the green fields are filled!!!");
            }
        }

        bool IsValidEmail(string email) // CHECKING IF MAIL IS VALID
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void IDTextField_TextChanged(object sender, EventArgs e) //CHANGE TO GREEN IF FIELD IS OK
        {
            if(IDTextField.Text.Length > 2)
            {
                label1.ForeColor = System.Drawing.Color.Lime;
            }
            else
            {
                label1.ForeColor = System.Drawing.Color.White;
            }
        }


        private void EmailTextBox_TextChanged(object sender, EventArgs e) //CHANGE TO GREEN IF FIELD IS OK
        {
            if(EmailTextBox.Text.Length > 8)
            {
                if (IsValidEmail(EmailTextBox.Text))
                {
                    label3.ForeColor = System.Drawing.Color.Lime;
                }

                else
                {
                    label3.ForeColor = System.Drawing.Color.White;
                }
            }
            else
            {
                label3.ForeColor = System.Drawing.Color.White;
            }
        }

        private void RepeatPasswordTextBox_TextChanged(object sender, EventArgs e) //CHANGE TO GREEN IF FIELD IS OK
        {
            if(RepeatPasswordTextBox.Text == PasswordTextBox.Text)
            {
                label9.ForeColor = System.Drawing.Color.Lime;
            }
            else
            {
                label9.ForeColor = System.Drawing.Color.White;
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e) //CHANGE TO GREEN IF FIELD IS OK
        {
            if (PasswordTextBox.Text.Length > 5)
            {
                label2.ForeColor = System.Drawing.Color.Lime;
            }
            else
            {
                label2.ForeColor = System.Drawing.Color.White;
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e) //CHANGE TO GREEN IF FIELD IS OK
        {
            if (FullNameTextBox.Text.Length > 4)
            {
                label4.ForeColor = System.Drawing.Color.Lime;
            }
            else
            {
                label4.ForeColor = System.Drawing.Color.White;
            }
        }
    }
}
