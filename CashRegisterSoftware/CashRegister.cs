using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CashRegisterSoftware
{
    public partial class CashRegister : Form
    {
        static string myConnectionString = ConfigurationManager.ConnectionStrings["assignmentdbConnectionString"].ConnectionString;

        public CashRegister()
        {
            InitializeComponent();
        }

        private void reportToolStripLabelCRS_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVariables.nextReport.Show();
        }

        private void maintainanceToolStripLabelCRS_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVariables.nextMaintainance.Show();
        }

        private void CashRegister_Load(object sender, EventArgs e)
        {
            UpdateCR();
        }

        private void checkoutButtonCR_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                if (productNameComboBoxCR.SelectedIndex == -1 || finalPriceTextBoxCR.Text == string.Empty || numberSoldTextBoxCR.Text == string.Empty || totalTextBoxCR.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the empty fields!");
                    return;
                }
                else
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();

                    string query = "INSERT INTO transactions (productid, finalprice, numbersold, total, dateandtime) SELECT productid, " + finalPriceTextBoxCR.Text.Replace(',', '.') + ", " + numberSoldTextBoxCR.Text + ", " + totalAnswer(finalPriceTextBoxCR.Text, numberSoldTextBoxCR.Text).ToString().Replace(',', '.') + ", NOW() FROM products WHERE productname = '" + productNameComboBoxCR.SelectedItem.ToString() + "';";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    productNameComboBoxCR.SelectedIndex = -1;
                    finalPriceTextBoxCR.Clear();
                    numberSoldTextBoxCR.Clear();
                    totalTextBoxCR.Clear();

                    conn.Close();
                    MessageBox.Show("Sold!");
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButtonCR_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            productNameComboBoxCR.SelectedIndex = -1;
            finalPriceTextBoxCR.Clear();
            numberSoldTextBoxCR.Clear();
            totalTextBoxCR.Clear();
            
            conn.Close();
            MessageBox.Show("Cancelled!");
        }

        private void finalPriceTextBoxCR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalChar = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            char ch = e.KeyChar;

            if (ch == decimalChar && finalPriceTextBoxCR.Text.IndexOf(decimalChar) != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != decimalChar && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void numberSoldTextBoxCR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void finalPriceTextBoxCR_TextChanged(object sender, EventArgs e)
        {
            if ((productNameComboBoxCR.SelectedIndex != -1 && finalPriceTextBoxCR.Text != string.Empty && numberSoldTextBoxCR.Text != string.Empty))
            {
                totalTextBoxCR.Text = totalAnswer(finalPriceTextBoxCR.Text, numberSoldTextBoxCR.Text).ToString();
            }
        }

        private void numberSoldTextBoxCR_TextChanged(object sender, EventArgs e)
        {
            if ((productNameComboBoxCR.SelectedIndex != -1 && finalPriceTextBoxCR.Text != string.Empty && numberSoldTextBoxCR.Text != string.Empty))
            {
                totalTextBoxCR.Text = totalAnswer(finalPriceTextBoxCR.Text, numberSoldTextBoxCR.Text).ToString();
            }
        }

        public void UpdateCR ()
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string query = "SELECT productname from products WHERE availability NOT LIKE 'Discontinued';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    productNameComboBoxCR.Items.Clear();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            productNameComboBoxCR.Items.Add(reader[i].ToString());
                        }
                    }
                }
                reader.Close();

                if (true)
                {
                    string query1 = "SELECT productid AS ProductID , productname AS ProductName, productprice AS ProductPrice, stock AS QuantityLeft, availability AS Availability FROM products;";
                    MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd1;

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = table;

                    dataGridViewCR.DataSource = bSource;
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public decimal totalAnswer(string finalPrice, string numberSold)
        {
            decimal totalDecimal = decimal.Parse(finalPriceTextBoxCR.Text) * decimal.Parse(numberSoldTextBoxCR.Text);
            return totalDecimal;
        }
    }
}
