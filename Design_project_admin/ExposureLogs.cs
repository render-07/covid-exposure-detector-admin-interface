using MongoDBLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_project_admin
{
    public partial class ExposureLogs : Form
    {
        private readonly MongoAPI db = new MongoAPI("DP");
        private DataTable tableData = new DataTable();

        public DataTable TableData   // property
        {
            get { return tableData; }   // get method
            set { tableData = value; }  // set method
        }

        public ExposureLogs()
        {
            InitializeComponent();
            dataGridView1.DataSource = TableData;
        }

        private void btnExports_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to export this as CSV?", "Export", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "CSV (*.csv)|*.csv";
                    sfd.FileName = "Exposure logs" + ".csv";
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            try
                            {
                                File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                fileError = true;
                                MessageBox.Show(ex.Message, "Export", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }
                        if (!fileError)
                        {
                            try
                            {
                                int columnCount = dataGridView1.Columns.Count;
                                string columnNames = "";
                                string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                                for (int i = 0; i < columnCount; i++)
                                {
                                    columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                                }
                                outputCsv[0] += columnNames;

                                for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                                {
                                    for (int j = 0; j < columnCount; j++)
                                    {
                                        outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                }

                                File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                                MessageBox.Show(string.Format($"Logs are save in {sfd.FileName}"),
                                "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message, "Exoort", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }

                else
                {
                    MessageBox.Show("No logs to export.",
                                "Stack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
