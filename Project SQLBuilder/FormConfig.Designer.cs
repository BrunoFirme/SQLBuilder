using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Project_SQLBuilder
{
    partial class FormConfig
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

        #region Screen move and list editing util
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblOrigPass = new System.Windows.Forms.Label();
            this.LblOrigDB = new System.Windows.Forms.Label();
            this.txtSVR = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.lblOrigSVR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelHeader.Controls.Add(this.lblProgramTitle);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(386, 31);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // lblProgramTitle
            // 
            this.lblProgramTitle.AutoSize = true;
            this.lblProgramTitle.ForeColor = System.Drawing.Color.White;
            this.lblProgramTitle.Location = new System.Drawing.Point(12, 9);
            this.lblProgramTitle.Name = "lblProgramTitle";
            this.lblProgramTitle.Size = new System.Drawing.Size(75, 13);
            this.lblProgramTitle.TabIndex = 2;
            this.lblProgramTitle.Text = "Configurações";
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
            this.btnClose.Location = new System.Drawing.Point(354, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Gray;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Location = new System.Drawing.Point(74, 211);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 13;
            // 
            // lblOrigPass
            // 
            this.lblOrigPass.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigPass.ForeColor = System.Drawing.Color.White;
            this.lblOrigPass.Location = new System.Drawing.Point(32, 211);
            this.lblOrigPass.Name = "lblOrigPass";
            this.lblOrigPass.Size = new System.Drawing.Size(36, 24);
            this.lblOrigPass.TabIndex = 12;
            this.lblOrigPass.Text = "Pass:";
            this.lblOrigPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblOrigDB
            // 
            this.LblOrigDB.BackColor = System.Drawing.Color.Transparent;
            this.LblOrigDB.ForeColor = System.Drawing.Color.White;
            this.LblOrigDB.Location = new System.Drawing.Point(12, 109);
            this.LblOrigDB.Name = "LblOrigDB";
            this.LblOrigDB.Size = new System.Drawing.Size(58, 24);
            this.LblOrigDB.TabIndex = 8;
            this.LblOrigDB.Text = "Database:";
            this.LblOrigDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSVR
            // 
            this.txtSVR.BackColor = System.Drawing.Color.Gray;
            this.txtSVR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSVR.Location = new System.Drawing.Point(74, 133);
            this.txtSVR.Name = "txtSVR";
            this.txtSVR.Size = new System.Drawing.Size(100, 20);
            this.txtSVR.TabIndex = 11;
            // 
            // txtDB
            // 
            this.txtDB.BackColor = System.Drawing.Color.Gray;
            this.txtDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDB.Location = new System.Drawing.Point(74, 107);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(100, 20);
            this.txtDB.TabIndex = 9;
            // 
            // lblOrigSVR
            // 
            this.lblOrigSVR.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigSVR.ForeColor = System.Drawing.Color.White;
            this.lblOrigSVR.Location = new System.Drawing.Point(26, 133);
            this.lblOrigSVR.Name = "lblOrigSVR";
            this.lblOrigSVR.Size = new System.Drawing.Size(42, 24);
            this.lblOrigSVR.TabIndex = 10;
            this.lblOrigSVR.Text = "Server:";
            this.lblOrigSVR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Banco de dados do programa";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Gray;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(74, 237);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Gray;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Location = new System.Drawing.Point(74, 185);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 19;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(15, 185);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 24);
            this.lblUser.TabIndex = 18;
            this.lblUser.Text = "Usuário:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.Gray;
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Location = new System.Drawing.Point(74, 159);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 17;
            // 
            // lblPort
            // 
            this.lblPort.BackColor = System.Drawing.Color.Transparent;
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Location = new System.Drawing.Point(26, 159);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(42, 24);
            this.lblPort.TabIndex = 16;
            this.lblPort.Text = "Port:";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(386, 338);
            this.ControlBox = false;
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblOrigPass);
            this.Controls.Add(this.LblOrigDB);
            this.Controls.Add(this.txtSVR);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.lblOrigSVR);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormConfig";
            this.TopMost = true;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblProgramTitle;
        private System.Windows.Forms.Button btnClose;
        private TextBox txtPass;
        private Label lblOrigPass;
        private Label LblOrigDB;
        private TextBox txtSVR;
        private TextBox txtDB;
        private Label lblOrigSVR;
        private Label label1;
        private Button btnConnect;
        private TextBox txtUser;
        private Label lblUser;
        private TextBox txtPort;
        private Label lblPort;
    }
}