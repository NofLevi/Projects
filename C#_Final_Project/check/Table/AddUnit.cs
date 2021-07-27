using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class AddUnit : Form
    {
        SQLFuncs sqlfuncs = new SQLFuncs();
        string tablename = "";
        List<Label> labellist = new List<Label>();
        List<TextBox> textlist = new List<TextBox>();
        DataGridView dgv;
        Form1 Table;

        public AddUnit(string tablename,DataGridView dgv, Form1 Table)
        {
            InitializeComponent();
            this.Table = Table;
            this.dgv = dgv;
            this.tablename = tablename;
            init();
        }



        public void init() //init labels and textfields and gui
        {
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            ConfirmButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            labellist.Add(label1);
            textlist.Add(textBox1);
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (i == 0)
                {
                    labellist[i].Text = dgv.Columns[i].Name;
                }
                else
                {
                    Label tempnamelabel = new Label();
                    tempnamelabel.Text = dgv.Columns[i].Name;
                    tempnamelabel.Font = label1.Font;
                    tempnamelabel.ForeColor = label1.ForeColor;
                    tempnamelabel.Location = new Point(labellist[i - 1].Location.X, labellist[i - 1].Location.Y + 30);
                    tempnamelabel.Visible = true;
                    labellist.Add(tempnamelabel);

                    TextBox temptextbox = new TextBox();
                    temptextbox.Location = new Point(textlist[i - 1].Location.X, textlist[i - 1].Location.Y + 30);
                    temptextbox.Visible = true;
                    textlist.Add(temptextbox);



                    this.Controls.Add(labellist[i]);
                    this.Controls.Add(textlist[i]);
                    //fix buttons locations
                    ConfirmButton.Location = new Point(ConfirmButton.Location.X, ConfirmButton.Location.Y + 30);


                }
                if (labellist[i].Text == "ID" || labellist[i].Text == "Email")
                {
                    labellist[i].ForeColor = System.Drawing.Color.LimeGreen;
                }

                if(labellist[i].Text  == "RegistrationDate")
                {
                    textlist[i].Enabled = false;
                }
            }

        }

        private void ConfirmButton_MouseClick(object sender, MouseEventArgs e)
        {
            
            string columnnames = "";
            string columnvalues = "";
            
            for(int i = 0; i < labellist.Count; i ++)
            {
                columnnames += labellist[i].Text;
                if(labellist[i].Text == "RegistrationDate")
                {
                    columnvalues += "NOW()";
                }
                else
                {
                    columnvalues += "'" + textlist[i].Text + "'";
                }
                
                if(i != labellist.Count-1)
                {
                    columnnames += ",";
                    columnvalues += ",";
                }
            }
            columnnames.Remove(columnnames.Length - 1);
            columnvalues.Remove(columnvalues.Length - 1);

            string sql = "INSERT INTO " + tablename + " (" + columnnames + ") VALUES(" + columnvalues + ");";
            try
            {
                sqlfuncs.AddRemoveChange(sql);
                sql = "INSERT INTO `LOGUnits`(`TableName`, `Action`, `ColumnChanged` , `UniqueField`, `From`, `To`, `User` , `When`) VALUES('" + tablename + "','Add Unit','NONE','" + textBox1.Text + "','NONE','NONE','" + Table.name + "',NOW());";
                sqlfuncs.AddRemoveChange(sql);
                Table.tableMaker();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Green fields have to be filled and cannot have duplication");
            }


        }
    }
}
