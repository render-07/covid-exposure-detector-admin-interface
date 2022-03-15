using MongoDB.Bson;
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
        private readonly MongoAPI db = new MongoAPI("DP");

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
            if (MessageBox.Show("Are you sure you want to link this person to this device?", "Link", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    //db.DeleteRecordByDeviceName<DeviceModel>("link", cmbDevices.Text);
                    //MessageBox.Show("Device deleted.", "Delete device", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //if (cmbDevices.SelectedIndex >= 0)
                    //{
                    //    cmbDevices.Items.RemoveAt(cmbDevices.SelectedIndex);
                    //}
                    LinkModel obj = new LinkModel
                    {
                        personId = (ObjectId)comboBox1.SelectedValue,
                        deviceId = (ObjectId)comboBox2.SelectedValue
                    };
                    db.InsertRecord<LinkModel>("link", obj);
                    MessageBox.Show("Link made!", "Link", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.TimeoutException)
                {
                    MessageBox.Show("No connection in the server database.", "Design Project",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        private void LinkDeviceToPerson_Load(object sender, EventArgs e)
        {

            var Population = PopulationNames.Select(s => new {
                display = s.firstName + " " + s.middleName + " " + s.lastName,
                value = s._id
            });

            comboBox1.DataSource = Population.ToList();
            comboBox1.DisplayMember = "display";
            comboBox1.ValueMember = "value";
            comboBox2.DataSource = DeviceNames;
            comboBox2.DisplayMember = "deviceName";
            comboBox2.ValueMember = "_id";
        }
    }
}
