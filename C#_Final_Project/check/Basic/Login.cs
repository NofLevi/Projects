using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace check
{
    public partial class Login : Form
    {
        DataTable dt = new DataTable();
        LogoImageHandler logoHand = new LogoImageHandler();


        OleDbConnection con;
        HttpClient httpClient = new HttpClient();



        public Login()
        {      
            InitializeComponent();
            BackUp();
            GUI();
            label1.Visible = false;





          


            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new OleDbConnection(connString);

            string SMTPSetUpChack = null;
            try
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT Email FROM EmailLogin", con))//displays email in use
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    // MessageBox.Show(reader.GetValue(0).ToString());
                    SMTPSetUpChack = reader.GetValue(0).ToString();


                    con.Close();
                }
            }
            catch
            {
                forgotPasswordLabel.Enabled = false;
                forgotId.Enabled = false;
                label1.Visible = true;



            }
            if(SMTPSetUpChack== "N/A")
            {
                forgotPasswordLabel.Enabled = false;
                forgotId.Enabled = false;
                label1.Visible = true;
            }


        }

        void GUI() //SETUP GUI DESIGN
        {
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.Image = logoHand.ChangeLogoImage();
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            LoginButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        void BackUp() // MAKING A TEMP COPY OF THE REAL ACCESS FILE
        {
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT bin directory (ie ../bin/)
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            // This will get the current PROJECT directory
            projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string folderPath = projectDirectory + "\\Database1.accdb";
            DateTime dateTime = DateTime.UtcNow.Date;

            string destinationFile = projectDirectory + "\\BackUps\\Database1.accdb";
            try
            {
                File.Copy(folderPath, destinationFile, true);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
        }


        public int LoginCheck(string id,string pass) // SEARCHING THE NAME ENTERED IN THE SQL AND RETURNING THE PERMISSION LVL IF HE EXIST
        {
            int perm = -1;
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connString);
            using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM LoginTable WHERE LoginName = '" + id + " '", con))
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    if (reader.FieldCount > 0)
                    {
                        if (reader.GetValue(0).ToString() == id && reader.GetValue(1).ToString() == pass)
                        {
                            perm = Convert.ToInt32(reader.GetValue(2).ToString());
                            return perm;
                        }
                        return perm;
                    }

                    else
                    {
                        return perm;
                    }
                }
                return perm;
            }
        }

        private void LoginButton_MouseClick(object sender, MouseEventArgs e) //LOGIN BUTTPN [ENCRYPTING THE DATA ENTERED TO THE FIELDS AND SENDING TO LoginCheck function to check if he exist]
        {
            string id = Encryption.Base64Encode(IDTextField.Text);
            string pass = Encryption.Base64Encode(PasswordTextField.Text);

            if (id == "")
                MessageBox.Show("Name field is empty !!!");

            else if (pass == "")
                MessageBox.Show("Password field is empty!!!");

            else
            {
                int perm = LoginCheck(id, pass);

                if(perm > -1)
                {
                    Logo.Image.Dispose();
                    this.Hide();
                    MainMenu f2 = new MainMenu(Encryption.Base64Decode(id),perm);
                    f2.ShowDialog();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("The login info are incorrect");
                }
            }

        }

        private void forgotPasswordLabel_MouseHover(object sender, EventArgs e)
        {
            forgotPasswordLabel.ForeColor = Color.FromArgb(0, 169, 204);
        }

        private void forgotPasswordLabel_MouseLeave(object sender, EventArgs e)
        {
            forgotPasswordLabel.ForeColor = Color.FromArgb(0, 102, 204);
        }

        private void forGotId_MouseHover(object sender, EventArgs e)
        {
            forgotId.ForeColor = Color.FromArgb(0, 169, 204);
        }

        private void forGotId_MouseLeave(object sender, EventArgs e)
        {
            forgotId.ForeColor = Color.FromArgb(0, 102, 204);
        }

        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {
            bool flag = true;

            
           string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new OleDbConnection(connString);

            string SMTPSetUpChack;
            try
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT Email FROM EmailLogin", con))//displays email in use
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    // MessageBox.Show(reader.GetValue(0).ToString());
                    SMTPSetUpChack = reader.GetValue(0).ToString();


                    con.Close();
                }
            }
            catch
            {
                flag = false;
            }


          
            
                this.Hide();
                credentialReplacementForm CRform = new credentialReplacementForm("password");
                CRform.ShowDialog();
                this.Close();
            
        }

        private void forgotId_Click(object sender, EventArgs e) 
        {
            this.Hide();
            credentialReplacementForm CRform = new credentialReplacementForm("Id");
            CRform.ShowDialog();
            this.Close();
        }

      
    }
}
