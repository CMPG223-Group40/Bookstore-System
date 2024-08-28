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

namespace MaintainAuthors
{
    public partial class MaintainAuthorsFrm : Form
    {
        public MaintainAuthorsFrm()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        /**This method closes forms after the exit button is clicked**/
        public static void closeForm()
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //add form close button
            closeForm();
        }

        private void btnExitU_Click(object sender, EventArgs e)
        {
            //update form close button
            closeForm();
        }

        private void btnExitD_Click(object sender, EventArgs e)
        {
            //delete form close button
            closeForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //add form clear button
            txtFName.Clear();
            txtLName.Clear();
            txtContact.Clear();
            txtFName.Focus();
        }

        private void btnClearU_Click(object sender, EventArgs e)
        {
            //update form clear button
            txtAuthorID.Clear();
            txtFNameU.Clear();
            txtLNameU.Clear();
            txtContactU.Clear();
        }

        private void MaintainAuthorsFrm_Load(object sender, EventArgs e)
        {
            txtFName.Focus();

            //display author table on form
            try
            {
                //connect to database
                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                //sql command to display all in table
                string sql = "SELECT * FROM tblAuthors";
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "AuthorTable");

                dgAddAuthor.DataSource = ds;
                dgAddAuthor.DataMember = "AuthorTable";

                conn.Close(); //close database connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //public declaration of database connection string
        public static string conStr = "Data Source=MALONJE-S-ASUS-;Initial Catalog=BookStore;Integrated Security=True";

        //public declaration of connection, command, data adapter and dataset
        public static SqlConnection conn = new SqlConnection(conStr);
        public static SqlCommand comm;
        public static SqlDataAdapter adap;
        public static DataSet ds;

        /**This method adds an author to the system database**/
        public static void addAuthor(string sql)
        {
            try
            {
                adap = new SqlDataAdapter();
                comm = new SqlCommand(sql,conn);

                //add new record to database
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }




        /**This method checks if there are digits in user input**/
        public static bool checkDigits(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text, i))
                    return true;
            }
            return false;
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            string fName, lName, contact, sqlAdd;

            fName = txtFName.Text;
            lName = txtLName.Text;
            contact = txtContact.Text;

            //check if either first or last names have digits and contact number has letters
            if (!checkDigits(fName))
            {
                if (!checkDigits(lName))
                {
                    if(checkDigits(contact))
                    {                        
                        if(contact.Length == 10)
                        {
                            try
                            {
                                //connect to database
                                conn.Open();

                                //sql insert command to add new author record
                                sqlAdd = $"INSERT INTO tblAuthors(FName,LName,ContactNo) " +
                                    $"VALUES('{fName}','{lName}','{contact}')";

                                //call add author method
                                addAuthor(sqlAdd);

                                //display author table on form
                                adap = new SqlDataAdapter();
                                ds = new DataSet();

                                //sql command to display all in table
                                string sql = "SELECT * FROM tblAuthors";
                                comm = new SqlCommand(sql, conn);
                                adap.SelectCommand = comm;
                                adap.Fill(ds, "AuthorTable");

                                dgAddAuthor.DataSource = ds;
                                dgAddAuthor.DataMember = "AuthorTable";

                                conn.Close(); //close database connection

                                MessageBox.Show("New author added successfully", "Add Author Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (SqlException error)
                            {
                                MessageBox.Show(error.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Invalid contact number. Contact number should contain 10 digits",
                            "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Invalid contact number. Contact number cannot contain letters",
                            "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: Invalid last name. Last name cannot contain numbers", 
                        "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Invalid first name. First name cannot contain numbers", 
                    "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            //display author table on form
            try
            {
                //connect to database
                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                //sql command to display all in table
                string sql = "SELECT * FROM tblAuthors";
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "AuthorTable");

                dgUpdateAuthor.DataSource = ds;
                dgUpdateAuthor.DataMember = "AuthorTable";

                //load author combobox
                adap.Fill(ds, "tblAuthors");
                cbUpdateAuthor.DisplayMember = "LName";
                cbUpdateAuthor.ValueMember = "LName";
                cbUpdateAuthor.DataSource = ds.Tables["tblAuthors"];

                conn.Close(); //close database connection

                lblUpdate.Visible = false;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            //display author table on form
            try
            {
                //connect to database
                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                //sql command to display all in table
                string sql = "SELECT * FROM tblAuthors";
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "AuthorTable");

                dgDeleteAuthor.DataSource = ds;
                dgDeleteAuthor.DataMember = "AuthorTable";

                //load author combobox
                adap.Fill(ds, "tblAuthors");
                cbDeleteAuthor.DisplayMember = "LName";
                cbDeleteAuthor.ValueMember = "LName";
                cbDeleteAuthor.DataSource = ds.Tables["tblAuthors"];

                conn.Close(); //close database connection

                lblDelete.Visible = false;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cbUpdateAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbUpdateAuthor.SelectedItem != null)
                {
                    string selectedLName = cbUpdateAuthor.SelectedValue.ToString();

                    // Find the row in DataGridView based on ComboBox selection
                    foreach (DataGridViewRow row in dgUpdateAuthor.Rows)
                    {
                        if (row.Cells["LName"].Value.ToString() == selectedLName)
                        {
                            // Select the row in DataGridView
                            row.Selected = true;
                            // Set focus to the first cell of the selected row
                            dgUpdateAuthor.CurrentCell = row.Cells[0];

                            // Populate text boxes with data from the selected row
                            txtAuthorID.Text = row.Cells["AuthorID"].Value.ToString();
                            txtFNameU.Text = row.Cells["FName"].Value.ToString();
                            txtLNameU.Text = row.Cells["LName"].Value.ToString();
                            txtContactU.Text = row.Cells["ContactNo"].Value.ToString();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error: Please select author to update from list",
                        "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }            
        }

        private void cbDeleteAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbDeleteAuthor.SelectedItem != null)
                {
                    string selectedLName = cbDeleteAuthor.SelectedValue.ToString();

                    // Find the row in DataGridView based on ComboBox selection
                    foreach (DataGridViewRow row in dgDeleteAuthor.Rows)
                    {
                        if (row.Cells["LName"].Value.ToString() == selectedLName)
                        {
                            // Select the row in DataGridView
                            row.Selected = true;
                            // Set focus to the first cell of the selected row
                            dgDeleteAuthor.CurrentCell = row.Cells[0];

                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error: Please select author to delete from list",
                        "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
