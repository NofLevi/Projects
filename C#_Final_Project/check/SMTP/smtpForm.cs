using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class smtpForm : Form
    {
        OleDbConnection con;
        string connString;
        String currEmail;
        String currSecurePassword;
        smtpHandler smtpHandler = new smtpHandler();
        string id;
        int perm;
        MainMenu main;

        LogoImageHandler LogoHand = new LogoImageHandler();


     

        public smtpForm(MainMenu main)
        {
            InitializeComponent();
            setGUI();
            connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new OleDbConnection(connString);
            this.main = main;
            id = main.GetId();
            perm = main.GetPerm();
          
            //    pictureBox1.Image = LogoHand.ChangeLogoImage();
               pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
            getCurrSecurepassword();
            getCurrEmailIdText();

            pictureBox1.Image = LogoHand.ChangeLogoImage();

        }
        public string getId() { return id; }
        public void setId(string id) { this.id = id; }

        public int getPerm() { return perm; }
        public void setperm(int perm) { this.perm = perm; }


        //sets form GUI , background and button color
        void setGUI()
        {
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            button1.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            sendMulitButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            Email_list_button.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            text_button.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            MainMenu_Button.ForeColor = ColorTranslator.FromHtml("#2B2D42");
        }

        // gets the current secure password for the SQL
        private void getCurrSecurepassword()
        {
            using (OleDbCommand cmd = new OleDbCommand("SELECT SecurePassword FROM EmailLogin", con))//displays email in use
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();

                //MessageBox.Show(reader.GetValue(0).ToString());

                currSecurePassword = reader.GetValue(0).ToString();
                con.Close();
            }
        }

        // gets the current secure EMAIL for the SQL
        private void getCurrEmailIdText()
        {

            using (OleDbCommand cmd = new OleDbCommand("SELECT Email FROM EmailLogin", con))//displays email in use
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();

                // MessageBox.Show(reader.GetValue(0).ToString());

                currEmail = reader.GetValue(0).ToString();

                con.Close();
            }
        }

        // open the Email list form
        private void Email_list_button_Click(object sender, EventArgs e)
        {
            EmailList emaillist = new EmailList();
            emaillist.ShowDialog();
            
        }

        // opens the setting form , MOVED TO AMIN SETTING !!!
        private void Email_setting_button_Click(object sender, EventArgs e)
        {
            emailSetting emailSetting = new emailSetting();
            emailSetting.ShowDialog();

        }

        // gets and sets the label of the user name and its perm
        private void smtpForm_Load(object sender, EventArgs e)
        {
            NameLabel.Text = main.GetId();
            PermissionLabel.Text = main.GetPerm().ToString();
        }


        // opens singel mail form  if there is an email and password
        private void button1_Click(object sender, EventArgs e)
        {
          if(currEmail.ToLower() != "N/A" && currSecurePassword.ToLower() !="N/A")
            {
                setup_label.Enabled = false;
                setup_label.Visible = false;


                this.Hide();
                Form singleEmail = new singleEmail(main);
                singleEmail.ShowDialog();
                this.Show();


            }
          else
            {
                setup_label.Enabled = true;
                setup_label.Visible = true;
                SMTPSetupButton.Visible = true;
                button1.Visible = false;
                sendMulitButton.Visible = false;
                Email_list_button.Visible = false;
                text_button.Visible = false;
            }
        }

       
        // calls the test func from smtp 
        private void text_button_Click(object sender, EventArgs e)
        {
            smtpHandler.EmailTestFunc();
        }

        // when cicked opens main menu and closes this form
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();
            pictureBox1.Dispose();

            this.Hide();
            MainMenu MM = new MainMenu(id, perm);
            MM.ShowDialog();
            this.Close();
        }


        // opens the multi main form
        private void sendMulitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiMail multiMail = new MultiMail(main);
            multiMail.ShowDialog();
            this.Show();
        }

        //opens the SMTP sett up form and closes this one 
        private void SMTPSetup_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            SMTPSetup form2 = new SMTPSetup();
            form2.ShowDialog();
            Login f2 = new Login();
            f2.ShowDialog();
            this.Close();
        }
    }
}
