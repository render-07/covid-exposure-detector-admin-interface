using System;
using MongoDBLibrary;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Design_project_admin
{
    public partial class AddDevice : Form
    {
        private readonly MongoAPI db = new MongoAPI("DP");

        public AddDevice()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var records = db.LoadRecordByUID<DeviceModel>("devices", txtUid.Text);

            if (records.Count > 0)
            {
                MessageBox.Show("Device UID existing.", "Add new device", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeviceModel obj = new DeviceModel
            {
                uid = txtUid.Text,
                deviceName = txtDeviceName.Text
            };

            await Task.Run(() => db.InsertRecord("devices", obj));

            var progressBarCount = 0;
            // Reveal progress bar
            progressBar1.Visible = true;
            while (progressBarCount <= 100)
            {
                await Task.Delay(10);
                progressBar1.Value = progressBarCount++;
                btnAdd.Enabled = false;
            }
            
            MessageBox.Show("Device added!", "Add new device", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAdd.Enabled = true;
            // Hide progress bar again.
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }
    }
}
