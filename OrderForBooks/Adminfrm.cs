using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForBooks
{
    public partial class Adminfrm : Form
    {
        public Adminfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MaintainCustomersFrm newCustomerfrm = new MaintainCustomersFrm();
                newCustomerfrm.SetInitialTab(true); // Admin user
                newCustomerfrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MaintainBookssFrm booksfrm = new maintainBooksFrm();
                booksfrm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MaintainAuthorsFrm Authorsfrm = new maintainCustomersFrm();
                adminform.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ReportsFrm reportsfrm = new ReportsFrm();
                reportsfrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Defaultfrm prevForm = new Defaultfrm(); 
            prevForm.Show();
        }
    }
}
