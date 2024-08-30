using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaintainCustomers2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommand command;
        string connectionstring = @"Data Source=MALONJE-S-ASUS-;Initial Catalog=BookStore;Integrated Security=True";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionstring))
            {
                string query = "INSERT INTO tblCustomers (Customer_ID,FirstName ,LastName,Coctact_No,Email, Address)"
                    + "VALUES (@Customer_ID,@FName,@LName, @Contact_No,@Email, @Address)";

                command.Parameters.AddWithValue("@Customer_ID", txtCustomerID.Text);
                command.Parameters.AddWithValue("@FName", txtName.Text);
                command.Parameters.AddWithValue("@LName", txtLastName.Text);
                command.Parameters.AddWithValue("@Contact_No", txtContactNo.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Address", txtAddress.Text);

                cnn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Record has been inserted successfully");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtLastName.Clear();
            txtName.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            using (SqlConnection cnn = new SqlConnection(connectionstring))
            {
                string query = "UPDATE tblCustomers SET FName=@FName,LName=@LName,Contact_No= @Contact_No " +
                    "Email=@Email, Address=@Address" + "WHERE Customer_ID=@Customer_ID";

                command.Parameters.AddWithValue("@Customer_ID", txtCustomerID.Text);
                command.Parameters.AddWithValue("@FName", txtName.Text);
                command.Parameters.AddWithValue("@LName", txtLastName.Text);
                command.Parameters.AddWithValue("@Contact_No", txtContactNo.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Address", txtAddress.Text);

                cnn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Record has been updated successfully");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtLastName.Clear();
            txtName.Clear();
            txtCustomerID.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cnn.Open();
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Record has been deleted");
            cnn.Open();
            command = new SqlCommand("SELECT * FROM tblCustomers", cnn);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       /* private void btnDisplay_Click(object sender, EventArgs e)
        {
            string sql;
            sql = @"SELECT * FROM tblCustomers";
            command = new SqlCommand(sql, cnn);
            adapter = new SqlDataAdapter(sql, cnn);
            ds = new DataSet();
            adapter.Fill(ds, "tblCustomers");
            dgvDatabaseData.DataSource = ds.Tables["tblCustomers"];
            cnn.Close();
        }*/
    
    }
}
