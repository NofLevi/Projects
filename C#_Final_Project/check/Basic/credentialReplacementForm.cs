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
    public partial class credentialReplacementForm : Form
    {
        string connString;
        OleDbConnection con;
        List<string> listOfEmails = new List<string>();
        int listOfEmailsCounter;
        smtpHandler smtpHandler = new smtpHandler();
        
        
        string loseType;
        string code;

        public credentialReplacementForm(String loseType)
        {
         
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            button1.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            button2.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            button3.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            label1.Text = "Forgot " + loseType ;
            this.loseType = loseType;
            codeLabel.Visible = false;
            CodeTextBox.Visible = false;
            label4.Text = "no such email was found ";
            label4.Visible = false;
            connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new OleDbConnection(connString);


            button3.Enabled = false;
            button2.Enabled = false;
            using (OleDbCommand cmd = new OleDbCommand("SELECT Email FROM LoginTable", con))// note to self change list wit Email
            {

                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listOfEmails.Add(reader.GetValue(0).ToString());
                }

                con.Close();
            }
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        // when back to login buttton get click this func is called and returens to log in and closes this form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }


        //when the button gets clicked and the code sent to the Email matches the code textbox this func
        // the func sends the id to the email of the employ Email or open the password change from if they wish to change the password
        private void button3_Click(object sender, EventArgs e)
        {

           if(CodeTextBox.Text == code)
            {
                if (loseType.ToLower() == "password")
                {
                    this.Hide();
                    ChangingPasswordForm CCform = new ChangingPasswordForm(loseType, listOfEmails[listOfEmailsCounter]);
                    CCform.ShowDialog();
                    this.Close();
                }
                else
                {
                    string theyId;
                    
  
                    using (OleDbCommand cmd = new OleDbCommand("SELECT LoginName FROM LoginTable where Email = '" + listOfEmails[listOfEmailsCounter]+"'", con))// note to self change list wit Email
                    {
                       // MessageBox.Show("SELECT LoginName FROM LoginTable where Email = '" + listOfEmails[listOfEmailsCounter] + "'");

                        con.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        theyId = reader.GetValue(0).ToString();
                            //   Console.WriteLine(reader.GetValue(0).ToString());
                        
                        con.Close();
                    }
                    
                    theyId = Encryption.Base64Decode(theyId);
                    smtpHandler.EmailOneFunc(EmailTextbox.Text, "here is the loging Id \n if you have not requested it please speak with the shop maneger as you could have a securety breach \n\n\n  "+theyId,"Forgotten ID to Mail.");

                    MessageBox.Show("your Id as been sent to your email please go chack");

                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                    this.Close();
                }
            }
           else
            {
                wrongCodeLabel.Text = "you have enters a wrong code please re-enter again";
                CodeTextBox.Clear();
            }
        }

        // turn the send code button to fasle if the email textbox is empty and true if there is text in it 
        private void EmailTextbox_TextChanged(object sender, EventArgs e)
        {
            if (EmailTextbox.Text != "")
                button2.Enabled = true;
            else
                button2.Enabled = false;
        }


        //  this button calls SendCodeToEmail
        private void button2_Click(object sender, EventArgs e)
        {
            SendCodeToEmail();

        }

        //this func go's tru all the email of employs in a list and if it matchs with the email givin in the text box it send a code
        private void SendCodeToEmail()
        {
            bool flag = false;
            code = smtpHandler.codeGennorator();
            string body = "an email has been sent to this account do to the clam of a lost " + loseType + " if you didnt request this " + loseType + " reset plase chack you login ditals and do a secure swip . we recommed a password change , please talk to a menager at your store\n \n \n \n  the code:" + code;

            for (int i = 0; i < listOfEmails.Count; i++)
            {
                if (listOfEmails[i].ToLower() == EmailTextbox.Text.ToLower())
                {
                    label4.Visible = false;
                    listOfEmailsCounter = i;
                    smtpHandler.EmailOneFunc(EmailTextbox.Text, body, "reset " + loseType + " request");

                    codeLabel.Visible = true;
                    CodeTextBox.Visible = true;
                    //MessageBox.Show("an email with a code has been sent");
                    flag = true;
                }
            }
            if (!flag)
            {
                label4.Visible = true;
            }
        }

        // turns submit button to true of there is text in the code textbox and false if empty
        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CodeTextBox.Text != "")
                button3.Enabled = true;
            else
                button3.Enabled = false;
        }

    }
}
