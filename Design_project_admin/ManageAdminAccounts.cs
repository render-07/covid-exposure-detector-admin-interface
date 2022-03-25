using MongoDBLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_project_admin
{
    public partial class ManageAdminAccounts : Form
    {
        private readonly MongoAPI db = new MongoAPI("DP");
        private DataTable tableData = new DataTable();

        public DataTable TableData   // property
        {
            get { return tableData; }   // get method
            set { tableData = value; }  // set method
        }

        public ManageAdminAccounts()
        {
            InitializeComponent();
            dataGridView1.DataSource = TableData;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAdminAccount obj = new AddAdminAccount();
            obj.ShowDialog();
        }
    }
}
