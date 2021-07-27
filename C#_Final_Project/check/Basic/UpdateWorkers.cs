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
    public partial class UpdateWorkers : Form
    {
        SQLFuncs sqlfuncs = new SQLFuncs();
        DataTable dt;
        string name;
        public UpdateWorkers(string name)
        {
            InitializeComponent();
            this.name = name;
            dt = sqlfuncs.GetTable("SELECT * FROM LoginTable");
            setComboBox();
            GUI();
        }

        void GUI() //SETUP GUI DESIGN
        {
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            button1.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            button3.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            RemoveButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
        }

        public void setComboBox() //SET WORKERS COMBOBOX 
        {
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row["FullName"].ToString());
            }
            comboBox1.Items.Remove(name);
        }

        private void RemoveButton_MouseClick(object sender, MouseEventArgs e) // REMOVE WORKER FROM SQL
        {
            if(comboBox1.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user from the system  ? ", "Question Box", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlfuncs.AddRemoveChange("DELETE  FROM LoginTable WHERE FullName = '" + comboBox1.Text + "';");
                }
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e) // OPEN ADD WORKER FORM
        {
            this.Hide();
            AddWorker f2 = new AddWorker();
            f2.ShowDialog();
            this.Show();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e) //OPEN EDIT WORKER FORM
        {
            this.Hide();
            EditWorker f2 = new EditWorker(comboBox1.Text);
            f2.ShowDialog();
            this.Close();
        }
    }
}
