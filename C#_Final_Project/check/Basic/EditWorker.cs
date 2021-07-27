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
    public partial class EditWorker : Form
    {
        string name;
        SQLFuncs sqlfuncs = new SQLFuncs();
        public EditWorker(string name)
        {
            this.name = name;
            InitializeComponent();
            GUI();
        }

        void GUI() //SETUP GUI DESIGN
        {
            comboBox1.SelectedIndex = 0;
            button1.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            button2.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            button3.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            button4.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            NameLabel.Text = name;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e) // CHANGE LOGIN NAME
        {
            if(LoginIDTextBox.Text.Length > 2)
            {
                string sql = "UPDATE LoginTable SET [LoginName] = '" + Encryption.Base64Encode(LoginIDTextBox.Text) + "' WHERE [FullName] = '" + name + "';";
                sqlfuncs.AddRemoveChange(sql);
                MessageBox.Show("Login ID as been changed!!!");
            }
            else
            {
                MessageBox.Show("ID is shorter then 3 or taken");
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e) // CHANGING PASSWORD
        {
            if (PasswordTextBox.Text.Length > 5)
            {
                string sql = "UPDATE LoginTable SET [Password] = '" + Encryption.Base64Encode(PasswordTextBox.Text) + "' WHERE [FullName] = '" + name + "';";
                sqlfuncs.AddRemoveChange(sql);
                MessageBox.Show("Password as been changed!!!");
            }
            else
            {
                MessageBox.Show("Password is shorter then 5 make it longer and try again!!!");
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e) //CHANGE EMAIL
        {
            if (IsValidEmail(MailTextBox.Text))
            {
                string sql = "UPDATE LoginTable SET [Email] = '" + MailTextBox.Text + "' WHERE [FullName] = '" + name + "';";
                sqlfuncs.AddRemoveChange(sql);
                MessageBox.Show("Email as been changed!!!");
            }
            else
            {
                MessageBox.Show("Email is not valid fix it and try again!!!");
            }

        }

        private void button4_MouseClick(object sender, MouseEventArgs e) // CHANGE PERMISSION
        {
            int temp = comboBox1.SelectedIndex + 1;
            string sql = "UPDATE LoginTable SET [Permission] = '" + temp.ToString() + "' WHERE [FullName] = '" + name + "';";
            sqlfuncs.AddRemoveChange(sql);
            MessageBox.Show("Permission as been changed!!");
        }

        bool IsValidEmail(string email) //CHECKING IF EMAIL IS VALID
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
    }
}
