using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDBLibrary;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        private IList<NewsApiModel> searchResults = new List<NewsApiModel>();

        private void MainForm_Load(object sender, EventArgs e)
        {
           // var url = "https://newsapi.org/v2/top-headlines?" +
           //"country=ph&" +
           //"q=COVID-19&" +
           //"apiKey=f8f6e937e8714abe90325099b943b1fd";

            var url = "https://newsapi.org/v2/top-headlines?%20country=ph&q=COVID-19&apiKey=f8f6e937e8714abe90325099b943b1fd";

            // var json = Task.Run(() => new WebClient().DownloadString(url));
            var json = new WebClient().DownloadString(url);

            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            // var result = await json;

            //var jsonElement = System.Text.Json.JsonSerializer.Deserialize<JsonElement>(result);
            //MessageBox.Show(System.Text.Json.JsonSerializer.Serialize(jsonElement, options));


            JObject googleSearch = JObject.Parse(json);

            // get JSON result objects into a list
            IList<JToken> results = googleSearch["articles"].Children().ToList();

            // serialize JSON results into .NET objects
            foreach (JToken rec in results)
            {
                NewsApiModel searchResult = JsonConvert.DeserializeObject<NewsApiModel>(rec.ToString());
                searchResults.Add(searchResult);
            }

            // List the properties of the searchResults IList
            foreach (NewsApiModel item in searchResults)
            {
                //MessageBox.Show(item.author);
                //MessageBox.Show(item.title);
                //MessageBox.Show(item.description);
                richTextBox1.Text = item.title;
                richTextBox2.Text = item.content;
                richTextBox3.Text = item.description;
                ///MessageBox.Show(item.urlToImage);
                ///
                pictureBox1.ImageLocation = item.urlToImage;
            }
        }


        private void MainForm_Shown(object sender, EventArgs e)
        {
    
        }

        // TODO
        // csv bulk for device
        // csv bulk for persons

        private void tmrDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Today();
        }


        //private async void btnManageDevices_Click(object sender, EventArgs e)
        //{
        
        //}

        //private async void btnMangeAdminAccounts_Click(object sender, EventArgs e)
        //{
        //    // Update UI
        //    hideSubMenu();
        //    lblStatus.Visible = true;
        //    lblStatus.Text = "Loading accounts...";

        //    try
        //    {
        //        // Initialize ManageDevice form
        //        ManageAdminAccountsForm obj = new ManageAdminAccountsForm();
        //        // On form load, trigger the ProgressBar effect
        //        obj.TableData.Columns.Clear();
        //        obj.TableData.Rows.Clear();
        //        obj.FormClosed += Obj_FormClosed;
        //        // Run operation in another thread
        //        await LoadAccountsAsync(obj);
        //        openChildForm(obj);
        //    }
        //    catch (Exception)
        //    {
        //        //Handle Exception
        //    }

        //    lblStatus.Text = "Accounts loaded.";
        //    // This will now wait 1 second until it sets it to empty
        //    // so you can see that the progress bar does
        //    // increment to 100
        //    await Task.Delay(1000);
        //    progressBar1.Value = 0;
        //}

        private void Obj_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Empty status on form closed.
            lblStatus.Text = "";
        }

        private async void btnExposureLogs_Click(object sender, EventArgs e)
        {
            // Update UI
            hideSubMenu();
            lblStatus.Visible = true;
            lblStatus.Text = "Loading logs...";
            progressBar1.Visible = true;

            btnManagePopulation.Enabled = false;
            btnManageDevices.Enabled = false;
            btnLinkDeviceToPerson.Enabled = false;
            btnMangeAdminAccounts.Enabled = false;

            // Initialize ManageDevice form
            ExposureLogs obj = new ExposureLogs();
            // On form load, trigger the ProgressBar effect
            obj.TableData.Columns.Clear();
            obj.TableData.Rows.Clear();
            obj.FormClosed += Obj_FormClosed;
            // Run operation in another thread
            await LoadExposureAsync(obj);
            openChildForm(obj);

            lblStatus.Text = "Exposure logs loaded.";
            // This will now wait 1 second until it sets it to empty
            // so you can see that the progress bar does
            // increment to 100
            await Task.Delay(1000);
            progressBar1.Value = 0;
            progressBar1.Visible = false;

            btnManagePopulation.Enabled = true;
            btnManageDevices.Enabled = true;
            btnLinkDeviceToPerson.Enabled = true;
            btnMangeAdminAccounts.Enabled = true;
        }


        private async void btnManagePopulation_Click(object sender, EventArgs e)
        {
            // Update UI
            hideSubMenu();
            lblStatus.Visible = true;
            lblStatus.Text = "Loading population...";
            progressBar1.Visible = true;

            btnExposureLogs.Enabled = false;
            btnManageDevices.Enabled = false;
            btnLinkDeviceToPerson.Enabled = false;
            btnMangeAdminAccounts.Enabled = false;

            try
            {
                // Initialize ManageDevice form
                ManagePopulation obj = new ManagePopulation();
                // On form load, trigger the ProgressBar effect
                obj.TableData.Columns.Clear();
                obj.TableData.Rows.Clear();
                obj.FormClosed += Obj_FormClosed;
                // Run operation in another thread
                await LoadPopulationAsync(obj);
                openChildForm(obj);
            }
            catch (Exception)
            {
                //Handle Exception
            }

            lblStatus.Text = "Population information loaded.";
            // This will now wait 1 second until it sets it to empty
            // so you can see that the progress bar does
            // increment to 100
            await Task.Delay(1000);
            progressBar1.Value = 0;
            progressBar1.Visible = false;

            btnExposureLogs.Enabled = true;
            btnManageDevices.Enabled = true;
            btnLinkDeviceToPerson.Enabled = true;
            btnMangeAdminAccounts.Enabled = true;
        }


        private async void btnManageDevices_Click(object sender, EventArgs e)
        {
            // Update UI
            hideSubMenu();
            lblStatus.Visible = true;
            lblStatus.Text = "Loading devices...";
            progressBar1.Visible = true;

            btnExposureLogs.Enabled = false;
            btnManagePopulation.Enabled = false;
            btnLinkDeviceToPerson.Enabled = false;
            btnMangeAdminAccounts.Enabled = false;

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
            progressBar1.Visible = false;

            btnExposureLogs.Enabled = true;
            btnManagePopulation.Enabled = true;
            btnLinkDeviceToPerson.Enabled = true;
            btnMangeAdminAccounts.Enabled = true;
        }

        private async void btnLinkDeviceToPerson_Click(object sender, EventArgs e)
        {
            // Update UI
            hideSubMenu();
            lblStatus.Visible = true;
            lblStatus.Text = "Loading...";
            progressBar1.Visible = true;

            btnExposureLogs.Enabled = false;
            btnManagePopulation.Enabled = false;
            btnManageDevices.Enabled = false;
            btnMangeAdminAccounts.Enabled = false;

            try
            {
                // Initialize ManageDevice form
                LinkDeviceToPerson obj = new LinkDeviceToPerson();
                // On form load, trigger the ProgressBar effect
                obj.FormClosed += Obj_FormClosed;
                // Run operation in another thread
                await LoadDevicePersonAsync(obj);
                openChildForm(obj);
            }
            catch (Exception)
            {
                //Handle Exception
            }

            lblStatus.Text = "";
            // This will now wait 1 second until it sets it to empty
            // so you can see that the progress bar does
            // increment to 100
            await Task.Delay(1000);
            progressBar1.Value = 0;
            progressBar1.Visible = false;

            btnExposureLogs.Enabled = true;
            btnManagePopulation.Enabled = true;
            btnManageDevices.Enabled = true;
            btnMangeAdminAccounts.Enabled = true;
        }

        private async void btnMangeAdminAccounts_Click(object sender, EventArgs e)
        {
            // Update UI
            hideSubMenu();
            lblStatus.Visible = true;
            lblStatus.Text = "Loading accounts...";
            progressBar1.Visible = true;

            btnExposureLogs.Enabled = false;
            btnManagePopulation.Enabled = false;
            btnManageDevices.Enabled = false;
            btnLinkDeviceToPerson.Enabled = false;

            try
            {
                // Initialize ManageDevice form
                ManageAdminAccounts obj = new ManageAdminAccounts();
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
            progressBar1.Visible = false;

            btnExposureLogs.Enabled = true;
            btnManagePopulation.Enabled = true;
            btnManageDevices.Enabled = true;
            btnLinkDeviceToPerson.Enabled = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout = true;
            Close();
        }

        #region CRUD Operations

        private async Task LoadDevicePersonAsync(LinkDeviceToPerson obj)
        {
            var deviceRecords = Task.Run(() => db.LoadAllRecords<DeviceModel>("devices"));
            var personRecords = Task.Run(() => db.LoadAllRecords<PersonModel>("population"));

            var progressBarCount = 0;
            while (progressBarCount <= 100)
            {
                await Task.Delay(10);
                progressBar1.Value = progressBarCount++;
            }

            var result1 = await deviceRecords;
            var result2 = await personRecords;

            foreach (var recs1 in result1)
            {
                try
                {
                    // Populate the Datagrid from another form
                    obj.DeviceNames.Add(recs1);
                }
                catch (System.NullReferenceException)
                {

                }
            }

            foreach (var recs2 in result2)
            {
                try
                {
                    // Populate the Datagrid from another form
                    obj.PopulationNames.Add(recs2);
                }
                catch (System.NullReferenceException)
                {

                }
            }
        }

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

        private async Task LoadAccountsAsync(ManageAdminAccounts obj)
        {
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

        private async Task LoadPopulationAsync(ManagePopulation obj)
        {
            var records = Task.Run(() => db.LoadAllRecords<PersonModel>("population"));

            var progressBarCount = 0;
            while (progressBarCount <= 100)
            {
                await Task.Delay(10);
                progressBar1.Value = progressBarCount++;
            }

            obj.TableData.Columns.Add("Fullname");
            obj.TableData.Columns.Add("Date of birth");
            obj.TableData.Columns.Add("Address");
            obj.TableData.Columns.Add("Gender");
            obj.TableData.Columns.Add("Age");
            obj.TableData.Columns.Add("Contact Number");
            obj.TableData.Columns.Add("Number of persons in the house");
            obj.TableData.Columns.Add("Email");

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
                        recs.dateOfBirth.ToString(),
                        recs.address.ToString(),
                        recs.gender.ToString(),
                        recs.age.ToString(),
                        recs.contactNumber.ToString(),
                        recs.NumberOfPersonsInTheHouse.ToString(),
                        recs.email.ToString()
                    );
                }
                catch (System.NullReferenceException)
                {

                }
            }
        }

        private async Task LoadExposureAsync(ExposureLogs obj)
        {
            var records = Task.Run(() => db.LoadAllRecords<PersonModel>("population"));
            var contactTracing = Task.Run(() => db.LoadAllRecords<InformationModel>("information"));

            var progressBarCount = 0;
            while (progressBarCount <= 100)
            {
                await Task.Delay(10);
                progressBar1.Value = progressBarCount++;
            }

            obj.TableData.Columns.Add("Fullname");
            obj.TableData.Columns.Add("Linked device");
            obj.TableData.Columns.Add("Close contact");
            obj.TableData.Columns.Add("Date");
            obj.TableData.Columns.Add("Location");

            // get all logs of contacts
            var result = await contactTracing;

            foreach (var recs in result)
            {

                string fullName = string.Empty;
                string fullNameOfContactedPerson = string.Empty;
                string location = string.Empty;

                // get the _id of device by deviceName
                var getIDByDeviceName = db.LoadDeviceByDeviceName<DeviceModel>("devices", recs.fromWhatDevice);
                foreach (var deviceId in getIDByDeviceName)
                {
                    // get person _id by device _id
                    var getpersonId = db.GetPersonIdByDeviceId<LinkModel>("link", deviceId._id);

                    // get location
                    var getLocation = db.LoadLocationByUID<LocationModel>("locations", deviceId.uid);
                    foreach (var locationItem in getLocation)
                    {
                        location = locationItem.latitude + ", " + locationItem.longitude;
                    }
                    foreach (var personId in getpersonId)
                    {
                        // get information of person by person _id
                        var getPerson = db.LoadPersonByPersonId<PersonModel>("population", personId.personId);
                        foreach (var person in getPerson)
                        {
                            fullName = person.firstName.ToString() + " " +
                                person.middleName.ToString() + " " + person.lastName.ToString();

                            // This is for close contacts info
                            var getDeviceById = db.LoadDeviceDeviceUID<DeviceModel>("devices", recs.closeContact);
                            foreach (var device in getDeviceById)
                            {

                                var getPersonLinkedInDevice = db.GetPersonIdByDeviceId<LinkModel>("link", device._id);
                                foreach (var contactPersonId in getPersonLinkedInDevice)
                                {
                                    // get information of person by person _id
                                    var contactPersonInfos = db.LoadPersonByPersonId<PersonModel>("population", contactPersonId.personId);
                                    foreach (var contactPersonInfo in contactPersonInfos)
                                    {
                                        fullNameOfContactedPerson = contactPersonInfo.firstName.ToString() + " " +
                                        contactPersonInfo.middleName.ToString() + " " +
                                        contactPersonInfo.lastName.ToString();
                                    }
                                }

                            }
                        }
                    }
                }


                obj.TableData.Rows.Add(
                    fullName,
                    recs.fromWhatDevice,
                    fullNameOfContactedPerson,
                    recs.date,
                    location
                );
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
            // panelSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            //if (panelSubMenu.Visible == true)
            //{
            //    panelSubMenu.Visible = false;
            //}
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
