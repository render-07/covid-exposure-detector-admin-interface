
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.bwLoadDevices = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrDate = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMangeAdminAccounts = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnManageDevices = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExposureLogs = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnMangeAdminAccounts);
            this.panelSideMenu.Controls.Add(this.button3);
            this.panelSideMenu.Controls.Add(this.btnManageDevices);
            this.panelSideMenu.Controls.Add(this.button1);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 643);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 5;
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
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Location = new System.Drawing.Point(250, 36);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(800, 522);
            this.panelChildForm.TabIndex = 2;
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Design_project_admin.Properties.Resources._273759060_474864474236489_1053595112813018540_n;
            this.pictureBox1.Location = new System.Drawing.Point(245, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Image = global::Design_project_admin.Properties.Resources.iconmonstr_link_1_2401;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 268);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(250, 56);
            this.button3.TabIndex = 8;
            this.button3.Text = "Link device to person";
            this.button3.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = global::Design_project_admin.Properties.Resources.iconmonstr_user_29_2401;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 156);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Manage population information";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelChildForm);
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
            this.panelSideMenu.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker bwLoadDevices;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrDate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnManageDevices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMangeAdminAccounts;
    }
}

