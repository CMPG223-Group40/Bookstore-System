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
    public partial class MaintainAuthorsForm : Form
    {
        public MaintainAuthorsForm()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=MALONJE-S-ASUS-;Initial Catalog=BookStore;Integrated Security=True";

        private void MaintainAuthorsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
