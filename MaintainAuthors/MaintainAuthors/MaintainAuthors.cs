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
            closeForm();
        }

        private void btnExitU_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void btnExitD_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            txtContact.Clear();
            txtFName.Focus();
        }

        private void btnClearU_Click(object sender, EventArgs e)
        {
            txtAuthorID.Clear();
            txtFNameU.Clear();
            txtLNameU.Clear();
            txtContactU.Clear();
        }
    }
}
