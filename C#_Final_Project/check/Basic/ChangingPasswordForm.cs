using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class ChangingPasswordForm : Form
    {

        string connString;
        OleDbConnection con;
        string Email;
        public ChangingPasswordForm(string losetype, string Email)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            subbmitButton.ForeColor =  ColorTranslator.FromHtml("#2B2D42");
            button1.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new OleDbConnection(connString);
            this.Email = Email;
            label1.Text = "Changing " + losetype;
            label2.Visible = false;
        }

        // this button opens the login form and closes this one
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
        //this button click calls the func PasswordChanger
        private void button2_Click(object sender, EventArgs e)
        {
            PasswordChanger();
        }

        //this func chacks if both text fields are not empty and are the same and changes the password in the SQL based on the employ email
        private void PasswordChanger()
        {
            if (passwordTextBox.Text == "" && reenterTextBox.Text == "")
            {
                label2.Visible = true;
            }
            else
            if (passwordTextBox.Text == reenterTextBox.Text)
            {
                label2.Visible = false;
                using (OleDbCommand cmd = new OleDbCommand("UPDATE LoginTable SET [Password] = '" + Encryption.Base64Encode(passwordTextBox.Text) + "' WHERE [Email] = '" + Email + "';", con))// note to self change list wit Email
                {
                    MessageBox.Show("UPDATE LoginTable SET [Password] = '" + Encryption.Base64Encode(passwordTextBox.Text) + "' WHERE [Email] = '" + Email + "';");

                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    con.Close();
                }

                MessageBox.Show("Password Changed!!!");
                this.Hide();
                Login f2 = new Login();
                f2.ShowDialog();
                this.Close();
            }
        }
    }
}
