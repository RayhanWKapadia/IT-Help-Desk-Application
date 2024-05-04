﻿namespace WinFormsApp2
{
    partial class frmReportManagerDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportManagerDash));
            listBox1 = new ListBox();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblUsername = new Label();
            btnHome = new Button();
            btnRefresh = new Button();
            cbxIncludeClosed = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Microsoft Tai Le", 14F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(59, 91);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(682, 301);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.MouseDown += listBox1_MouseDown;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(663, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(125, 36);
            btnLogout.TabIndex = 20;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-501, -60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(713, 671);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Microsoft Tai Le", 27F);
            lblTitle.Location = new Point(59, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 45);
            lblTitle.TabIndex = 22;
            lblTitle.Text = "All Tickets";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(59, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(53, 21);
            lblUsername.TabIndex = 26;
            lblUsername.Text = "Hello, ";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.IndianRed;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(532, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(125, 36);
            btnHome.TabIndex = 27;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.IndianRed;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(616, 91);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(125, 36);
            btnRefresh.TabIndex = 28;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cbxIncludeClosed
            // 
            cbxIncludeClosed.AutoSize = true;
            cbxIncludeClosed.Font = new Font("Microsoft Tai Le", 14F);
            cbxIncludeClosed.Location = new Point(59, 398);
            cbxIncludeClosed.Name = "cbxIncludeClosed";
            cbxIncludeClosed.Size = new Size(215, 27);
            cbxIncludeClosed.TabIndex = 29;
            cbxIncludeClosed.Text = "Include Closed Tickets";
            cbxIncludeClosed.UseVisualStyleBackColor = true;
            cbxIncludeClosed.CheckedChanged += cbxIncludeClosed_CheckedChanged;
            // 
            // frmReportManagerDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxIncludeClosed);
            Controls.Add(btnRefresh);
            Controls.Add(btnHome);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Controls.Add(btnLogout);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReportManagerDash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report Manager Dashboard";
            FormClosing += ReportMangerDash_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblUsername;
        private Button btnHome;
        private Button btnRefresh;
        private CheckBox cbxIncludeClosed;
    }
}