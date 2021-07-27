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
    public partial class AddColumn : Form
    {
        string table;
        Form1 Table;
        SQLFuncs sqlfuncs = new SQLFuncs();
        public AddColumn(string table, DataGridView dgv, Form1 Table)
        {
            InitializeComponent();
            this.Table = Table;
            this.table = table;
            GUI();
        }

        void GUI() //SETUP GUI
        {
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            ConfirmButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
        }

        private void ConfirmButton_MouseClick(object sender, MouseEventArgs e) //ADDING COLUMN TO THE TABLE
        {
            try
            {
                sqlfuncs.AddRemoveChange("ALTER TABLE " + table + " ADD COLUMN " + ColumnTextBox.Text + " CHAR(50)");
                //add to LOG
                string sql = "INSERT INTO `LOGColumns`(`TableName`, `Column`, `Action` , `User`, `When`) VALUES('" + table + "', 'NEW','Add Column','" + Table.name+ "',NOW());";
                sqlfuncs.AddRemoveChange(sql);
                MessageBox.Show(ColumnTextBox.Text + " Have been added to the table");
                Table.tableMaker();
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("This Column Name Exist in the system. try again with a different 1.");
            }
        }
    }
}
