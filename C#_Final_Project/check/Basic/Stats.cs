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
    public partial class Stats : Form
    {
        SQLFuncs sqlfuncs = new SQLFuncs();
        string statsst;
        int income = 0;
        int outcome = 0;
        public Stats()
        {
            InitializeComponent();
            StatsTimeComboBox.SelectedIndex = 2;
            setCharts();
            GUI();
        }

        void GUI() //SETUP GUI DESIGN
        {
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
        }


        void setCharts() // First SETUP FOR CHARTS
        {
            statsst = StatsTimeComboBox.SelectedItem.ToString();
            label3.Text = statsst +" Stats";
            setProductsStats();
            setOutcomeChart();
        }

        void setProductsStats() //SET PRODUCTS CHART
        {
            Dictionary<string , int> productsdict= new Dictionary<string, int>();
            Dictionary<string, int> productsincomedict = new Dictionary<string, int>();
            Dictionary<string, int> workervolumedict = new Dictionary<string, int>();
            DataTable dt = new DataTable();

            //choosing the currect query
            if(statsst == "Monthly")
            {
                dt = sqlfuncs.GetTable("Select * From Sells Where Month(SellDate) = Month(Date());");
            }

            else if(statsst  == "Annualy")
            {
                dt = sqlfuncs.GetTable("Select * From Sells Where Year(SellDate) = Year(Date());");
            }

            else if(statsst == "Overall")
            {
                dt = sqlfuncs.GetTable("SELECT * FROM Sells"); //WORKS
            }

            //taking the values needed for each chart
            foreach (DataRow row in dt.Rows)
            {
                string productname = row["ProductName"].ToString();
                string workername = row["WorkerName"].ToString();

                //popular item 
                if (productsdict.ContainsKey(productname))
                {
                    productsdict[productname] += int.Parse(row["Amount"].ToString());
                }
                else
                {
                    productsdict.Add(productname, int.Parse(row["Amount"].ToString()));
                }

                //bestincome product
                if (productsincomedict.ContainsKey(productname))
                {
                    productsincomedict[productname] += int.Parse(row["Amount"].ToString()) * int.Parse(row["Price"].ToString());
                    income += int.Parse(row["Amount"].ToString()) * int.Parse(row["Price"].ToString());
                }

                else
                {
                    productsincomedict.Add(productname, int.Parse(row["Amount"].ToString()) * int.Parse(row["Price"].ToString()));
                    income += int.Parse(row["Amount"].ToString()) * int.Parse(row["Price"].ToString());
                }


                //most volume worker
                if (workervolumedict.ContainsKey(workername))
                {
                    workervolumedict[workername] += int.Parse(row["Amount"].ToString()) * int.Parse(row["Price"].ToString());
                }

                else
                {
                    workervolumedict.Add(workername, int.Parse(row["Amount"].ToString()) * int.Parse(row["Price"].ToString()));
                }
            }

            // product  popularity
            foreach(KeyValuePair<string, int> dict in productsdict)
            {
                this.ProductsChart.Series["Popularity"].Points.AddXY(dict.Key,dict.Value);
            }

            //product income
            foreach (KeyValuePair<string, int> dict in productsincomedict)
            {
                this.ProductsChart.Series["Income"].Points.AddXY(dict.Key, dict.Value);
            }
            
            //worker volume
            foreach (KeyValuePair<string, int> dict in workervolumedict)
            {
                this.WorkersCharts.Series["Sells Volume"].Points.AddXY(dict.Key, dict.Value);
            }
        }

        void setOutcomeChart() //SET INCOME/OUTCOME CHART
        {
            DataTable dt = new DataTable();

            //choosing the right dates
            if (statsst == "Monthly")
            {
                dt = sqlfuncs.GetTable("Select * From Buys Where Month(BuyDate) = Month(Date());");
            }

            else if (statsst == "Annualy")
            {
                dt = sqlfuncs.GetTable("Select * From Buys Where Year(BuyDate) = Year(Date());");
            }

            else
            {
                dt = sqlfuncs.GetTable("SELECT * FROM Buys"); //WORKS
            }

            foreach (DataRow row in dt.Rows)
            {
                outcome += int.Parse(row["Amount"].ToString()) * int.Parse(row["Price"].ToString());

            }

            this.BusinessChart.Series["Income"].Points.AddXY("Income", income);
            this.BusinessChart.Series["Outcome"].Points.AddXY("Outcome", outcome);
        }

        private void StatsTimeComboBox_SelectionChangeCommitted(object sender, EventArgs e) //WHEN U CHANGE THE TIMELINE RESET CHARTS
        {
            resetCharts();
            setCharts();
        }

        void resetCharts() //RESET CHARTS AFTER CAHNGING TIMELINE
        {
            income = 0;
            outcome = 0;
            foreach (var series in BusinessChart.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in WorkersCharts.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in ProductsChart.Series)
            {
                series.Points.Clear();
            }
        }
    }
}
