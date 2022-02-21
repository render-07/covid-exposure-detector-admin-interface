using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_project_admin
{
    static class Program
    {
        private static bool _logout;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool instanceCountOne = false;

            using (Mutex mtex = new Mutex(true, Application.ProductName, out instanceCountOne))
            {
                if (instanceCountOne)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Login();
                    mtex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show("Application is already running.", "Design Project", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //Application.Run(new Splash());
        }

        private static void Login()
        {
            using (Login login = new Login())
            {
                using (MainForm main = new MainForm())
                {
                    main.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
                    Splash obj = new Splash();
                    obj.ShowDialog();
                    
                    if (login.ShowDialog(main) == DialogResult.OK)
                    {
                        // Runs the whole program.
                        Application.Run(main);

                        // If logout == true, go back to loginpage.
                        if (_logout)
                        {
                            // Clear all caches.
                            login.Dispose();
                            main.Dispose();
                            Application.Restart();
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private static void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logout = (sender as MainForm).Logout;
        }
    }
}
