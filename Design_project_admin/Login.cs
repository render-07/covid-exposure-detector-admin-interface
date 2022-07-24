using MongoDBLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_project_admin
{
    public partial class Login : Form
    {
        private readonly MongoAPI db = new MongoAPI("DP");
        private readonly List<string> storeCredentials = new List<string>();
        private const string DEFAULT_USERNAME = "***LETS_FIGHT_COVID_19***";
        private const string DEFAULT_PASSWORD = "admin123";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            // Checks for empty fields that are required, else then run
            // Authenticate() method.
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Fill up the fields first.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnLogin.Enabled = true;
            }
            else
            {
                Authenticate();
            }
        }

        private async void Authenticate()
        {
            await AuthenticateAsync();

            // This will now wait 1 second until it sets it to empty
            // so you can see that the progress bar does
            // increment to 100
            await Task.Delay(1000);
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            btnLogin.Enabled = true;
        }

        private async Task AuthenticateAsync()
        {
            var progressBarCount = 0;
            progressBar1.Visible = true;
            while (progressBarCount <= 100)
            {
                await Task.Delay(10);
                progressBar1.Value = progressBarCount++;
            }

            var task = Task.Run(() => {
                // THIS IS SUPER ACCOUNT (stored in the application).
                if (txtUsername.Text == DEFAULT_USERNAME && txtPassword.Text == DEFAULT_PASSWORD)
                {
                    DialogResult = DialogResult.OK;
                }

                else
                {
                    // Store credentials.
                    var adminCredentials = db.LoadAccountCredentials<UserModel>("users", txtUsername.Text);
                    foreach (var recs in adminCredentials)
                    {
                        storeCredentials.Add(recs.userName);
                        storeCredentials.Add(recs.password);
                    }

                    // If no account is associated by the username provided,
                    // prompt message with wrong credentials.
                    if (!storeCredentials.Any())
                    {
                        MessageBox.Show("Wrong user name or password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Else compare the password Vs password in the db that is hashed.
                        var result = SecurePasswordHasher.Verify(txtPassword.Text, ReturnStoredCredentials(1));
                        if (result == true && ReturnStoredCredentials(0) == txtUsername.Text)
                        {
                            // Clear information.
                            storeCredentials.Clear();
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            // Clear information.
                            storeCredentials.Clear();
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            MessageBox.Show("Wrong user name or password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            );
        }

        private string ReturnStoredCredentials(int index)
        {
            // Return the username and password.
            return storeCredentials[index];
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
            private static string Hash(string password)
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
            public static bool Verify(string password, string hashedPassword)
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

        #endregion
    }
}   

