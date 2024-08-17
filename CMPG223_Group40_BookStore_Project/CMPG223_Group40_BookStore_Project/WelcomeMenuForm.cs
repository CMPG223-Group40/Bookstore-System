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

namespace CMPG223_Group40_BookStore_Project
{
    public partial class WelcomeMenuForm : Form
    {
        public WelcomeMenuForm()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=MALONJE-S-ASUS-;Initial Catalog=BookStore;Integrated Security=True";

        private void WelcomeMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
