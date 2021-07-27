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
    public partial class MultiMail : Form
    {

        MainMenu main;
        smtpHandler smtp = new smtpHandler();
        List<string> attechmentList = new List<string>();
        int comboBoxCounter = 0;
        public MultiMail(MainMenu main)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            backButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            addAttechment.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            removeAttechment.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            button1.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            bodyText.BackColor = ColorTranslator.FromHtml("#2B2D42");
            attechmentTextBox.BackColor = ColorTranslator.FromHtml("#2B2D42");
            this.main = main;
        }


        // occurs when backButton is clicked and opens main menu form and closes this one 
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            smtpForm smtpForm = new smtpForm(main);
            smtpForm.ShowDialog();
            this.Close();
        }

        // occurs when backButton the send button  gets clicked and called one of 3 send mail funcs from smtp based on if there is an attechment
        private void button1_Click(object sender, EventArgs e)
        {
            if(TitleText.Text =="" || bodyText.Text=="")
            {
                MessageBox.Show("please fill both title and body boxes");
            }
            else
            {
                if (removeComboBox.Items.Count == 0)
                    smtp.MailerSender(smtp.CustomerTableToList(), TitleText.Text, bodyText.Text);
                if (removeComboBox.Items.Count == 1)
                    smtp.MailerSender(smtp.CustomerTableToList(), TitleText.Text, bodyText.Text, attechmentList[0]);
                if (removeComboBox.Items.Count > 1)
                    smtp.MailerSender(smtp.CustomerTableToList(), TitleText.Text, bodyText.Text, attechmentList);
            }
        }

        //  occurs when add Attechment Button  gets clicked , opens filedialog to select attechment to the mail
        private void addAttechment_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
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

        //  occurs when remove Attechment Button  gets clicked , after a number as giving removes file path from a list
        private void removeAttechment_Click(object sender, EventArgs e)
        {
            if (removeComboBox.Text != "")
            {
                attechmentList.RemoveAt((System.Convert.ToInt32(removeComboBox.Text)) - 1);
                attechmentTextBoxRewriter();
            }
            if (removeComboBox.Items.Count == 0)
                removeAttechment.Enabled = false;
        }

        // this function turn the remove attechment button true only if a number from a combo box is selected
        private void removeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (removeComboBox.Text != "")
                removeAttechment.Enabled = true;
        }
    }
}
