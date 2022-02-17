using System;
using System.Windows.Forms;
using MongoDBLibrary;

namespace Design_project_admin
{
    public partial class DeleteDevice : Form
    {
        private readonly MongoAPI db = new MongoAPI("DP");

        public DeleteDevice()
        {
            InitializeComponent();
        }

        private void DeleteDevice_Load(object sender, EventArgs e)
        {
            try
            {
                var allDevices = db.LoadAllRecords<DeviceModel>("devices");
                foreach (var recs in allDevices)
                {
                    cmbDevices.Items.Add(recs.deviceName);
                }
            }
            //catch (MongoDB.Driver.MongoConnectionException)
            //{
            //    MessageBox.Show("No connection in the server database.", "Design Project",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Close();
            //}
            catch (System.TimeoutException)
            {
                MessageBox.Show("No connection in the server database.", "Design Project",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this device?", "Delete device", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    db.DeleteRecordByDeviceName<DeviceModel>("devices", cmbDevices.Text);
                    MessageBox.Show("Device deleted.", "Delete device", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (cmbDevices.SelectedIndex >= 0)
                    {
                        cmbDevices.Items.RemoveAt(cmbDevices.SelectedIndex);
                    }
                }
                catch (System.TimeoutException)
                {
                    MessageBox.Show("No connection in the server database.", "Design Project",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }         
        }
    }
}
