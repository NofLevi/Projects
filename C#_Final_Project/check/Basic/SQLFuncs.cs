using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check
{
    class SQLFuncs
    {
        OleDbConnection con;
        OleDbCommand cmd;
        string connString;

        public SQLFuncs()
        {
            connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new OleDbConnection(connString);
        }



        public Boolean AddRemoveChange(string sql) // get a string and have the power to Add remove and edit the sql
        {
            try
            {
                cmd = new OleDbCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }

            catch
            {
                return false;
            }
        }

        public DataTable GetTable(string sql) //GET INFORMATION OF A TABLE
        {
            using (OleDbCommand cmd = new OleDbCommand(sql, con))
            {
                DataTable dt = new DataTable();
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                con.Close();
                return dt;

            }
        }

        public DataTable GetTablesName() // GET ALL TABLE NAMES
        {
            DataTable dt;
            con.Open();
            dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            con.Close();
            return dt;
        }

        public Boolean FirstEntry() //CHECK IF ITS THE FIRST TIME U WENT INTO THE SOFTWARE
        {
            DataTable dt = new DataTable();
            using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Settings", con))
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                con.Close();
            }
            if (dt.Rows[0][0].ToString() == "0")
            {
                Console.WriteLine(dt.Rows[0][0].ToString());
                return true;
            }
            return false;

        }
    }
}
