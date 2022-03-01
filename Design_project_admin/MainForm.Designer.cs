
namespace Design_project_admin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnMangeAdminAccounts = new System.Windows.Forms.Button();
            this.btnLinkDeviceToPerson = new System.Windows.Forms.Button();
            this.btnManageDevices = new System.Windows.Forms.Button();
            this.btnManagePopulation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExposureLogs = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bwLoadDevices = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrDate = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnMangeAdminAccounts);
            this.panelSideMenu.Controls.Add(this.btnLinkDeviceToPerson);
            this.panelSideMenu.Controls.Add(this.btnManageDevices);
            this.panelSideMenu.Controls.Add(this.btnManagePopulation);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnExposureLogs);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 700);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnMangeAdminAccounts
            // 
            this.btnMangeAdminAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMangeAdminAccounts.FlatAppearance.BorderSize = 0;
            this.btnMangeAdminAccounts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnMangeAdminAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangeAdminAccounts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMangeAdminAccounts.Image = global::Design_project_admin.Properties.Resources.iconmonstr_user_8_2401;
            this.btnMangeAdminAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMangeAdminAccounts.Location = new System.Drawing.Point(0, 324);
            this.btnMangeAdminAccounts.Name = "btnMangeAdminAccounts";
            this.btnMangeAdminAccounts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMangeAdminAccounts.Size = new System.Drawing.Size(250, 56);
            this.btnMangeAdminAccounts.TabIndex = 9;
            this.btnMangeAdminAccounts.Text = "Administation accounts";
            this.btnMangeAdminAccounts.UseVisualStyleBackColor = true;
            this.btnMangeAdminAccounts.Click += new System.EventHandler(this.btnMangeAdminAccounts_Click);
            // 
            // btnLinkDeviceToPerson
            // 
            this.btnLinkDeviceToPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLinkDeviceToPerson.FlatAppearance.BorderSize = 0;
            this.btnLinkDeviceToPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnLinkDeviceToPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkDeviceToPerson.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLinkDeviceToPerson.Image = global::Design_project_admin.Properties.Resources.iconmonstr_link_1_2401;
            this.btnLinkDeviceToPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLinkDeviceToPerson.Location = new System.Drawing.Point(0, 268);
            this.btnLinkDeviceToPerson.Name = "btnLinkDeviceToPerson";
            this.btnLinkDeviceToPerson.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLinkDeviceToPerson.Size = new System.Drawing.Size(250, 56);
            this.btnLinkDeviceToPerson.TabIndex = 8;
            this.btnLinkDeviceToPerson.Text = "Link device to person";
            this.btnLinkDeviceToPerson.UseVisualStyleBackColor = true;
            this.btnLinkDeviceToPerson.Click += new System.EventHandler(this.btnLinkDeviceToPerson_Click);
            // 
            // btnManageDevices
            // 
            this.btnManageDevices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageDevices.FlatAppearance.BorderSize = 0;
            this.btnManageDevices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnManageDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageDevices.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManageDevices.Image = global::Design_project_admin.Properties.Resources.iconmonstr_disk_9_240;
            this.btnManageDevices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageDevices.Location = new System.Drawing.Point(0, 212);
            this.btnManageDevices.Name = "btnManageDevices";
            this.btnManageDevices.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageDevices.Size = new System.Drawing.Size(250, 56);
            this.btnManageDevices.TabIndex = 7;
            this.btnManageDevices.Text = "Manage devices";
            this.btnManageDevices.UseVisualStyleBackColor = true;
            this.btnManageDevices.Click += new System.EventHandler(this.btnManageDevices_Click);
            // 
            // btnManagePopulation
            // 
            this.btnManagePopulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagePopulation.FlatAppearance.BorderSize = 0;
            this.btnManagePopulation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnManagePopulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagePopulation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManagePopulation.Image = global::Design_project_admin.Properties.Resources.iconmonstr_user_29_2401;
            this.btnManagePopulation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagePopulation.Location = new System.Drawing.Point(0, 156);
            this.btnManagePopulation.Name = "btnManagePopulation";
            this.btnManagePopulation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManagePopulation.Size = new System.Drawing.Size(250, 56);
            this.btnManagePopulation.TabIndex = 6;
            this.btnManagePopulation.Text = "Manage population information";
            this.btnManagePopulation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManagePopulation.UseVisualStyleBackColor = true;
            this.btnManagePopulation.Click += new System.EventHandler(this.btnManagePopulation_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 643);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Image = global::Design_project_admin.Properties.Resources.iconmonstr_log_out_7_2401;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 644);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 56);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExposureLogs
            // 
            this.btnExposureLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExposureLogs.FlatAppearance.BorderSize = 0;
            this.btnExposureLogs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnExposureLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExposureLogs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExposureLogs.Image = global::Design_project_admin.Properties.Resources.iconmonstr_virus_1_2401;
            this.btnExposureLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExposureLogs.Location = new System.Drawing.Point(0, 100);
            this.btnExposureLogs.Name = "btnExposureLogs";
            this.btnExposureLogs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExposureLogs.Size = new System.Drawing.Size(250, 56);
            this.btnExposureLogs.TabIndex = 1;
            this.btnExposureLogs.Text = "Exposure logs";
            this.btnExposureLogs.UseVisualStyleBackColor = true;
            this.btnExposureLogs.Click += new System.EventHandler(this.btnExposureLogs_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelBottom.Controls.Add(this.progressBar1);
            this.panelBottom.Controls.Add(this.lblStatus);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(250, 558);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 142);
            this.panelBottom.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 119);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.LightGray;
            this.lblStatus.Location = new System.Drawing.Point(20, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Label status";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.panel3);
            this.panelChildForm.Location = new System.Drawing.Point(250, 36);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(800, 522);
            this.panelChildForm.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.richTextBox2);
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Location = new System.Drawing.Point(23, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 473);
            this.panel3.TabIndex = 0;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Lato", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(28, 335);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(696, 59);
            this.richTextBox3.TabIndex = 6;
            this.richTextBox3.Text = "Description";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(265, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(0, 409);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(753, 64);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "Content";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Lato", 15.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(753, 93);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Title";
            // 
            // bwLoadDevices
            // 
            this.bwLoadDevices.WorkerReportsProgress = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 36);
            this.panel2.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(636, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 16);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "-";
            // 
            // tmrDate
            // 
            this.tmrDate.Interval = 1000;
            this.tmrDate.Tick += new System.EventHandler(this.tmrDate_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 700);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1050, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Design Project";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panelSideMenu.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExposureLogs;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker bwLoadDevices;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrDate;
        private System.Windows.Forms.Button btnLinkDeviceToPerson;
        private System.Windows.Forms.Button btnManageDevices;
        private System.Windows.Forms.Button btnManagePopulation;
        private System.Windows.Forms.Button btnMangeAdminAccounts;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}

