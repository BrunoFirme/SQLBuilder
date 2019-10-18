using System;
using System.Runtime.InteropServices;

namespace Project_SQLBuilder
{
    partial class FormMain
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

        #region Screen move util
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Taskbar1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LblOrigDB = new System.Windows.Forms.Label();
            this.txtOrigDB = new System.Windows.Forms.TextBox();
            this.txtOrigSVR = new System.Windows.Forms.TextBox();
            this.lblOrigSVR = new System.Windows.Forms.Label();
            this.txtOrigPass = new System.Windows.Forms.TextBox();
            this.lblOrigPass = new System.Windows.Forms.Label();
            this.lblDiv = new System.Windows.Forms.Label();
            this.txtDestPass = new System.Windows.Forms.TextBox();
            this.lblDestPass = new System.Windows.Forms.Label();
            this.txtDestSVR = new System.Windows.Forms.TextBox();
            this.lblDestSVR = new System.Windows.Forms.Label();
            this.txtDestDB = new System.Windows.Forms.TextBox();
            this.lblDestDB = new System.Windows.Forms.Label();
            this.lblConnectOrigin = new System.Windows.Forms.Label();
            this.lblConnectDestiny = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.Taskbar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelHeader.Controls.Add(this.lblProgramTitle);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1177, 31);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // lblProgramTitle
            // 
            this.lblProgramTitle.AutoSize = true;
            this.lblProgramTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProgramTitle.Location = new System.Drawing.Point(12, 9);
            this.lblProgramTitle.Name = "lblProgramTitle";
            this.lblProgramTitle.Size = new System.Drawing.Size(172, 13);
            this.lblProgramTitle.TabIndex = 2;
            this.lblProgramTitle.Text = "SQL Script Builder (by Bruno Firme)";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1110, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 23);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1145, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Taskbar1
            // 
            this.Taskbar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Taskbar1.AutoSize = false;
            this.Taskbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Taskbar1.Dock = System.Windows.Forms.DockStyle.None;
            this.Taskbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.cONFIGToolStripMenuItem,
            this.toolStripMenuItem1});
            this.Taskbar1.Location = new System.Drawing.Point(0, 36);
            this.Taskbar1.Name = "Taskbar1";
            this.Taskbar1.Size = new System.Drawing.Size(1174, 24);
            this.Taskbar1.TabIndex = 1;
            this.Taskbar1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.newToolStripMenuItem.Text = "NEW";
            // 
            // cONFIGToolStripMenuItem
            // 
            this.cONFIGToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cONFIGToolStripMenuItem.Name = "cONFIGToolStripMenuItem";
            this.cONFIGToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cONFIGToolStripMenuItem.Text = "CONFIG";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // LblOrigDB
            // 
            this.LblOrigDB.BackColor = System.Drawing.Color.Transparent;
            this.LblOrigDB.ForeColor = System.Drawing.Color.White;
            this.LblOrigDB.Location = new System.Drawing.Point(126, 34);
            this.LblOrigDB.Name = "LblOrigDB";
            this.LblOrigDB.Size = new System.Drawing.Size(97, 24);
            this.LblOrigDB.TabIndex = 2;
            this.LblOrigDB.Text = "Database Origem:";
            this.LblOrigDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOrigDB
            // 
            this.txtOrigDB.BackColor = System.Drawing.Color.Gray;
            this.txtOrigDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigDB.Location = new System.Drawing.Point(218, 38);
            this.txtOrigDB.Name = "txtOrigDB";
            this.txtOrigDB.Size = new System.Drawing.Size(100, 20);
            this.txtOrigDB.TabIndex = 3;
            // 
            // txtOrigSVR
            // 
            this.txtOrigSVR.BackColor = System.Drawing.Color.Gray;
            this.txtOrigSVR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigSVR.Location = new System.Drawing.Point(357, 38);
            this.txtOrigSVR.Name = "txtOrigSVR";
            this.txtOrigSVR.Size = new System.Drawing.Size(100, 20);
            this.txtOrigSVR.TabIndex = 5;
            // 
            // lblOrigSVR
            // 
            this.lblOrigSVR.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigSVR.ForeColor = System.Drawing.Color.White;
            this.lblOrigSVR.Location = new System.Drawing.Point(319, 34);
            this.lblOrigSVR.Name = "lblOrigSVR";
            this.lblOrigSVR.Size = new System.Drawing.Size(42, 24);
            this.lblOrigSVR.TabIndex = 4;
            this.lblOrigSVR.Text = "Server:";
            this.lblOrigSVR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOrigPass
            // 
            this.txtOrigPass.BackColor = System.Drawing.Color.Gray;
            this.txtOrigPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigPass.Location = new System.Drawing.Point(488, 38);
            this.txtOrigPass.Name = "txtOrigPass";
            this.txtOrigPass.Size = new System.Drawing.Size(100, 20);
            this.txtOrigPass.TabIndex = 7;
            // 
            // lblOrigPass
            // 
            this.lblOrigPass.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigPass.ForeColor = System.Drawing.Color.White;
            this.lblOrigPass.Location = new System.Drawing.Point(456, 34);
            this.lblOrigPass.Name = "lblOrigPass";
            this.lblOrigPass.Size = new System.Drawing.Size(36, 24);
            this.lblOrigPass.TabIndex = 6;
            this.lblOrigPass.Text = "Pass:";
            this.lblOrigPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiv
            // 
            this.lblDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiv.ForeColor = System.Drawing.Color.White;
            this.lblDiv.Location = new System.Drawing.Point(633, 37);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(38, 32);
            this.lblDiv.TabIndex = 8;
            this.lblDiv.Text = "|";
            // 
            // txtDestPass
            // 
            this.txtDestPass.BackColor = System.Drawing.Color.Gray;
            this.txtDestPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestPass.Location = new System.Drawing.Point(1006, 38);
            this.txtDestPass.Name = "txtDestPass";
            this.txtDestPass.Size = new System.Drawing.Size(100, 20);
            this.txtDestPass.TabIndex = 14;
            // 
            // lblDestPass
            // 
            this.lblDestPass.BackColor = System.Drawing.Color.Transparent;
            this.lblDestPass.ForeColor = System.Drawing.Color.White;
            this.lblDestPass.Location = new System.Drawing.Point(974, 34);
            this.lblDestPass.Name = "lblDestPass";
            this.lblDestPass.Size = new System.Drawing.Size(36, 24);
            this.lblDestPass.TabIndex = 13;
            this.lblDestPass.Text = "Pass:";
            this.lblDestPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDestSVR
            // 
            this.txtDestSVR.BackColor = System.Drawing.Color.Gray;
            this.txtDestSVR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestSVR.Location = new System.Drawing.Point(875, 38);
            this.txtDestSVR.Name = "txtDestSVR";
            this.txtDestSVR.Size = new System.Drawing.Size(100, 20);
            this.txtDestSVR.TabIndex = 12;
            // 
            // lblDestSVR
            // 
            this.lblDestSVR.BackColor = System.Drawing.Color.Transparent;
            this.lblDestSVR.ForeColor = System.Drawing.Color.White;
            this.lblDestSVR.Location = new System.Drawing.Point(837, 34);
            this.lblDestSVR.Name = "lblDestSVR";
            this.lblDestSVR.Size = new System.Drawing.Size(42, 24);
            this.lblDestSVR.TabIndex = 11;
            this.lblDestSVR.Text = "Server:";
            this.lblDestSVR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDestDB
            // 
            this.txtDestDB.BackColor = System.Drawing.Color.Gray;
            this.txtDestDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestDB.Location = new System.Drawing.Point(736, 38);
            this.txtDestDB.Name = "txtDestDB";
            this.txtDestDB.Size = new System.Drawing.Size(100, 20);
            this.txtDestDB.TabIndex = 10;
            // 
            // lblDestDB
            // 
            this.lblDestDB.BackColor = System.Drawing.Color.Transparent;
            this.lblDestDB.ForeColor = System.Drawing.Color.White;
            this.lblDestDB.Location = new System.Drawing.Point(644, 34);
            this.lblDestDB.Name = "lblDestDB";
            this.lblDestDB.Size = new System.Drawing.Size(97, 24);
            this.lblDestDB.TabIndex = 9;
            this.lblDestDB.Text = "Database Origem:";
            this.lblDestDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConnectOrigin
            // 
            this.lblConnectOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnectOrigin.ForeColor = System.Drawing.Color.Transparent;
            this.lblConnectOrigin.Image = ((System.Drawing.Image)(resources.GetObject("lblConnectOrigin.Image")));
            this.lblConnectOrigin.Location = new System.Drawing.Point(598, 37);
            this.lblConnectOrigin.Name = "lblConnectOrigin";
            this.lblConnectOrigin.Size = new System.Drawing.Size(29, 23);
            this.lblConnectOrigin.TabIndex = 15;
            this.lblConnectOrigin.Click += new System.EventHandler(this.lblConnectOrigin_Click);
            // 
            // lblConnectDestiny
            // 
            this.lblConnectDestiny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnectDestiny.ForeColor = System.Drawing.Color.Transparent;
            this.lblConnectDestiny.Image = ((System.Drawing.Image)(resources.GetObject("lblConnectDestiny.Image")));
            this.lblConnectDestiny.Location = new System.Drawing.Point(1112, 37);
            this.lblConnectDestiny.Name = "lblConnectDestiny";
            this.lblConnectDestiny.Size = new System.Drawing.Size(29, 23);
            this.lblConnectDestiny.TabIndex = 16;
            this.lblConnectDestiny.Click += new System.EventHandler(this.lblConnectDestiny_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1177, 706);
            this.Controls.Add(this.lblConnectDestiny);
            this.Controls.Add(this.lblConnectOrigin);
            this.Controls.Add(this.txtDestPass);
            this.Controls.Add(this.lblDestPass);
            this.Controls.Add(this.txtDestSVR);
            this.Controls.Add(this.lblDestSVR);
            this.Controls.Add(this.txtDestDB);
            this.Controls.Add(this.lblDestDB);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.txtOrigPass);
            this.Controls.Add(this.lblOrigPass);
            this.Controls.Add(this.txtOrigSVR);
            this.Controls.Add(this.lblOrigSVR);
            this.Controls.Add(this.txtOrigDB);
            this.Controls.Add(this.LblOrigDB);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.Taskbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.Taskbar1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLBuilder";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.Taskbar1.ResumeLayout(false);
            this.Taskbar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblProgramTitle;
        private System.Windows.Forms.MenuStrip Taskbar1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label LblOrigDB;
        private System.Windows.Forms.TextBox txtOrigDB;
        private System.Windows.Forms.TextBox txtOrigSVR;
        private System.Windows.Forms.Label lblOrigSVR;
        private System.Windows.Forms.TextBox txtOrigPass;
        private System.Windows.Forms.Label lblOrigPass;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.TextBox txtDestPass;
        private System.Windows.Forms.Label lblDestPass;
        private System.Windows.Forms.TextBox txtDestSVR;
        private System.Windows.Forms.Label lblDestSVR;
        private System.Windows.Forms.TextBox txtDestDB;
        private System.Windows.Forms.Label lblDestDB;
        private System.Windows.Forms.Label lblConnectOrigin;
        private System.Windows.Forms.Label lblConnectDestiny;

    }
}

