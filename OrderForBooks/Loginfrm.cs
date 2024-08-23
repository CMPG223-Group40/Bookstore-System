using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OrderForBooks
{
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }
        SqlConnection conString =new SqlConnection("");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get the entered username and password
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            try
            {
                // Open the connection
                conString.Open();

               
                string query = "SELECT Username, Password FROM Users";
                SqlCommand cmd = new SqlCommand(query, conString);

                
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) 
                {
                    // Retrieve username and password
                    string storedUsername = reader["Username"].ToString();
                    string storedPassword = reader["Password"].ToString();

                    // Compare the credentials 
                    if (enteredUsername == storedUsername && enteredPassword == storedPassword)
                    {
                        // Login successful message

                        MessageBox.Show("Login successful!");

                        // Redirect to admin 
                          Adminfrm admin = new Adminfrm();
                         admin.Show();
                         this.Hide();
                    }
                    else
                    {
                        // Login failed
                        lblError.Text = "Incorrect username or password.";
                    }
                }
                else
                {
                    lblError.Text = "Login credentials not found.";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close  connection
                conString.Close();
            }
        }
    }
}
