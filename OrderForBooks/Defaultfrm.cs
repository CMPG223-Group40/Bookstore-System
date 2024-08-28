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
    public partial class Defaultfrm : Form
    {
        public Defaultfrm()
        {
            InitializeComponent();

        }
        

        private void Defaultfrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome! Please fill in your details to register as a new customer ,if you already have a customer ID make use of existing customer button to continue ")
            CustomersForm customersForm = new CustomersForm();
            customersForm.SetInitialTab(false); //new customer
            customersForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome! please make sure you already have a customer ID to continue ,if not click the NEW button to register ")
            frmPlaceOrderForm ordersForm = new frmPlaceOrderForm();
            ordersForm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Adminfrm adminform = new Adminfrm();
            adminform.Show();
        }
    }
}
