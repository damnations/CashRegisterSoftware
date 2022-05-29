using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Login : Form
    {
        static string myConnectionString = "server=localhost;user id = root;pwd=1234567;database=assignmentdb;sslmode=Disabled";
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
             
            try
            {
                if (usernameTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty)
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();

                    string query = "SELECT * FROM login WHERE username = '" + usernameTextBox.Text + "' AND PASSWORD = PASSWORD('" + passwordTextBox.Text + "');";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            usernameLabel.Text = reader["username"].ToString();
                            passwordLabel.Text = reader["password"].ToString(); 
                        }

                        this.Hide();
                        GlobalVariables.nextCashRegister.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is wrong!");
                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void loginButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 10)
            {

                MySqlConnection conn = new MySqlConnection();

                try
                {
                    if (usernameTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty)
                    {
                        conn.ConnectionString = myConnectionString;
                        conn.Open();

                        string query = "SELECT * FROM login WHERE username = '" + usernameTextBox.Text + "' AND PASSWORD = PASSWORD('" + passwordTextBox.Text + "');";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                usernameLabel.Text = reader["username"].ToString();
                                passwordLabel.Text = reader["password"].ToString();
                            }

                            this.Hide();
                            GlobalVariables.nextCashRegister.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password is wrong!");
                        }
                        conn.Close();
                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void loginButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                MySqlConnection conn = new MySqlConnection();

                try
                {
                    if (usernameTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty)
                    {
                        conn.ConnectionString = myConnectionString;
                        conn.Open();

                        string query = "SELECT * FROM login WHERE username = '" + usernameTextBox.Text + "' AND PASSWORD = PASSWORD('" + passwordTextBox.Text + "');";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                usernameLabel.Text = reader["username"].ToString();
                                passwordLabel.Text = reader["password"].ToString();
                            }

                            this.Hide();
                            GlobalVariables.nextCashRegister.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password is wrong!");
                        }
                        conn.Close();
                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
