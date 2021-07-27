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
    public partial class MainMenu : Form
    {
        String id;
        int perm;

        public MainMenu(string Id , int Perm)
        {
            InitializeComponent();
            id = Id;
            perm = Perm;
            permcheck();
            GUI();
        }
        public string GetId() { return id; }
        public int GetPerm() { return perm; }

        void GUI() //SETUP GUI DESIGN
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            TableButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            EmailFormOpener.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            AdminSettingsButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            UserNameLable.Text = "Welcome " + id;
            Permissionlevel.Text = "Permission-level: " + perm.ToString();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        public bool permcheck() //CHECKING THE PERMISSION LEVEL AND OPEN THE RIGHT SETTINGS
        {
            if(perm < 3)
            {
                AdminSettingsButton.Visible = false;
                if (perm < 2)
                {
                    EmailFormOpener.Visible = false;
                }
                return false;
            }
            return true;
        }
        private void EmailFormOpener_Click(object sender, EventArgs e) //OPEN MAIL FORM
        {
            this.Hide();
            smtpForm smtpForm = new smtpForm(this);
            smtpForm.setId(id);
            smtpForm.setperm(perm);
            this.Close();
            smtpForm.ShowDialog(this);
        }
        private void reopenMainMenu()
        {
            this.Visible = true;
        }
        private void MainMenu_TextChanged(object sender, EventArgs e)
        {
            this.Visible = true;
        }
        private void TableButton_MouseClick(object sender, MouseEventArgs e) //OPEN TABLE FORM
        {
            this.Hide();
            Form1 f2 = new Form1(id, perm);
            f2.ShowDialog();
            this.Show();
        }
        private void AdminSettingsButton_MouseClick(object sender, MouseEventArgs e) // OPEN ADMIN SETTINGS FORM
        {
            this.Hide();
            AdminSettings f2 = new AdminSettings(id);
            f2.ShowDialog();
            this.Show();
        }
    }
}
