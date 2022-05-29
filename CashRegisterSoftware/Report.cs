using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CashRegisterSoftware
{
    public partial class Report : Form
    {
        static string myConnectionString = ConfigurationManager.ConnectionStrings["assignmentdbConnectionString"].ConnectionString;
        public Report()
        {
            InitializeComponent();
        }

        private void cashRegisterToolStripLabelRS_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVariables.nextCashRegister.UpdateCR();
            GlobalVariables.nextCashRegister.Show();
        }

        private void maintainanceToolStripLabelRS_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVariables.nextMaintainance.Show();
        }

        private void selectReportbutton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                if (reportTypeComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Choose the report to generate!");
                    return;
                }
                
                else if (reportTypeComboBox.SelectedIndex == 0)
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();

                    string query = "SELECT transactionid AS TransactionID, productid AS ProductID , productname AS ProductName, finalprice AS FinalPrice, numbersold AS NumberSold, total AS Total, dateandtime AS DateAndTime FROM transactions INNER JOIN products USING (productid) WHERE dateandtime BETWEEN '" + fromDateTimePicker.Value.Date.ToString("u").Replace('Z', ' ') + "' AND '" + toDateTimePicker.Value.Date.Add(new TimeSpan(23, 59, 59)).ToString("u").Replace('Z', ' ') + "' ORDER BY transactionid;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    reportDataGridView.DataSource = table;

                    conn.Close();
                }
                else if (reportTypeComboBox.SelectedIndex == 1)
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();

                    string query = "SELECT productid AS ProductID , productname AS ProductName, finalprice AS FinalPrice, SUM(numbersold) NumberSold, SUM(finalprice*NumberSold) GrandTotal FROM transactions INNER JOIN products USING (productid) WHERE dateandtime BETWEEN '" + fromDateTimePicker.Value.Date.ToString("u").Replace('Z', ' ') + "' AND '" + toDateTimePicker.Value.Date.Add(new TimeSpan(23, 59, 59)).ToString("u").Replace('Z', ' ') + "' GROUP BY productid ORDER BY NumberSold DESC LIMIT 10;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    reportDataGridView.DataSource = table;

                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toDateTimePicker_Enter(object sender, EventArgs e)
        {
            DateTime dateTimeStart = new DateTime();
            dateTimeStart = fromDateTimePicker.Value;
            DateTime dateTimeEnd = new DateTime();
            dateTimeEnd = toDateTimePicker.Value;

            if (dateTimeEnd >= dateTimeStart)
            {
                toDateTimePicker.MinDate = dateTimeStart;
            }
        
            if (dateTimeEnd < dateTimeStart)
            {
                toDateTimePicker.MinDate = dateTimeStart;
            }
        }

        private void fromDateTimePicker_Enter(object sender, EventArgs e)
        {
            DateTime dateTimeStart = new DateTime();
            dateTimeStart = fromDateTimePicker.Value;
            DateTime dateTimeEnd = new DateTime();
            dateTimeEnd = toDateTimePicker.Value;

            if (dateTimeEnd < dateTimeStart)
            {
                toDateTimePicker.MinDate = dateTimeStart;
            }
            if (dateTimeStart > DateTime.Now)
            {
                fromDateTimePicker.MaxDate = DateTime.Now;
            }
        }

        private void report_Load(object sender, EventArgs e)
        {
            fromDateTimePicker.MaxDate = DateTime.Now;
            toDateTimePicker.MinDate = DateTime.Now;
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fromDateTimePicker.MaxDate = DateTime.Now;
            toDateTimePicker.MinDate = fromDateTimePicker.Value;
        }
    }
}
