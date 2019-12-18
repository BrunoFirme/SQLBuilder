namespace Project_SQLBuilder.Forms
{
    partial class DataBaseConnectionForm
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
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseConnectionForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txbOrigSchema = new System.Windows.Forms.TextBox();
            this.txbOrigPass = new System.Windows.Forms.TextBox();
            this.lblOrigSchema = new System.Windows.Forms.Label();
            this.txbOrigHost = new System.Windows.Forms.TextBox();
            this.txbOrigPort = new System.Windows.Forms.TextBox();
            this.lblOrigPort = new System.Windows.Forms.Label();
            this.txbOrigDatabase = new System.Windows.Forms.TextBox();
            this.txbOrigUser = new System.Windows.Forms.TextBox();
            this.lblOrigUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDestDbType = new System.Windows.Forms.ComboBox();
            this.cmbOrigDbType = new System.Windows.Forms.ComboBox();
            this.lblConnectDestiny = new System.Windows.Forms.Label();
            this.lblConnectOrigin = new System.Windows.Forms.Label();
            this.lblOrigPass = new System.Windows.Forms.Label();
            this.lblOrigDatabase = new System.Windows.Forms.Label();
            this.lblOrigHost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDestSchema = new System.Windows.Forms.TextBox();
            this.txbDestPass = new System.Windows.Forms.TextBox();
            this.lblDestSchema = new System.Windows.Forms.Label();
            this.txbDestHost = new System.Windows.Forms.TextBox();
            this.txbDestPort = new System.Windows.Forms.TextBox();
            this.lblDestPort = new System.Windows.Forms.Label();
            this.txbDestDatabase = new System.Windows.Forms.TextBox();
            this.txbDestUser = new System.Windows.Forms.TextBox();
            this.lblDestUser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDestPass = new System.Windows.Forms.Label();
            this.lblDestDatabase = new System.Windows.Forms.Label();
            this.lblDestHost = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.BackColor = System.Drawing.Color.MediumSeaGreen;
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(0, 147);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(277, 24);
            label8.TabIndex = 90;
            label8.Text = "              Destino";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelHeader.Controls.Add(this.label4);
            this.panelHeader.Controls.Add(this.lblProgramTitle);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(277, 31);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(0, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1177, 2);
            this.label4.TabIndex = 38;
            this.label4.Text = "label4";
            // 
            // lblProgramTitle
            // 
            this.lblProgramTitle.AutoSize = true;
            this.lblProgramTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProgramTitle.Location = new System.Drawing.Point(12, 9);
            this.lblProgramTitle.Name = "lblProgramTitle";
            this.lblProgramTitle.Size = new System.Drawing.Size(53, 13);
            this.lblProgramTitle.TabIndex = 2;
            this.lblProgramTitle.Text = "Conectar:";
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
            this.btnMinimize.Location = new System.Drawing.Point(210, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 23);
            this.btnMinimize.TabIndex = 17;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
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
            this.btnClose.Location = new System.Drawing.Point(245, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txbOrigSchema
            // 
            this.txbOrigSchema.BackColor = System.Drawing.Color.Gray;
            this.txbOrigSchema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOrigSchema.Location = new System.Drawing.Point(187, 90);
            this.txbOrigSchema.Name = "txbOrigSchema";
            this.txbOrigSchema.Size = new System.Drawing.Size(85, 20);
            this.txbOrigSchema.TabIndex = 5;
            // 
            // txbOrigPass
            // 
            this.txbOrigPass.BackColor = System.Drawing.Color.Gray;
            this.txbOrigPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOrigPass.Location = new System.Drawing.Point(187, 113);
            this.txbOrigPass.Name = "txbOrigPass";
            this.txbOrigPass.Size = new System.Drawing.Size(60, 20);
            this.txbOrigPass.TabIndex = 7;
            // 
            // lblOrigSchema
            // 
            this.lblOrigSchema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblOrigSchema.ForeColor = System.Drawing.Color.White;
            this.lblOrigSchema.Location = new System.Drawing.Point(140, 90);
            this.lblOrigSchema.Name = "lblOrigSchema";
            this.lblOrigSchema.Size = new System.Drawing.Size(51, 20);
            this.lblOrigSchema.TabIndex = 97;
            this.lblOrigSchema.Text = "Schema:";
            this.lblOrigSchema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbOrigHost
            // 
            this.txbOrigHost.BackColor = System.Drawing.Color.Gray;
            this.txbOrigHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOrigHost.Location = new System.Drawing.Point(44, 67);
            this.txbOrigHost.Name = "txbOrigHost";
            this.txbOrigHost.Size = new System.Drawing.Size(85, 20);
            this.txbOrigHost.TabIndex = 2;
            // 
            // txbOrigPort
            // 
            this.txbOrigPort.BackColor = System.Drawing.Color.Gray;
            this.txbOrigPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOrigPort.Location = new System.Drawing.Point(187, 67);
            this.txbOrigPort.Name = "txbOrigPort";
            this.txbOrigPort.Size = new System.Drawing.Size(60, 20);
            this.txbOrigPort.TabIndex = 3;
            // 
            // lblOrigPort
            // 
            this.lblOrigPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblOrigPort.ForeColor = System.Drawing.Color.White;
            this.lblOrigPort.Location = new System.Drawing.Point(158, 67);
            this.lblOrigPort.Name = "lblOrigPort";
            this.lblOrigPort.Size = new System.Drawing.Size(36, 20);
            this.lblOrigPort.TabIndex = 91;
            this.lblOrigPort.Text = "Port:";
            this.lblOrigPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbOrigDatabase
            // 
            this.txbOrigDatabase.BackColor = System.Drawing.Color.Gray;
            this.txbOrigDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOrigDatabase.Location = new System.Drawing.Point(44, 90);
            this.txbOrigDatabase.Name = "txbOrigDatabase";
            this.txbOrigDatabase.Size = new System.Drawing.Size(85, 20);
            this.txbOrigDatabase.TabIndex = 4;
            // 
            // txbOrigUser
            // 
            this.txbOrigUser.BackColor = System.Drawing.Color.Gray;
            this.txbOrigUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOrigUser.Location = new System.Drawing.Point(44, 113);
            this.txbOrigUser.Name = "txbOrigUser";
            this.txbOrigUser.Size = new System.Drawing.Size(85, 20);
            this.txbOrigUser.TabIndex = 6;
            // 
            // lblOrigUser
            // 
            this.lblOrigUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblOrigUser.ForeColor = System.Drawing.Color.White;
            this.lblOrigUser.Location = new System.Drawing.Point(0, 113);
            this.lblOrigUser.Name = "lblOrigUser";
            this.lblOrigUser.Size = new System.Drawing.Size(48, 20);
            this.lblOrigUser.TabIndex = 85;
            this.lblOrigUser.Text = "Usuário:";
            this.lblOrigUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(135, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 80);
            this.label5.TabIndex = 84;
            // 
            // cmbDestDbType
            // 
            this.cmbDestDbType.BackColor = System.Drawing.Color.Gray;
            this.cmbDestDbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDestDbType.ForeColor = System.Drawing.Color.Black;
            this.cmbDestDbType.FormattingEnabled = true;
            this.cmbDestDbType.Items.AddRange(new object[] {
            "Oracle",
            "Postgres"});
            this.cmbDestDbType.Location = new System.Drawing.Point(93, 149);
            this.cmbDestDbType.Name = "cmbDestDbType";
            this.cmbDestDbType.Size = new System.Drawing.Size(130, 21);
            this.cmbDestDbType.TabIndex = 9;
            this.cmbDestDbType.SelectedIndexChanged += new System.EventHandler(this.cmbDestDbType_SelectedIndexChanged);
            // 
            // cmbOrigDbType
            // 
            this.cmbOrigDbType.BackColor = System.Drawing.Color.Gray;
            this.cmbOrigDbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrigDbType.ForeColor = System.Drawing.Color.Black;
            this.cmbOrigDbType.FormattingEnabled = true;
            this.cmbOrigDbType.Items.AddRange(new object[] {
            "Oracle",
            "Postgres",
            "DBF"});
            this.cmbOrigDbType.Location = new System.Drawing.Point(93, 33);
            this.cmbOrigDbType.Name = "cmbOrigDbType";
            this.cmbOrigDbType.Size = new System.Drawing.Size(130, 21);
            this.cmbOrigDbType.TabIndex = 1;
            this.cmbOrigDbType.SelectedIndexChanged += new System.EventHandler(this.cmbOrigDbType_SelectedIndexChanged);
            // 
            // lblConnectDestiny
            // 
            this.lblConnectDestiny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnectDestiny.ForeColor = System.Drawing.Color.Transparent;
            this.lblConnectDestiny.Image = ((System.Drawing.Image)(resources.GetObject("lblConnectDestiny.Image")));
            this.lblConnectDestiny.Location = new System.Drawing.Point(229, 149);
            this.lblConnectDestiny.Name = "lblConnectDestiny";
            this.lblConnectDestiny.Size = new System.Drawing.Size(41, 20);
            this.lblConnectDestiny.TabIndex = 16;
            this.lblConnectDestiny.Click += new System.EventHandler(this.lblConnectDestiny_Click);
            // 
            // lblConnectOrigin
            // 
            this.lblConnectOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnectOrigin.ForeColor = System.Drawing.Color.Transparent;
            this.lblConnectOrigin.Image = ((System.Drawing.Image)(resources.GetObject("lblConnectOrigin.Image")));
            this.lblConnectOrigin.Location = new System.Drawing.Point(229, 33);
            this.lblConnectOrigin.Name = "lblConnectOrigin";
            this.lblConnectOrigin.Size = new System.Drawing.Size(41, 20);
            this.lblConnectOrigin.TabIndex = 8;
            this.lblConnectOrigin.Click += new System.EventHandler(this.lblConnectOrigin_Click);
            // 
            // lblOrigPass
            // 
            this.lblOrigPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblOrigPass.ForeColor = System.Drawing.Color.White;
            this.lblOrigPass.Location = new System.Drawing.Point(156, 113);
            this.lblOrigPass.Name = "lblOrigPass";
            this.lblOrigPass.Size = new System.Drawing.Size(36, 20);
            this.lblOrigPass.TabIndex = 72;
            this.lblOrigPass.Text = "Pass:";
            this.lblOrigPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrigDatabase
            // 
            this.lblOrigDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblOrigDatabase.ForeColor = System.Drawing.Color.White;
            this.lblOrigDatabase.Location = new System.Drawing.Point(3, 90);
            this.lblOrigDatabase.Name = "lblOrigDatabase";
            this.lblOrigDatabase.Size = new System.Drawing.Size(48, 20);
            this.lblOrigDatabase.TabIndex = 68;
            this.lblOrigDatabase.Text = "Banco:";
            this.lblOrigDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrigHost
            // 
            this.lblOrigHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblOrigHost.ForeColor = System.Drawing.Color.White;
            this.lblOrigHost.Location = new System.Drawing.Point(10, 67);
            this.lblOrigHost.Name = "lblOrigHost";
            this.lblOrigHost.Size = new System.Drawing.Size(42, 21);
            this.lblOrigHost.TabIndex = 70;
            this.lblOrigHost.Text = "Host:";
            this.lblOrigHost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 23);
            this.label7.TabIndex = 89;
            this.label7.Text = "              Origem";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbDestSchema
            // 
            this.txbDestSchema.BackColor = System.Drawing.Color.Gray;
            this.txbDestSchema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDestSchema.Location = new System.Drawing.Point(187, 206);
            this.txbDestSchema.Name = "txbDestSchema";
            this.txbDestSchema.Size = new System.Drawing.Size(85, 20);
            this.txbDestSchema.TabIndex = 13;
            // 
            // txbDestPass
            // 
            this.txbDestPass.BackColor = System.Drawing.Color.Gray;
            this.txbDestPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDestPass.Location = new System.Drawing.Point(187, 229);
            this.txbDestPass.Name = "txbDestPass";
            this.txbDestPass.Size = new System.Drawing.Size(60, 20);
            this.txbDestPass.TabIndex = 15;
            // 
            // lblDestSchema
            // 
            this.lblDestSchema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblDestSchema.ForeColor = System.Drawing.Color.White;
            this.lblDestSchema.Location = new System.Drawing.Point(140, 206);
            this.lblDestSchema.Name = "lblDestSchema";
            this.lblDestSchema.Size = new System.Drawing.Size(51, 20);
            this.lblDestSchema.TabIndex = 110;
            this.lblDestSchema.Text = "Schema:";
            this.lblDestSchema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbDestHost
            // 
            this.txbDestHost.BackColor = System.Drawing.Color.Gray;
            this.txbDestHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDestHost.Location = new System.Drawing.Point(44, 183);
            this.txbDestHost.Name = "txbDestHost";
            this.txbDestHost.Size = new System.Drawing.Size(85, 20);
            this.txbDestHost.TabIndex = 10;
            // 
            // txbDestPort
            // 
            this.txbDestPort.BackColor = System.Drawing.Color.Gray;
            this.txbDestPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDestPort.Location = new System.Drawing.Point(187, 183);
            this.txbDestPort.Name = "txbDestPort";
            this.txbDestPort.Size = new System.Drawing.Size(60, 20);
            this.txbDestPort.TabIndex = 11;
            // 
            // lblDestPort
            // 
            this.lblDestPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblDestPort.ForeColor = System.Drawing.Color.White;
            this.lblDestPort.Location = new System.Drawing.Point(158, 183);
            this.lblDestPort.Name = "lblDestPort";
            this.lblDestPort.Size = new System.Drawing.Size(36, 20);
            this.lblDestPort.TabIndex = 107;
            this.lblDestPort.Text = "Port:";
            this.lblDestPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbDestDatabase
            // 
            this.txbDestDatabase.BackColor = System.Drawing.Color.Gray;
            this.txbDestDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDestDatabase.Location = new System.Drawing.Point(44, 206);
            this.txbDestDatabase.Name = "txbDestDatabase";
            this.txbDestDatabase.Size = new System.Drawing.Size(85, 20);
            this.txbDestDatabase.TabIndex = 12;
            // 
            // txbDestUser
            // 
            this.txbDestUser.BackColor = System.Drawing.Color.Gray;
            this.txbDestUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDestUser.Location = new System.Drawing.Point(44, 229);
            this.txbDestUser.Name = "txbDestUser";
            this.txbDestUser.Size = new System.Drawing.Size(85, 20);
            this.txbDestUser.TabIndex = 14;
            // 
            // lblDestUser
            // 
            this.lblDestUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblDestUser.ForeColor = System.Drawing.Color.White;
            this.lblDestUser.Location = new System.Drawing.Point(0, 229);
            this.lblDestUser.Name = "lblDestUser";
            this.lblDestUser.Size = new System.Drawing.Size(48, 20);
            this.lblDestUser.TabIndex = 105;
            this.lblDestUser.Text = "Usuário:";
            this.lblDestUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(135, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 80);
            this.label6.TabIndex = 104;
            // 
            // lblDestPass
            // 
            this.lblDestPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblDestPass.ForeColor = System.Drawing.Color.White;
            this.lblDestPass.Location = new System.Drawing.Point(156, 229);
            this.lblDestPass.Name = "lblDestPass";
            this.lblDestPass.Size = new System.Drawing.Size(36, 20);
            this.lblDestPass.TabIndex = 102;
            this.lblDestPass.Text = "Pass:";
            this.lblDestPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestDatabase
            // 
            this.lblDestDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblDestDatabase.ForeColor = System.Drawing.Color.White;
            this.lblDestDatabase.Location = new System.Drawing.Point(3, 206);
            this.lblDestDatabase.Name = "lblDestDatabase";
            this.lblDestDatabase.Size = new System.Drawing.Size(48, 20);
            this.lblDestDatabase.TabIndex = 98;
            this.lblDestDatabase.Text = "Banco:";
            this.lblDestDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestHost
            // 
            this.lblDestHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblDestHost.ForeColor = System.Drawing.Color.White;
            this.lblDestHost.Location = new System.Drawing.Point(10, 183);
            this.lblDestHost.Name = "lblDestHost";
            this.lblDestHost.Size = new System.Drawing.Size(42, 21);
            this.lblDestHost.TabIndex = 100;
            this.lblDestHost.Text = "Host:";
            this.lblDestHost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataBaseConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(277, 264);
            this.Controls.Add(this.txbDestSchema);
            this.Controls.Add(this.txbDestPass);
            this.Controls.Add(this.lblDestSchema);
            this.Controls.Add(this.txbDestHost);
            this.Controls.Add(this.txbDestPort);
            this.Controls.Add(this.lblDestPort);
            this.Controls.Add(this.txbDestDatabase);
            this.Controls.Add(this.txbDestUser);
            this.Controls.Add(this.lblDestUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDestPass);
            this.Controls.Add(this.lblDestDatabase);
            this.Controls.Add(this.lblDestHost);
            this.Controls.Add(this.txbOrigSchema);
            this.Controls.Add(this.txbOrigPass);
            this.Controls.Add(this.lblOrigSchema);
            this.Controls.Add(this.txbOrigHost);
            this.Controls.Add(this.txbOrigPort);
            this.Controls.Add(this.lblOrigPort);
            this.Controls.Add(this.txbOrigDatabase);
            this.Controls.Add(this.txbOrigUser);
            this.Controls.Add(this.lblOrigUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDestDbType);
            this.Controls.Add(this.cmbOrigDbType);
            this.Controls.Add(this.lblConnectDestiny);
            this.Controls.Add(this.lblConnectOrigin);
            this.Controls.Add(this.lblOrigPass);
            this.Controls.Add(this.lblOrigDatabase);
            this.Controls.Add(this.lblOrigHost);
            this.Controls.Add(this.label7);
            this.Controls.Add(label8);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "DataBaseConnectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBaseConnectionForm";
            this.TopMost = true;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProgramTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txbOrigSchema;
        private System.Windows.Forms.TextBox txbOrigPass;
        private System.Windows.Forms.Label lblOrigSchema;
        private System.Windows.Forms.TextBox txbOrigHost;
        private System.Windows.Forms.TextBox txbOrigPort;
        private System.Windows.Forms.Label lblOrigPort;
        private System.Windows.Forms.TextBox txbOrigDatabase;
        private System.Windows.Forms.TextBox txbOrigUser;
        private System.Windows.Forms.Label lblOrigUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDestDbType;
        private System.Windows.Forms.ComboBox cmbOrigDbType;
        private System.Windows.Forms.Label lblConnectDestiny;
        private System.Windows.Forms.Label lblConnectOrigin;
        private System.Windows.Forms.Label lblOrigPass;
        private System.Windows.Forms.Label lblOrigDatabase;
        private System.Windows.Forms.Label lblOrigHost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDestSchema;
        private System.Windows.Forms.TextBox txbDestPass;
        private System.Windows.Forms.Label lblDestSchema;
        private System.Windows.Forms.TextBox txbDestHost;
        private System.Windows.Forms.TextBox txbDestPort;
        private System.Windows.Forms.Label lblDestPort;
        private System.Windows.Forms.TextBox txbDestDatabase;
        private System.Windows.Forms.TextBox txbDestUser;
        private System.Windows.Forms.Label lblDestUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDestPass;
        private System.Windows.Forms.Label lblDestDatabase;
        private System.Windows.Forms.Label lblDestHost;
    }
}