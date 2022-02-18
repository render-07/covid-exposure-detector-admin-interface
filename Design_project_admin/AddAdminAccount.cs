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
    public partial class AddAdminAccount : Form
    {
        private readonly MongoAPI db = new MongoAPI("DP");

        public AddAdminAccount()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var records = db.LoadRecordByUsername<UserModel>("devices", txtUsername.Text);

            if (records.Count > 0)
            {
                MessageBox.Show("Username existing.", "Add new account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserModel obj = new UserModel
            {
                firstName = txtFirstName.Text,
                middleName = txtMiddleName.Text,
                lastName = txtLastName.Text,
                dateOfBirth = dateTimePicker1.Value,
                address = txtAddress.Text,
                userName = txtUsername.Text,
                password = txtPassword.Text
            };

            await Task.Run(() => db.InsertRecord("users", obj));

            var progressBarCount = 0;
            // Reveal progress bar
            progressBar1.Visible = true;
            while (progressBarCount <= 100)
            {
                await Task.Delay(10);
                progressBar1.Value = progressBarCount++;
                btnAdd.Enabled = false;
            }

            MessageBox.Show("Account added!", "Add new account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAdd.Enabled = true;
            // Hide progress bar again.
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }
    }
}
