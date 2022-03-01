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
    public partial class LinkDeviceToPerson : Form
    {
        public List<DeviceModel> DeviceNames { get; set; } = new List<DeviceModel>();

        public List<PersonModel> PopulationNames { get; set; } = new List<PersonModel>();


        public LinkDeviceToPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {

        }

        private void LinkDeviceToPerson_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = DeviceNames;
            comboBox1.DisplayMember = "deviceName";
            comboBox1.ValueMember = "uid";

            var Population = PopulationNames.Select(s => new {
                display = s.firstName + " " + s.middleName + " " + s.lastName,
                value = s._id
            });

            comboBox2.DataSource = Population.ToList();
            comboBox2.DisplayMember = "display";
            comboBox2.ValueMember = "value";
        }
    }
}
