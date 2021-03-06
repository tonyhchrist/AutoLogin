﻿namespace AutoLogin
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
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.rdo32bit = new System.Windows.Forms.RadioButton();
            this.rdo64bit = new System.Windows.Forms.RadioButton();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLaunchAll = new System.Windows.Forms.Button();
            this.tskIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tskMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tskMenuLaunch = new System.Windows.Forms.ToolStripMenuItem();
            this.launchAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tskMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAccounts
            // 
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.Location = new System.Drawing.Point(10, 10);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAccounts.Size = new System.Drawing.Size(180, 108);
            this.lstAccounts.TabIndex = 0;
            this.lstAccounts.SelectedIndexChanged += new System.EventHandler(this.lstAccounts_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(198, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(198, 68);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(198, 39);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.Location = new System.Drawing.Point(67, 126);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(123, 40);
            this.btnLaunch.TabIndex = 6;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // rdo32bit
            // 
            this.rdo32bit.AutoSize = true;
            this.rdo32bit.Location = new System.Drawing.Point(10, 126);
            this.rdo32bit.Name = "rdo32bit";
            this.rdo32bit.Size = new System.Drawing.Size(51, 17);
            this.rdo32bit.TabIndex = 4;
            this.rdo32bit.Text = "32 bit";
            this.rdo32bit.UseVisualStyleBackColor = true;
            this.rdo32bit.CheckedChanged += new System.EventHandler(this.rdo32bit_CheckedChanged);
            // 
            // rdo64bit
            // 
            this.rdo64bit.AutoSize = true;
            this.rdo64bit.Location = new System.Drawing.Point(10, 149);
            this.rdo64bit.Name = "rdo64bit";
            this.rdo64bit.Size = new System.Drawing.Size(51, 17);
            this.rdo64bit.TabIndex = 5;
            this.rdo64bit.Text = "64 bit";
            this.rdo64bit.UseVisualStyleBackColor = true;
            this.rdo64bit.CheckedChanged += new System.EventHandler(this.rdo64bit_CheckedChanged);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(198, 97);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLaunchAll
            // 
            this.btnLaunchAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchAll.Location = new System.Drawing.Point(198, 126);
            this.btnLaunchAll.Name = "btnLaunchAll";
            this.btnLaunchAll.Size = new System.Drawing.Size(75, 40);
            this.btnLaunchAll.TabIndex = 8;
            this.btnLaunchAll.Text = "Launch All";
            this.btnLaunchAll.UseVisualStyleBackColor = true;
            this.btnLaunchAll.Click += new System.EventHandler(this.btnLaunchAll_Click);
            // 
            // tskIcon
            // 
            this.tskIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tskIcon.BalloonTipText = "Double click to open";
            this.tskIcon.BalloonTipTitle = "AutoLogin is now hidden";
            this.tskIcon.ContextMenuStrip = this.tskMenu;
            this.tskIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("tskIcon.Icon")));
            this.tskIcon.Text = "AutoLogin";
            this.tskIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tskIcon_MouseDoubleClick);
            // 
            // tskMenu
            // 
            this.tskMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tskMenuLaunch,
            this.launchAllToolStripMenuItem,
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.tskMenu.Name = "tskMenu";
            this.tskMenu.Size = new System.Drawing.Size(131, 92);
            // 
            // tskMenuLaunch
            // 
            this.tskMenuLaunch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsToolStripMenuItem});
            this.tskMenuLaunch.Name = "tskMenuLaunch";
            this.tskMenuLaunch.Size = new System.Drawing.Size(130, 22);
            this.tskMenuLaunch.Text = "Launch";
            // 
            // launchAllToolStripMenuItem
            // 
            this.launchAllToolStripMenuItem.Name = "launchAllToolStripMenuItem";
            this.launchAllToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.launchAllToolStripMenuItem.Text = "Launch All";
            this.launchAllToolStripMenuItem.Click += new System.EventHandler(this.launchAllToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnLaunch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 173);
            this.Controls.Add(this.btnLaunchAll);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lstAccounts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.rdo64bit);
            this.Controls.Add(this.rdo32bit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tskMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.RadioButton rdo32bit;
        private System.Windows.Forms.RadioButton rdo64bit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLaunchAll;
        private System.Windows.Forms.NotifyIcon tskIcon;
        private System.Windows.Forms.ContextMenuStrip tskMenu;
        private System.Windows.Forms.ToolStripMenuItem tskMenuLaunch;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

