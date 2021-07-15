namespace AndroidAppUninstaller.Forms
{
    partial class uxMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxMain));
            this.uxPanelLeft = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.uxListBoxStatus = new System.Windows.Forms.ListBox();
            this.uxButtonAbout = new System.Windows.Forms.Button();
            this.uxPanelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uxButtonClose = new System.Windows.Forms.Button();
            this.uxButtonMinimize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxComboBox = new System.Windows.Forms.ComboBox();
            this.uxTextBoxSearch = new System.Windows.Forms.TextBox();
            this.uxCheckedListBoxApp = new System.Windows.Forms.CheckedListBox();
            this.uxCheckBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.uxButtonUninstall = new System.Windows.Forms.Button();
            this.uxPanelLeft.SuspendLayout();
            this.uxPanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxPanelLeft
            // 
            this.uxPanelLeft.BackColor = System.Drawing.Color.Black;
            this.uxPanelLeft.Controls.Add(this.label4);
            this.uxPanelLeft.Controls.Add(this.uxListBoxStatus);
            this.uxPanelLeft.Controls.Add(this.uxButtonAbout);
            this.uxPanelLeft.Controls.Add(this.uxPanelLogo);
            this.uxPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.uxPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.uxPanelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.uxPanelLeft.Name = "uxPanelLeft";
            this.uxPanelLeft.Size = new System.Drawing.Size(235, 516);
            this.uxPanelLeft.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(18, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status:";
            // 
            // uxListBoxStatus
            // 
            this.uxListBoxStatus.BackColor = System.Drawing.Color.Black;
            this.uxListBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxListBoxStatus.Font = new System.Drawing.Font("Lucida Console", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxListBoxStatus.ForeColor = System.Drawing.Color.Silver;
            this.uxListBoxStatus.FormattingEnabled = true;
            this.uxListBoxStatus.ItemHeight = 9;
            this.uxListBoxStatus.Location = new System.Drawing.Point(18, 211);
            this.uxListBoxStatus.Name = "uxListBoxStatus";
            this.uxListBoxStatus.Size = new System.Drawing.Size(197, 245);
            this.uxListBoxStatus.TabIndex = 3;
            // 
            // uxButtonAbout
            // 
            this.uxButtonAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uxButtonAbout.FlatAppearance.BorderSize = 0;
            this.uxButtonAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uxButtonAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.uxButtonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxButtonAbout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonAbout.ForeColor = System.Drawing.Color.DodgerBlue;
            this.uxButtonAbout.Location = new System.Drawing.Point(0, 474);
            this.uxButtonAbout.Name = "uxButtonAbout";
            this.uxButtonAbout.Size = new System.Drawing.Size(235, 42);
            this.uxButtonAbout.TabIndex = 2;
            this.uxButtonAbout.Text = "About Application";
            this.uxButtonAbout.UseVisualStyleBackColor = true;
            this.uxButtonAbout.Click += new System.EventHandler(this.uxButtonAbout_Click);
            // 
            // uxPanelLogo
            // 
            this.uxPanelLogo.Controls.Add(this.label1);
            this.uxPanelLogo.Controls.Add(this.pictureBox1);
            this.uxPanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxPanelLogo.Location = new System.Drawing.Point(0, 0);
            this.uxPanelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.uxPanelLogo.Name = "uxPanelLogo";
            this.uxPanelLogo.Size = new System.Drawing.Size(235, 177);
            this.uxPanelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(38, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Android App Uninstaller";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AndroidAppUninstaller.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(18, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uxButtonClose
            // 
            this.uxButtonClose.FlatAppearance.BorderSize = 0;
            this.uxButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uxButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.uxButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxButtonClose.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonClose.ForeColor = System.Drawing.Color.DodgerBlue;
            this.uxButtonClose.Location = new System.Drawing.Point(568, 0);
            this.uxButtonClose.Name = "uxButtonClose";
            this.uxButtonClose.Size = new System.Drawing.Size(36, 24);
            this.uxButtonClose.TabIndex = 33;
            this.uxButtonClose.Text = "X";
            this.uxButtonClose.UseVisualStyleBackColor = true;
            this.uxButtonClose.Click += new System.EventHandler(this.uxButtonClose_Click);
            // 
            // uxButtonMinimize
            // 
            this.uxButtonMinimize.FlatAppearance.BorderSize = 0;
            this.uxButtonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uxButtonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.uxButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxButtonMinimize.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonMinimize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.uxButtonMinimize.Location = new System.Drawing.Point(526, 0);
            this.uxButtonMinimize.Name = "uxButtonMinimize";
            this.uxButtonMinimize.Size = new System.Drawing.Size(36, 24);
            this.uxButtonMinimize.TabIndex = 34;
            this.uxButtonMinimize.Text = "-";
            this.uxButtonMinimize.UseVisualStyleBackColor = true;
            this.uxButtonMinimize.Click += new System.EventHandler(this.uxButtonMinimize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(256, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(256, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Select App Type:";
            // 
            // uxComboBox
            // 
            this.uxComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.uxComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uxComboBox.ForeColor = System.Drawing.Color.Silver;
            this.uxComboBox.FormattingEnabled = true;
            this.uxComboBox.Items.AddRange(new object[] {
            "User App",
            "System App"});
            this.uxComboBox.Location = new System.Drawing.Point(259, 96);
            this.uxComboBox.MaxDropDownItems = 2;
            this.uxComboBox.Name = "uxComboBox";
            this.uxComboBox.Size = new System.Drawing.Size(339, 24);
            this.uxComboBox.TabIndex = 37;
            this.uxComboBox.Text = "Installed App";
            this.uxComboBox.SelectedIndexChanged += new System.EventHandler(this.uxComboBox_SelectedIndexChanged);
            // 
            // uxTextBoxSearch
            // 
            this.uxTextBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.uxTextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxTextBoxSearch.ForeColor = System.Drawing.Color.Silver;
            this.uxTextBoxSearch.Location = new System.Drawing.Point(309, 31);
            this.uxTextBoxSearch.Name = "uxTextBoxSearch";
            this.uxTextBoxSearch.Size = new System.Drawing.Size(289, 22);
            this.uxTextBoxSearch.TabIndex = 38;
            this.uxTextBoxSearch.TextChanged += new System.EventHandler(this.uxTextBoxSearch_TextChanged);
            // 
            // uxCheckedListBoxApp
            // 
            this.uxCheckedListBoxApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.uxCheckedListBoxApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxCheckedListBoxApp.ForeColor = System.Drawing.Color.White;
            this.uxCheckedListBoxApp.FormattingEnabled = true;
            this.uxCheckedListBoxApp.Location = new System.Drawing.Point(259, 137);
            this.uxCheckedListBoxApp.Name = "uxCheckedListBoxApp";
            this.uxCheckedListBoxApp.Size = new System.Drawing.Size(339, 274);
            this.uxCheckedListBoxApp.Sorted = true;
            this.uxCheckedListBoxApp.TabIndex = 39;
            // 
            // uxCheckBoxSelectAll
            // 
            this.uxCheckBoxSelectAll.AutoSize = true;
            this.uxCheckBoxSelectAll.ForeColor = System.Drawing.Color.DodgerBlue;
            this.uxCheckBoxSelectAll.Location = new System.Drawing.Point(259, 417);
            this.uxCheckBoxSelectAll.Name = "uxCheckBoxSelectAll";
            this.uxCheckBoxSelectAll.Size = new System.Drawing.Size(93, 20);
            this.uxCheckBoxSelectAll.TabIndex = 41;
            this.uxCheckBoxSelectAll.Text = "Select All";
            this.uxCheckBoxSelectAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uxCheckBoxSelectAll.CheckedChanged += new System.EventHandler(this.uxCheckBoxSelectAll_CheckedChanged);
            // 
            // uxButtonUninstall
            // 
            this.uxButtonUninstall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uxButtonUninstall.FlatAppearance.BorderSize = 0;
            this.uxButtonUninstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uxButtonUninstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.uxButtonUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxButtonUninstall.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonUninstall.ForeColor = System.Drawing.Color.DodgerBlue;
            this.uxButtonUninstall.Location = new System.Drawing.Point(235, 492);
            this.uxButtonUninstall.Name = "uxButtonUninstall";
            this.uxButtonUninstall.Size = new System.Drawing.Size(375, 24);
            this.uxButtonUninstall.TabIndex = 43;
            this.uxButtonUninstall.Text = "Uninstall App";
            this.uxButtonUninstall.UseVisualStyleBackColor = true;
            this.uxButtonUninstall.Click += new System.EventHandler(this.uxButtonUninstall_Click);
            // 
            // uxMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(610, 516);
            this.Controls.Add(this.uxButtonUninstall);
            this.Controls.Add(this.uxCheckBoxSelectAll);
            this.Controls.Add(this.uxCheckedListBoxApp);
            this.Controls.Add(this.uxTextBoxSearch);
            this.Controls.Add(this.uxComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxButtonMinimize);
            this.Controls.Add(this.uxButtonClose);
            this.Controls.Add(this.uxPanelLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uxMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Android App Uninstaller";
            this.Load += new System.EventHandler(this.uxMain_Load);
            this.Shown += new System.EventHandler(this.uxMain_Shown);
            this.uxPanelLeft.ResumeLayout(false);
            this.uxPanelLeft.PerformLayout();
            this.uxPanelLogo.ResumeLayout(false);
            this.uxPanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel uxPanelLeft;
        private System.Windows.Forms.Panel uxPanelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button uxButtonAbout;
        private System.Windows.Forms.Button uxButtonClose;
        private System.Windows.Forms.Button uxButtonMinimize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox uxComboBox;
        private System.Windows.Forms.TextBox uxTextBoxSearch;
        private System.Windows.Forms.CheckedListBox uxCheckedListBoxApp;
        private System.Windows.Forms.CheckBox uxCheckBoxSelectAll;
        private System.Windows.Forms.Button uxButtonUninstall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox uxListBoxStatus;
    }
}