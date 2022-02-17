using System;
using System.Data;
using System.Windows.Forms;
using MongoDBLibrary;

namespace Design_project_admin
{
    public partial class ManageDevice : Form
    {
        private readonly MongoAPI db = new MongoAPI("DP");
        private DataTable tableData = new DataTable();

        public DataTable TableData   // property
        {
            get { return tableData; }   // get method
            set { tableData = value; }  // set method
        }

        public ManageDevice()
        {
            InitializeComponent();
            // LoadDatabase("");
            dataGridView1.DataSource = TableData;
        }

        private void ManageDevice_Load(object sender, System.EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddDevice obj = new AddDevice();
            obj.ShowDialog();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            DeleteDevice obj = new DeleteDevice();
            obj.ShowDialog();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
