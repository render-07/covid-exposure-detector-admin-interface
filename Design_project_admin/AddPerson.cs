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
using System.ComponentModel.DataAnnotations;

namespace Design_project_admin
{
    public partial class AddPerson : Form
    {
        private readonly MongoAPI db = new MongoAPI("DP");

        public AddPerson()
        {
            InitializeComponent();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (PersonModelValidator())
            {
                if (!checkBox1.Checked)
                {
                    MessageBox.Show("Please check the box if you want to proceed.", "Add new person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                PersonModel obj = new PersonModel
                {
                    firstName = txtFirstName.Text,
                    middleName = txtMiddleName.Text,
                    lastName = txtLastName.Text,
                    dateOfBirth = dateTimePicker1.Value,
                    address = txtAddress.Text,
                    gender = cmbGender.Text,
                    age = int.Parse(txtAge.Text),
                    contactNumber = txtContactNumber.Text,
                    NumberOfPersonsInTheHouse = int.Parse(txtNoOfPersons.Text),
                    email = txtEmail.Text
                };

                await Task.Run(() => db.InsertRecord("population", obj));

                var progressBarCount = 0;
                // Reveal progress bar
                progressBar1.Visible = true;
                while (progressBarCount <= 100)
                {
                    await Task.Delay(10);
                    progressBar1.Value = progressBarCount++;
                    btnAdd.Enabled = false;
                }

                MessageBox.Show("Person added!", "Add new person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAdd.Enabled = true;
                // Hide progress bar again.
                progressBar1.Value = 0;
                progressBar1.Visible = false;

                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                txtAddress.Clear();
                cmbGender.Text = "";
                txtAge.Clear();
                txtContactNumber.Clear();
                txtNoOfPersons.Clear();
                txtEmail.Clear();
                checkBox1.Checked = false;
            }
        }

        private bool PersonModelValidator()
        {
            var fields = PersonModelFields();
            var results = new List<ValidationResult>();
            var context = new ValidationContext(fields, null, null);

            if (Validator.TryValidateObject(fields, context, results, true) == false)
            {
                var validationMessage = String.Join("\n", results.Select(t => String.Format("{0}", t.ErrorMessage)));
                MessageBox.Show(validationMessage, "Add new person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private PersonModel PersonModelFields()
        {
            return new PersonModel
            {
                firstName = txtFirstName.Text,
                middleName = txtMiddleName.Text,
                lastName = txtLastName.Text,
                dateOfBirth = dateTimePicker1.Value,
                address = txtAddress.Text,
                gender = cmbGender.Text,
                age = int.Parse(txtAge.Text),
                contactNumber = txtContactNumber.Text,
                NumberOfPersonsInTheHouse = int.Parse(txtNoOfPersons.Text),
                email = txtEmail.Text
            };
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNoOfPersons_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
