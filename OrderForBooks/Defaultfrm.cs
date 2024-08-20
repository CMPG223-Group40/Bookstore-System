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
        public void SetInitialTab()
        {
            // Ensure the TabControl is not null and has at least one tab
            if (tabControl1 != null && tabControl1.TabPages.Count > 0)
            {
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }

            private void Defaultfrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            customersForm.SetInitialTab();
            customersForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
