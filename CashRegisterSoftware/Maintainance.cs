using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Maintainance : Form
    {
        static string myConnectionString = "server=localhost;user id = root;pwd=1234567;database=assignmentdb;sslmode=Disabled";

        public Maintainance()
        {
            InitializeComponent();
        }

        private void cashRegisterToolStripLabelMS_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVariables.nextCashRegister.UpdateCR();
            GlobalVariables.nextCashRegister.Show();

        }

        private void reportToolStripLabelMS_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVariables.nextReport.Show();
        }

        private void saveButtonAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                if (productNameTextBoxAdd.Text == string.Empty || productPriceTextBoxAdd.Text == string.Empty || stockTextBoxAdd.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the empty fields!");
                    return;
                }
                else
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();

                    string query = "INSERT INTO products(productname, productprice, stock, availability) VALUES ('" + productNameTextBoxAdd.Text + "', " + productPriceTextBoxAdd.Text.Replace(',', '.') + ", " + stockTextBoxAdd.Text + ", '" + availabilityComboBoxAdd.SelectedItem.ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    productNameTextBoxAdd.Clear();
                    productPriceTextBoxAdd.Clear();
                    stockTextBoxAdd.Clear();
                    availabilityComboBoxAdd.SelectedIndex = -1;

                    conn.Close();
                    MessageBox.Show("Successfully Added!");
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void saveButtonEdit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                if (productNameTextBoxEdit.Text == string.Empty || productPriceTextBoxEdit.Text == string.Empty || stockTextBoxEdit.Text == string.Empty)
                {
                    MessageBox.Show("Fill in the empty fields!");
                    return;
                }
                else
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();

                    string query = "UPDATE products SET productname = '" + productNameTextBoxEdit.Text + "', productprice = " + productPriceTextBoxEdit.Text.Replace(',', '.') + ", stock = " + stockTextBoxEdit.Text + ", availability = '" + availabilityComboBoxEdit.SelectedItem.ToString() + "' WHERE productid =" + productIDSearchTextBox.Text + ";";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    productNameTextBoxEdit.Clear();
                    productPriceTextBoxEdit.Clear();
                    stockTextBoxEdit.Clear();
                    availabilityComboBoxEdit.SelectedIndex = -1;
                    productIDSearchTextBox.Clear();
                    searchTextBox.Clear();

                    conn.Close();
                    MessageBox.Show("Successfully Edited!");
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButtonAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            productNameTextBoxAdd.Clear();
            productPriceTextBoxAdd.Clear();
            stockTextBoxAdd.Clear();
            availabilityComboBoxAdd.SelectedIndex = -1;
          
            conn.Close();
            MessageBox.Show("Cancelled!");
        }

        private void cancelButtonEdit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            productNameTextBoxEdit.Clear();
            productPriceTextBoxEdit.Clear();
            stockTextBoxEdit.Clear();
            availabilityComboBoxEdit.SelectedIndex = -1;
            productIDSearchTextBox.Clear();
            searchTextBox.Clear();

            conn.Close();
            MessageBox.Show("Cancelled!");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                if (searchTextBox.Text == string.Empty || productIDSearchTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Enter the name and ID of the product to be edited!");
                    return;
                }
                else
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();

                    string query = "SELECT productname, productprice, stock, availability FROM products WHERE productname = '" + searchTextBox.Text + "' AND productid = " + productIDSearchTextBox.Text + ";";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            productNameTextBoxEdit.Text = reader["productname"].ToString();
                            productPriceTextBoxEdit.Text = reader["productprice"].ToString();
                            stockTextBoxEdit.Text = reader["stock"].ToString();
                            availabilityComboBoxEdit.SelectedItem = reader["availability"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product could not be found!");
                        return;
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productIDSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void productPriceTextBoxAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalChar = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            char ch = e.KeyChar;

            if (ch == decimalChar && productPriceTextBoxAdd.Text.IndexOf(decimalChar) != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != decimalChar && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void productPriceTextBoxEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalChar = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            char ch = e.KeyChar;

            if (ch == decimalChar && productPriceTextBoxEdit.Text.IndexOf(decimalChar) != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != decimalChar && ch != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void stockTextBoxAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void stockTextBoxEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
