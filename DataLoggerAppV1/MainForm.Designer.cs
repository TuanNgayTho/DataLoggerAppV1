namespace DataLoggerAppV1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnTrend = new System.Windows.Forms.Button();
            this.btnAlarmList = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNameOfPage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnMonitor);
            this.panel1.Controls.Add(this.btnTrend);
            this.panel1.Controls.Add(this.btnAlarmList);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 1080);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Location = new System.Drawing.Point(0, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 1);
            this.panel4.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 395);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menu Bar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(10, 228);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(187, 44);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(0, 940);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnSettings.Size = new System.Drawing.Size(208, 73);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnMonitor
            // 
            this.btnMonitor.FlatAppearance.BorderSize = 0;
            this.btnMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitor.Image = ((System.Drawing.Image)(resources.GetObject("btnMonitor.Image")));
            this.btnMonitor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMonitor.Location = new System.Drawing.Point(0, 807);
            this.btnMonitor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnMonitor.Size = new System.Drawing.Size(208, 73);
            this.btnMonitor.TabIndex = 1;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnTrend
            // 
            this.btnTrend.FlatAppearance.BorderSize = 0;
            this.btnTrend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrend.Image = ((System.Drawing.Image)(resources.GetObject("btnTrend.Image")));
            this.btnTrend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrend.Location = new System.Drawing.Point(0, 674);
            this.btnTrend.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTrend.Name = "btnTrend";
            this.btnTrend.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnTrend.Size = new System.Drawing.Size(208, 73);
            this.btnTrend.TabIndex = 1;
            this.btnTrend.Text = "Trend";
            this.btnTrend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrend.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTrend.UseVisualStyleBackColor = true;
            this.btnTrend.Click += new System.EventHandler(this.button3_Click);
            this.btnTrend.Leave += new System.EventHandler(this.btnExport_Leave);
            // 
            // btnAlarmList
            // 
            this.btnAlarmList.FlatAppearance.BorderSize = 0;
            this.btnAlarmList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarmList.Image = ((System.Drawing.Image)(resources.GetObject("btnAlarmList.Image")));
            this.btnAlarmList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlarmList.Location = new System.Drawing.Point(0, 541);
            this.btnAlarmList.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAlarmList.Name = "btnAlarmList";
            this.btnAlarmList.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnAlarmList.Size = new System.Drawing.Size(208, 73);
            this.btnAlarmList.TabIndex = 1;
            this.btnAlarmList.Text = "Alarm List";
            this.btnAlarmList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlarmList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlarmList.UseVisualStyleBackColor = true;
            this.btnAlarmList.Click += new System.EventHandler(this.btnAlarmList_Click);
            this.btnAlarmList.Leave += new System.EventHandler(this.btnAlarmList_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.Location = new System.Drawing.Point(0, 408);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDashboard.Size = new System.Drawing.Size(208, 73);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblNameOfPage);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblSystemName);
            this.panel3.Location = new System.Drawing.Point(-6, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1949, 80);
            this.panel3.TabIndex = 1;
            // 
            // lblNameOfPage
            // 
            this.lblNameOfPage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfPage.Location = new System.Drawing.Point(1804, 54);
            this.lblNameOfPage.Name = "lblNameOfPage";
            this.lblNameOfPage.Size = new System.Drawing.Size(115, 22);
            this.lblNameOfPage.TabIndex = 1;
            this.lblNameOfPage.Text = "Page Name";
            this.lblNameOfPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameOfPage.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1879, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1751, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Page:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSystemName
            // 
            this.lblSystemName.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(670, 11);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(630, 57);
            this.lblSystemName.TabIndex = 1;
            this.lblSystemName.Text = "Data Logger CDQC System";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSystemName.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(208, 78);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1712, 1002);
            this.pnlFormLoader.TabIndex = 2;
            this.pnlFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormLoader_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnTrend;
        private System.Windows.Forms.Button btnAlarmList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNameOfPage;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMonitor;
    }
}

