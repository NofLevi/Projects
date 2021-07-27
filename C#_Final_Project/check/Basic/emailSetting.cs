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
    public partial class emailSetting : Form
    {

        String Email;
        String SecurePw;
        String EmailHastag;
        string EmailInUse;
        string EmailType;
        string PasswordInUse;
        string connString;
        OleDbConnection con;
        public emailSetting()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            Submit_button.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new OleDbConnection(connString);
            changeCurrEmailIdText();
            changeCurrSecurepassword();
            EmailType_comboBox.SelectedIndex =0;
            

        }
        //changes the text to show the current password
        private void changeCurrSecurepassword()
        {
            using (OleDbCommand cmd = new OleDbCommand("SELECT SecurePassword FROM EmailLogin", con))//displays email in use
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                //MessageBox.Show(reader.GetValue(0).ToString());
                Curr_securePassword.Text = "Secure password in use : " + reader.GetValue(0).ToString();
                PasswordInUse = reader.GetValue(0).ToString();
                con.Close();
            }
        }

        //changes the text to show the current email
        private void changeCurrEmailIdText()
        {
            using (OleDbCommand cmd = new OleDbCommand("SELECT Email FROM EmailLogin", con))//displays email in use
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                // MessageBox.Show(reader.GetValue(0).ToString());
                curr_email_id.Text = "Email in use : " + reader.GetValue(0).ToString();
                EmailInUse = reader.GetValue(0).ToString();
                con.Close();
            }



            using (OleDbCommand cmd = new OleDbCommand("SELECT EmailType FROM EmailLogin", con))//displays email in use
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                // MessageBox.Show(reader.GetValue(0).ToString());
                curr_email_id.Text = curr_email_id.Text + reader.GetValue(0).ToString();
                EmailType = reader.GetValue(0).ToString();
                con.Close();
            }
            
        }

        //gets call then the form is loaded
        private void emailSetting_Load(object sender, EventArgs e)
        {
            
        }

        //gets call then button1 (only button in the form "subbmit")
        private void button1_Click(object sender, EventArgs e)
        {
            changeEmailInSQL();
            changeSecurepasswordInSQL();
            
        }

        //change the password in the SQL datatable
        private void changeSecurepasswordInSQL()
        {
            if (SecurePw_textbox.Text == "")
            {
                MessageBox.Show("password text box cant be enpty");
            }
            else
            {
                string sql = "UPDATE EmailLogin SET [SecurePassword] = '" + SecurePw_textbox.Text + "' WHERE [Email] = '" + EmailInUse + "';";
                using (OleDbCommand cmd = new OleDbCommand(sql, con)) //delete current row
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                changeCurrSecurepassword();
            }
        }

        //change the email in the SQL datatable
        private void changeEmailInSQL()
        {
            if (Email_textbox.Text == "")
            {
                MessageBox.Show("email text cant be empty");
            }
            else
            {
                string sql = "UPDATE EmailLogin SET [Email] = '" + Email_textbox.Text + "' WHERE [Email] = '" + EmailInUse + "';";

                using (OleDbCommand cmd = new OleDbCommand(sql, con)) //delete current row
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                changeEmailTypeInSQL();
                changeCurrEmailIdText();
            }
        }

        //change the emailType in the SQL datatable
        private void changeEmailTypeInSQL()
        {
            string sql = "UPDATE EmailLogin SET [EmailType] = '" + EmailType_comboBox.Text + "' WHERE [EmailType] = '" + EmailType + "';";
       
            using (OleDbCommand cmd = new OleDbCommand(sql, con)) //delete current row
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //gets call then email textbox text gets change to make sure the button is enabled when both textboxes have text 
        private void Email_textbox_TextChanged(object sender, EventArgs e)
        {
            if (Email_textbox.Text != "" && SecurePw_textbox.Text != "")
            {
                Submit_button.Enabled = true;
            }
            else
            {
                Submit_button.Enabled = false;
            }
        }

        //gets call then password textbox text gets change to make sure the button is enabled when both textboxes have text 
        private void SecurePw_textbox_TextChanged(object sender, EventArgs e)
        {
            if (Email_textbox.Text != "" && SecurePw_textbox.Text != "")
            {
                Submit_button.Enabled = true;
            }
            else
            {
                Submit_button.Enabled = false;
            }
        }
    }
}
