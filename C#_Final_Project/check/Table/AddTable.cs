using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace check
{
    public partial class AddTable : Form
    {
        int listsize;
        SQLFuncs sqlfuncs = new SQLFuncs();
        List<Label> namelabellist = new List<Label>();
        List<TextBox> nametextboxlist = new List<TextBox>();
        List<Label> datatypelabellist = new List<Label>();
        List<ComboBox> datatypecombolist = new List<ComboBox>();
        Form1 Table;
        string user;
        public AddTable(Form1 Table,string user)
        {
            InitializeComponent();
            this.Table = Table;
            this.user = user;
            init();
        }



        public void init() // SET GUI AND FORM
        {
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            AddColumnButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            DeleteColumnButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            ConfirmButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            namelabellist.Add(namelabel1);
            nametextboxlist.Add(nametextbox1);

        }

        private void DeleteColumnButton_MouseClick(object sender, MouseEventArgs e)//DECREASE THE AMOUNT OF COLUMNS
        {
            listsize = namelabellist.Count;
            if(listsize > 1)
            {

                //remove last obj
                this.Controls.Remove(namelabellist[listsize - 1]);
                this.Controls.Remove(nametextboxlist[listsize - 1]);

                //remove from list
                namelabellist.RemoveAt(listsize-1);
                nametextboxlist.RemoveAt(listsize-1);

                //buttons going up

                ConfirmButton.Location = new Point(ConfirmButton.Location.X, ConfirmButton.Location.Y - 30);
                AddColumnButton.Location = new Point(AddColumnButton.Location.X, AddColumnButton.Location.Y - 30);
                DeleteColumnButton.Location = new Point(DeleteColumnButton.Location.X, DeleteColumnButton.Location.Y - 30);

            }

            else
            {
                MessageBox.Show("Cannot Remove The first lines!!!!");
            }
        }

        private void AddColumnButton_MouseClick(object sender, MouseEventArgs e) //INCREASING THE AMOUNT OF COLUMNS
        {
            listsize = namelabellist.Count;
            //namelabels
            Label tempnamelabel = new Label();
            tempnamelabel.Text = namelabel1.Text;
            tempnamelabel.Font = namelabel1.Font;
            tempnamelabel.ForeColor = namelabel1.ForeColor;
            tempnamelabel.Location = new Point(namelabellist[listsize-1].Location.X, namelabellist[listsize-1].Location.Y + 30);
            tempnamelabel.Visible = true;
            namelabellist.Add(tempnamelabel);

            //nametextboxes
            TextBox temptextbox = new TextBox();
            temptextbox.Location = new Point(nametextboxlist[listsize-1].Location.X, nametextboxlist[listsize-1].Location.Y + 30);
            temptextbox.Visible = true;
            nametextboxlist.Add(temptextbox);


            this.Controls.Add(namelabellist[listsize]);
            this.Controls.Add(nametextboxlist[listsize]);
            //fix buttons locations
            ConfirmButton.Location = new Point(ConfirmButton.Location.X, ConfirmButton.Location.Y + 30);
            AddColumnButton.Location = new Point(AddColumnButton.Location.X, AddColumnButton.Location.Y + 30);
            DeleteColumnButton.Location = new Point(DeleteColumnButton.Location.X, DeleteColumnButton.Location.Y + 30);

        }

        private void ConfirmButton_MouseClick(object sender, MouseEventArgs e) //CREATING NEW TABLE
        {
            string sql = "CREATE TABLE " + TableNameTextBox.Text + " (" + uniquefieldcombobox.Text + " CHAR(50),";
            
            for(int i = 0; i < namelabellist.Count; i++)//create string with the currect query
            {
                if(nametextboxlist[i].Text != "")
                {
                    sql += nametextboxlist[i].Text + " CHAR(50),";
                }
            }


            sql += "RegistrationDate DATE);";


            try
            {
                sqlfuncs.AddRemoveChange(sql);
                sqlfuncs.AddRemoveChange("ALTER TABLE " + TableNameTextBox.Text + " ADD PRIMARY KEY(" + uniquefieldcombobox.Text + ");");
                sql = "INSERT INTO `LOGTables`(`TableName`, `Action`, `User`, `When`) VALUES('" + TableNameTextBox.Text +"', 'Add Table','" +user +"', NOW());";
                sqlfuncs.AddRemoveChange(sql);
                MessageBox.Show("The table added Successfully!!!");
                Table.tablest = TableNameTextBox.Text;
                Table.tableMaker();
                this.Close();
            }

            catch
            {
                MessageBox.Show("An Error Occurd. make sure you fill all the require fields.");
            }

 
        }
    }
}
