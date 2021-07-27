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
    public partial class EditRow : Form
    {
        string table,keyvalue,keycolname,colname;
        Form1 Table;
        string oldvalue;
        SQLFuncs sqlfuncs = new SQLFuncs();



        public EditRow(string table,string keyvalue,string keycolname,string colname, Form1 Table,string oldvalue)
        {
            InitializeComponent();
            this.Table = Table;
            this.table = table;
            this.keyvalue = keyvalue;
            this.colname = colname;
            this.keycolname = keycolname;
            this.oldvalue = oldvalue;
            GUI();
        }

        void GUI() //SETUP GUI
        {
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            ConfirmButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
        }

        private void ConfirmButton_MouseClick(object sender, MouseEventArgs e) //EDITING THE CELL
        {
            string st = textbox.Text;
            string sql;

            try
            {
                //add to logs
                sql = "INSERT INTO `LOGUnits`(`TableName`, `Action`, `ColumnChanged` , `UniqueField`, `From`, `To`, `User` , `When`) VALUES('" + Table.tablest + "','Edit Unit','" + colname + "','" + keyvalue + "','" + oldvalue + "','" + textbox.Text + "','" + Table.name + "',NOW());";
                sqlfuncs.AddRemoveChange(sql);   
                //update table
                sql = "UPDATE " + Table.tablest + " SET [" + colname + "] = '" + st + "' WHERE [" + keycolname + "] = '" + keyvalue + "';";
                sqlfuncs.AddRemoveChange(sql);
            }

            catch
            {
                MessageBox.Show("The cell you try to edit is exlusive [no duplicates]. enter different value to the field.");
            }
            Table.tableMaker();
            this.Close();
            
        }
    }
}
