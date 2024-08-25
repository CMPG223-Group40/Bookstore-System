using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        /**This method adds an author to the system database**/
        public static void addAuthor()
        {
                        
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
            string fName, lName, contact;

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

                    }
                    else
                    {
                        MessageBox.Show("Error: Invalid contact number", "Input error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: Invalid last name", "Input error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Invalid first name", "Input error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
