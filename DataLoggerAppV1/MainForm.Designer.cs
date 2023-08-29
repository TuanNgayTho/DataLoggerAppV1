﻿namespace DataLoggerAppV1
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
            this.pnlline = new System.Windows.Forms.Panel();
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblNameOfPage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            this.pnlTrend = new System.Windows.Forms.Panel();
            this.PnlDisplay = new System.Windows.Forms.Panel();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PnlDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.pnlline);
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
            this.panel1.Size = new System.Drawing.Size(208, 1041);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlline
            // 
            this.pnlline.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlline.Location = new System.Drawing.Point(0, 77);
            this.pnlline.Name = "pnlline";
            this.pnlline.Size = new System.Drawing.Size(209, 1);
            this.pnlline.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 346);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menu Bar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(4, 163);
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
            this.pictureBox1.Location = new System.Drawing.Point(29, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(1, 961);
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
            this.btnMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMonitor.FlatAppearance.BorderSize = 0;
            this.btnMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitor.Image = ((System.Drawing.Image)(resources.GetObject("btnMonitor.Image")));
            this.btnMonitor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMonitor.Location = new System.Drawing.Point(0, 878);
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
            this.btnTrend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrend.FlatAppearance.BorderSize = 0;
            this.btnTrend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrend.Image = ((System.Drawing.Image)(resources.GetObject("btnTrend.Image")));
            this.btnTrend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrend.Location = new System.Drawing.Point(-2, 795);
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
            this.btnAlarmList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlarmList.FlatAppearance.BorderSize = 0;
            this.btnAlarmList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarmList.Image = ((System.Drawing.Image)(resources.GetObject("btnAlarmList.Image")));
            this.btnAlarmList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlarmList.Location = new System.Drawing.Point(0, 712);
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
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.Location = new System.Drawing.Point(-4, 629);
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
            this.panel3.Controls.Add(this.pnlLine2);
            this.panel3.Controls.Add(this.lblNameOfPage);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblSystemName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(208, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1696, 80);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(48, 203);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 133);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // lblNameOfPage
            // 
            this.lblNameOfPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameOfPage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfPage.Location = new System.Drawing.Point(1577, 54);
            this.lblNameOfPage.Name = "lblNameOfPage";
            this.lblNameOfPage.Size = new System.Drawing.Size(114, 22);
            this.lblNameOfPage.TabIndex = 1;
            this.lblNameOfPage.Text = "Page Name";
            this.lblNameOfPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameOfPage.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1652, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1524, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Page:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSystemName
            // 
            this.lblSystemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSystemName.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(0, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(1696, 80);
            this.lblSystemName.TabIndex = 1;
            this.lblSystemName.Text = "Data Logger CDQC System";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSystemName.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormLoader.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFormLoader.Location = new System.Drawing.Point(20, 15);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1660, 931);
            this.pnlFormLoader.TabIndex = 2;
            this.pnlFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormLoader_Paint);
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDashBoard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDashBoard.Location = new System.Drawing.Point(20, 15);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(1660, 931);
            this.pnlDashBoard.TabIndex = 3;
            // 
            // pnlTrend
            // 
            this.pnlTrend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTrend.BackColor = System.Drawing.Color.IndianRed;
            this.pnlTrend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlTrend.Location = new System.Drawing.Point(20, 15);
            this.pnlTrend.Name = "pnlTrend";
            this.pnlTrend.Size = new System.Drawing.Size(1660, 931);
            this.pnlTrend.TabIndex = 4;
            // 
            // PnlDisplay
            // 
            this.PnlDisplay.Controls.Add(this.pnlTrend);
            this.PnlDisplay.Controls.Add(this.pnlDashBoard);
            this.PnlDisplay.Controls.Add(this.pnlFormLoader);
            this.PnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDisplay.Location = new System.Drawing.Point(208, 80);
            this.PnlDisplay.Name = "PnlDisplay";
            this.PnlDisplay.Size = new System.Drawing.Size(1696, 961);
            this.PnlDisplay.TabIndex = 4;
            this.PnlDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlDisplay_Paint);
            // 
            // pnlLine2
            // 
            this.pnlLine2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLine2.Location = new System.Drawing.Point(0, 77);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(1712, 1);
            this.pnlLine2.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.PnlDisplay);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PnlDisplay.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlline;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlDashBoard;
        private System.Windows.Forms.Panel pnlTrend;
        private System.Windows.Forms.Panel PnlDisplay;
        private System.Windows.Forms.Panel pnlLine2;
    }
}

