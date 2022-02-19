using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDBLibrary;

namespace Design_project_admin
{
    public partial class MainForm : Form
    {
        private readonly MongoAPI db = new MongoAPI("DP");
        public bool Logout = false;

        public MainForm()
        {
            InitializeComponent();
            HideSubButtons();
            lblStatus.Visible = false;
            tmrDate.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // TODO
        // add person
        // link person to device
        // csv bulk for device
        // csv bulk for persons
        // Exposure Logs
        // Persons
        // Devices
        // Accounts

        private void tmrDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Today();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }

        private async void btnManageDevices_Click(object sender, EventArgs e)
        {
            // Update UI
            hideSubMenu();
            lblStatus.Visible = true;
            lblStatus.Text = "Loading devices...";

            try
            {
                // Initialize ManageDevice form
                ManageDevice obj = new ManageDevice();
                // On form load, trigger the ProgressBar effect
                obj.TableData.Columns.Clear();
                obj.TableData.Rows.Clear();
                obj.FormClosed += Obj_FormClosed;
                // Run operation in another thread
                await LoadDevicesAsync(obj);
                openChildForm(obj);
            }
            catch (Exception)
            {
                //Handle Exception
            }
            lblStatus.Text = "Devices loaded.";
            // This will now wait 1 second until it sets it to empty
            // so you can see that the progress bar does
            // increment to 100
            await Task.Delay(1000);
            progressBar1.Value = 0;
        }

        private async void btnMangeAdminAccounts_Click(object sender, EventArgs e)
        {
            // Update UI
            hideSubMenu();
            lblStatus.Visible = true;
            lblStatus.Text = "Loading accounts...";

            try
            {
                // Initialize ManageDevice form
                ManageAdminAccountsForm obj = new ManageAdminAccountsForm();
                // On form load, trigger the ProgressBar effect
                obj.TableData.Columns.Clear();
                obj.TableData.Rows.Clear();
                obj.FormClosed += Obj_FormClosed;
                // Run operation in another thread
                await LoadAccountsAsync(obj);
                openChildForm(obj);
            }
            catch (Exception)
            {
                //Handle Exception
            }

            lblStatus.Text = "Accounts loaded.";
            // This will now wait 1 second until it sets it to empty
            // so you can see that the progress bar does
            // increment to 100
            await Task.Delay(1000);
            progressBar1.Value = 0;
        }

        private void Obj_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Empty status on form closed.
            lblStatus.Text = "";
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout = true;
            Close();
        }

        # region CRUD Operations

        private async Task LoadDevicesAsync(ManageDevice obj)
        {
            /// var records = await db.LoadRecord<DeviceModel>("devices");
            var records = Task.Run(() => db.LoadAllRecords<DeviceModel>("devices"));

            var progressBarCount = 0;
            while (progressBarCount <= 100)
            {
                await Task.Delay(10);
                progressBar1.Value = progressBarCount++;
            }

            obj.TableData.Columns.Add("UID");
            obj.TableData.Columns.Add("Device name");
            var result = await records;
            foreach (var recs in result)
            {
                try
                {
                    // Populate the Datagrid from another form
                    obj.TableData.Rows.Add(
                        recs.uid.ToString(), 
                        recs.deviceName.ToString());
                }
                catch (System.NullReferenceException)
                {

                }
            }         
        }

        private async Task LoadAccountsAsync(ManageAdminAccountsForm obj)
        {
            /// var records = await db.LoadRecord<DeviceModel>("devices");
            var records = Task.Run(() => db.LoadAllRecords<UserModel>("users"));

            var progressBarCount = 0;
            while (progressBarCount <= 100)
            {
                await Task.Delay(10);
                progressBar1.Value = progressBarCount++;
            }

            obj.TableData.Columns.Add("Fullname");
            obj.TableData.Columns.Add("Address");
            obj.TableData.Columns.Add("Date of birth");
            obj.TableData.Columns.Add("Username");
            var result = await records;
            foreach (var recs in result)
            {
                try
                {
                    // Populate the Datagrid from another form
                    obj.TableData.Rows.Add(
                        recs.firstName.ToString() + " " +
                        recs.middleName.ToString() + " " +
                        recs.lastName.ToString(),
                        recs.address.ToString(),
                        recs.dateOfBirth.ToString(),
                        recs.userName.ToString()
                    );
                }
                catch (System.NullReferenceException)
                {

                }
            }
        }

        #endregion

        # region Utilities

        private void Calculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        private void HideSubButtons()
        {
            panelSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            } else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private string Today()
        {
            // Returns date today.
            DateTime today = DateTime.Now;
            return today.ToString("MMM dd yyyy, hh:mm tt");
        }

        #endregion

    }
}
