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
    public partial class frmPlaceOrderForm : Form
    {
        public frmPlaceOrderForm()
        {
            InitializeComponent();
        }
        SqlConnection conString = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            btnPlaceOrder.Enabled = false; // Disable Place Order button initially

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            int customerId;
            if (int.TryParse(txtCustomerID.Text, out customerId))
            {
                string query = "SELECT * FROM tblCustomers WHERE CustomerID = @CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, conString))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    try
                    {
                        conString.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                MessageBox.Show("Customer Verified!");
                                btnPlaceOrder.Enabled = true;//enable the place order button

                                string address = reader["Address"].ToString();
                                lstAddress.Text = address;

                                LoadBooksToDataGridView();
                            }
                            else
                            {
                                MessageBox.Show("The entered Customer ID does not exist. Please enter a valid Customer ID.");
                                btnPlaceOrder.Enabled = false;
                                lstAddress.Text = string.Empty;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                    finally
                    {
                        conString.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Customer ID.", "Invalid Input");
            }


        }
        private void LoadBooksToDataGridView()
        {
            string query = "SELECT BookID, ISBN, Title,YearPublished, SellingPrice FROM Books";

            using (SqlCommand cmd = new SqlCommand(query, conString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable booksTable = new DataTable();
                    adapter.Fill(booksTable);  // Fill the DataTable with data

                    dtgvBooksAvailable.DataSource = booksTable; // Bind the DataTable to the DataGridView
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filterBy = cmbFilterBy.SelectedItem.ToString();
            string filterValue = txtFilterValue.Text;

            string query = "SELECT BookID, ISBN, Title,  YearPublished, SellingPrice FROM Book";

            // Apply the filter based on the selected criteria
            if (!string.IsNullOrEmpty(filterValue))
            {
                switch (filterBy)
                {
                    case "Author":
                        query = @"SELECT Books.BookID, Books.ISBN, Books.Title, Books.YearPublished, Books.SellingPrice 
                          FROM Book 
                          INNER JOIN BookOnAuthor ON Books.BookID = BookOnAuthor.BookID
                          INNER JOIN Author ON BookOnAuthor.AuthorID = Authors.AuthorID
                          WHERE Authors.FName LIKE @FilterValue OR Authors.LName LIKE @FilterValue";
                        break;

                    case "Year Published":
                        query += " WHERE YearPublished = @FilterValue";
                        break;

                    case "Title":
                        query += " WHERE Title LIKE @FilterValue";
                        break;
                }
            }
            using (SqlCommand cmd = new SqlCommand(query, conString))
            {
                if (filterBy == "Author")
                {
                    cmd.Parameters.AddWithValue("@FilterValue", "%" + filterValue + "%");
                }
                else if (filterBy == "Year Published")
                {
                    if (int.TryParse(filterValue, out int yearPublished))
                    {
                        cmd.Parameters.AddWithValue("@FilterValue", yearPublished);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (filterBy == "Title")
                {
                    cmd.Parameters.AddWithValue("@FilterValue", "%" + filterValue + "%");
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable booksTable = new DataTable();
                    adapter.Fill(booksTable);  // Fill the DataTable with data

                    dtgvBooksAvailable.DataSource = booksTable; // Bind the DataTable to the DataGridView
                }
            }

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string referenceId = "ORD" + DateTime.Now.ToString("yyyyMMddHHmmss");

            // current date for the order
            DateTime orderDate = DateTime.Now;
            int customerId = int.Parse(txtCustomerID.Text);

            // total order amount
            decimal totalOrderAmount = decimal.Parse(txtTotalPrice.Text); 
            // Insert the order into tblCustomerOrder
            string insertOrderQuery = "INSERT INTO tblCustomerOrder (CustomerID, OrderDate, TotalOrder) VALUES (@CustomerID, @OrderDate, @TotalOrder)";
            using (SqlCommand cmd = new SqlCommand(insertOrderQuery, conString))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                cmd.Parameters.AddWithValue("@TotalOrder", totalOrderAmount);

                try
                {
                    conString.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    conString.Close();
                }
            }

            //order summary
            string summary = $"Reference ID: {referenceId}\n" +
                             $"Customer ID: {customerId}\n" +
                             $"Order Date: {orderDate}\n" +
                             $"Books Ordered:\n";

            foreach (DataGridViewRow row in dtgvBooksAvailable.SelectedRows) // Only selected books
            {
                string bookTitle = row.Cells["Title"].Value.ToString();
                int quantity = int.Parse(txtQuantity.Text); 
                decimal price = decimal.Parse(row.Cells["SellingPrice"].Value.ToString());
                decimal total = quantity * price;

                summary += $"{bookTitle} (x{quantity}) - {total:C}\n";
            }

            summary += $"Total Order Amount: {totalOrderAmount:C}";

            // Display the summary in the lstSummary
            lstSummary.Items.Clear();
            lstSummary.Items.Add("THANK YOU FOR YOUR ORDER \n\n");
            lstSummary.Items.Add(summary);

            //clear the form for the next order
            ClearOrderForm();
        }
        

        private void dtgvBooksAvailable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvBooksAvailable.SelectedRows.Count > 0 && dtgvBooksAvailable.SelectedRows[0].Cells["SellingPrice"].Value != null)
            {
                // Get the selected book's price
                decimal sellingPrice = decimal.Parse(dtgvBooksAvailable.SelectedRows[0].Cells["SellingPrice"].Value.ToString());

                txtTotalPrice.Text = sellingPrice.ToString("C");// formatted as currency
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (dtgvBooksAvailable.SelectedRows.Count > 0 && !string.IsNullOrEmpty(txtQuantity.Text))
            {
                int quantity;
                if (int.TryParse(txtQuantity.Text, out quantity))
                {
                    // Get book's price
                    decimal sellingPrice = decimal.Parse(dtgvBooksAvailable.SelectedRows[0].Cells["SellingPrice"].Value.ToString());

                    // Calculate the total price
                    decimal totalPrice = sellingPrice * quantity;

                    txtTotalPrice.Text = totalPrice.ToString("C"); 
                }
            }
        }
        private void ClearOrderForm()
        {
            txtCustomerID.Clear();
            txtQuantity.Clear();
            txtTotalPrice.Clear();
            dtgvBooksAvailable.DataSource = null;
            lstAddress.Items.Clear();
            lstSummary.Items.Clear();
            btnPlaceOrder.Enabled = false;
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
        

