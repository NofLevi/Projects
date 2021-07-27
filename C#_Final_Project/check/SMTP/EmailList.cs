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
    public partial class EmailList : Form
    {
        smtpHandler smtphandler;
        List<String> Emaillist;
        
        public EmailList()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            Email_list.BackColor = ColorTranslator.FromHtml("#2B2D42");
            smtphandler = new smtpHandler();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }

        private void EmailList_Load(object sender, EventArgs e)
        {
            listsetter();

        }

        //sets list of custumers emails
        private void listsetter()
        {
            int emailNum = 0;
            Email_list.Text = "";
            List<String> Emaillist = smtphandler.CustomerTableToList();
            foreach (string k in Emaillist)
            {
                emailNum++;
                Console.WriteLine(k);
                Email_list.Text = Email_list.Text + emailNum + ") " + k + "\n";
            }
        }
    }
}
