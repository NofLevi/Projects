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
    public partial class singleEmail : Form
    {
        smtpHandler smtpHandler = new smtpHandler();
        OleDbConnection con;
        string connString;
        int perm;
        string id;
        MainMenu main;
        List<string> attechmentList = new List<string>();
        int comboBoxCounter = 0;



        public singleEmail(MainMenu main)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            button2.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            addAttechment.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            removeAttechment.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            button1.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            bodybox.BackColor = ColorTranslator.FromHtml("#2B2D42");
            attechmentTextBox.BackColor = ColorTranslator.FromHtml("#2B2D42");
            connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new OleDbConnection(connString);
            this.main = main;
            bodybox.ScrollBars = ScrollBars.Vertical;
            attechmentTextBox.ScrollBars = ScrollBars.Vertical;
            removeAttechment.Enabled = false;
            //   MessageBox.Show("hello there");
        }


        //calls when the form loads
        private void singleEmail_Load(object sender, EventArgs e)
        {
            SuggestFromCustomerEmail();
        }


        //gets all the emails from customer table and add it to a AutoCompleStringCollection list so it can be suggested on the email text box
        private void SuggestFromCustomerEmail()
        {
            AutoCompleteStringCollection autoText_Email = new AutoCompleteStringCollection();
            using (OleDbCommand cmd = new OleDbCommand("SELECT Email FROM CustomersTable", con))
            {
                List<string> list = new List<string>();
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    autoText_Email.Add(reader.GetValue(0).ToString());
                    //   Console.WriteLine(reader.GetValue(0).ToString());
                }
                Email_textbox.AutoCompleteMode = AutoCompleteMode.Suggest;
                Email_textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                Email_textbox.AutoCompleteCustomSource = autoText_Email;
                con.Close();


            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // send func handles the mail send with 3 overloads
            send();
        }


        //handles witch overload to use base on attchement and calls the smtp function
        private void send()
        {
            if (Email_textbox.Text == "" || titlebox.Text == "" || bodybox.Text == "")
            {
                MessageBox.Show("please fill all boxes acorrdingly");
            }
            else
            {
                if (removeComboBox.Items.Count == 0)
                    smtpHandler.EmailOneFunc(Email_textbox.Text, bodybox.Text, titlebox.Text);
                if (removeComboBox.Items.Count == 1)
                    smtpHandler.EmailOneFunc(Email_textbox.Text, bodybox.Text, titlebox.Text, attechmentList[0]);
                if (removeComboBox.Items.Count > 1)
                    smtpHandler.EmailOneFunc(Email_textbox.Text, bodybox.Text, titlebox.Text, attechmentList);
            }
        }


        // when the back button is click it opens main menu form and closes this
        private void button2_Click(object sender, EventArgs e)
        {  
            this.Hide();
            smtpForm smtpForm = new smtpForm(main);
            smtpForm.ShowDialog();
            this.Close(); 
        }



        //  occurs when add Attechment Button  gets clicked , opens filedialog to select attechment to the mail
        private void addAttechment_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                comboBoxCounter++;
                removeComboBox.Items.Add(comboBoxCounter);
                attechmentList.Add(dlg.FileName.ToString());
                attechmentTextBoxRewriter();
            }
        }


        //  when the addAttechment_Click func gets called this func rewrites the text field to the current one off a list
        private void attechmentTextBoxRewriter()
        {
            attechmentTextBox.Clear();
            removeComboBox.Items.Clear();
            for (int i = 0; i < attechmentList.Count; i++)
            {
                removeComboBox.Items.Add((1 + i));
                attechmentTextBox.Text = attechmentTextBox.Text + "\r\n " + (i + 1) + ") " + attechmentList[i] + "\r\n ";


            }
        }

        // this function turn the remove attechment button true only if a number from a combo box is selected
        private void removeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(removeComboBox.Text != "")
            removeAttechment.Enabled = true;
          

        }

        //  occurs when remove Attechment Button  gets clicked , after a number as giving removes file path from a list
        private void removeAttechment_Click(object sender, EventArgs e)
        {
            if (removeComboBox.Text != "")
            {
               
                
                attechmentList.RemoveAt((System.Convert.ToInt32(removeComboBox.Text))-1);
                
                attechmentTextBoxRewriter();

            }
            if (removeComboBox.Items.Count == 0)
                removeAttechment.Enabled = false;
        }

        
    }
}
