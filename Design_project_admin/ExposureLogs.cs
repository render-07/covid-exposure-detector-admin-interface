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
    public partial class ExposureLogs : Form
    {
        private readonly MongoAPI db = new MongoAPI("DP");
        private DataTable tableData = new DataTable();

        public DataTable TableData   // property
        {
            get { return tableData; }   // get method
            set { tableData = value; }  // set method
        }

        public ExposureLogs()
        {
            InitializeComponent();
            dataGridView1.DataSource = TableData;
        }

        private void btnExports_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
