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
    public partial class AddWorker : Form
    {
        SQLFuncs sqlfuncs = new SQLFuncs();
        public AddWorker()
        {
            InitializeComponent();
            GUI();
        }

        void GUI() //SETUP GUI DESIGN
        {
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            ConfirmButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            comboBox1.SelectedIndex = 0;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e) //CHANGE COLOR TO GREEN WHEN FIELD ALLOWED
        {
            if(FullNameTextBox.Text.Length > 4)
            {
                FullNameLabel.ForeColor = System.Drawing.Color.Lime;
            }

            else
            {
                FullNameLabel.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void LoginNameTextBox_TextChanged(object sender, EventArgs e) //CHANGE COLOR TO GREEN WHEN FIELD ALLOWED
        {
            if(LoginNameTextBox.Text.Length > 3)
            {
                LoginNameLabel.ForeColor = System.Drawing.Color.Lime;
            }
            else
            {
                LoginNameLabel.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e) //CHANGE COLOR TO GREEN WHEN FIELD ALLOWED
        {
            if(PasswordTextBox.Text.Length > 5)
            {
                PasswordLabel.ForeColor = System.Drawing.Color.Lime;
            }
            else
            {
                PasswordLabel.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void PasswordTextBox2_TextChanged(object sender, EventArgs e) //CHANGE COLOR TO GREEN WHEN FIELD ALLOWED
        {
            if (PasswordLabel.ForeColor == System.Drawing.Color.Lime && PasswordTextBox2.Text == PasswordTextBox.Text)
            {
                PasswordLabel2.ForeColor = System.Drawing.Color.Lime;
            }
            else
            {
                PasswordLabel2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e) //CHANGE COLOR TO GREEN WHEN FIELD ALLOWED
        {
            if (IsValidEmail(EmailTextBox.Text))
            {
                EmailLabel.ForeColor = System.Drawing.Color.Lime;
            }
            else
            {
                EmailLabel.ForeColor = System.Drawing.Color.Black;
            }
        }

        bool IsValidEmail(string email) //CHECKING IF MAIL IS VALID
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

        private void ConfirmButton_MouseClick(object sender, MouseEventArgs e) //CONFIRM BUTTON ADD TO SQL 
        {
            if (PasswordTextBox.Text != PasswordTextBox2.Text)
            {
                MessageBox.Show("The passwords arent similar");
            }
            else if (LoginNameLabel.ForeColor == System.Drawing.Color.Lime && PasswordLabel2.ForeColor == System.Drawing.Color.Lime && EmailLabel.ForeColor == System.Drawing.Color.Lime)
            {
                int temp = comboBox1.SelectedIndex+1;
                string sql = "INSERT INTO `LoginTable`(`LoginName`, `Password`,`Permission`,`Email`,`FullName`) VALUES('" + Encryption.Base64Encode(LoginNameTextBox.Text) + "', '" + Encryption.Base64Encode(PasswordTextBox.Text) + "', '" + temp.ToString() + "', '" + EmailTextBox.Text + "','" + FullNameTextBox.Text+ "'); ";
                sqlfuncs.AddRemoveChange(sql);
                MessageBox.Show("Registration Completed");
                this.Close();
            }
            else
            {
                MessageBox.Show("Make sure all the green fields are filled!!!");
            }
        }
    }
}
