using MongoDBLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

            var hash = SecurePasswordHasher.Hash(txtPassword.Text);

            UserModel obj = new UserModel
            {
                firstName = txtFirstName.Text,
                middleName = txtMiddleName.Text,
                lastName = txtLastName.Text,
                dateOfBirth = dateTimePicker1.Value,
                address = txtAddress.Text,
                userName = txtUsername.Text,
                password = hash
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

        #region PasswordHashing

        private static class SecurePasswordHasher
        {
            /// <summary>
            /// Size of salt.
            /// </summary>
            private const int SaltSize = 16;

            /// <summary>
            /// Size of hash.
            /// </summary>
            private const int HashSize = 20;

            /// <summary>
            /// Creates a hash from a password.
            /// </summary>
            /// <param name="password">The password.</param>
            /// <param name="iterations">Number of iterations.</param>
            /// <returns>The hash.</returns>
            private static string Hash(string password, int iterations)
            {
                // Create salt
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

                // Create hash
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
                var hash = pbkdf2.GetBytes(HashSize);

                // Combine salt and hash
                var hashBytes = new byte[SaltSize + HashSize];
                Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

                // Convert to base64
                var base64Hash = Convert.ToBase64String(hashBytes);

                // Format hash with extra information
                return string.Format("$MYHASH$V1${0}${1}", iterations, base64Hash);
            }

            /// <summary>
            /// Creates a hash from a password with 10000 iterations
            /// </summary>
            /// <param name="password">The password.</param>
            /// <returns>The hash.</returns>
            public static string Hash(string password)
            {
                return Hash(password, 10000);
            }

            /// <summary>
            /// Checks if hash is supported.
            /// </summary>
            /// <param name="hashString">The hash.</param>
            /// <returns>Is supported?</returns>
            private static bool IsHashSupported(string hashString)
            {
                return hashString.Contains("$MYHASH$V1$");
            }

            /// <summary>
            /// Verifies a password against a hash.
            /// </summary>
            /// <param name="password">The password.</param>
            /// <param name="hashedPassword">The hash.</param>
            /// <returns>Could be verified?</returns>
            private static bool Verify(string password, string hashedPassword)
            {
                // Check hash
                if (!IsHashSupported(hashedPassword))
                {
                    throw new NotSupportedException("The hashtype is not supported");
                }

                // Extract iteration and Base64 string
                var splittedHashString = hashedPassword.Replace("$MYHASH$V1$", "").Split('$');
                var iterations = int.Parse(splittedHashString[0]);
                var base64Hash = splittedHashString[1];

                // Get hash bytes
                var hashBytes = Convert.FromBase64String(base64Hash);

                // Get salt
                var salt = new byte[SaltSize];
                Array.Copy(hashBytes, 0, salt, 0, SaltSize);

                // Create hash with given salt
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
                byte[] hash = pbkdf2.GetBytes(HashSize);

                // Get result
                for (var i = 0; i < HashSize; i++)
                {
                    if (hashBytes[i + SaltSize] != hash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }


        //private byte[] DeriveKey(SecureString password, byte[] salt, int iterations, int keyByteLength) {
        //    IntPtr ptr = Marshal.SecureStringToBSTR(password);
        //    byte[] passwordByteArray = null;
        //    try {
        //        int length = Marshal.ReadInt32(ptr, -4);
        //        passwordByteArray = new byte[length];
        //        GCHandle handle = GCHandle.Alloc(passwordByteArray, GCHandleType.Pinned);
        //        try {
        //            for (int i = 0; i < length; i++) {
        //                passwordByteArray[i] = Marshal.ReadByte(ptr, i);
        //            }

        //            using (var rfc2898 = new Rfc2898DeriveBytes(passwordByteArray, salt, iterations)) {
        //                return rfc2898.GetBytes(keyByteLength);
        //            }
        //        } finally {
        //            Array.Clear(passwordByteArray, 0, passwordByteArray.Length);
        //            handle.Free();
        //        }
        //    } finally {
        //        Marshal.ZeroFreeBSTR(ptr);
        //    }
        //}
        #endregion



    }
}
