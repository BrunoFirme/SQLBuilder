using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Taskbar1 = new System.Windows.Forms.MenuStrip();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiConfig = new System.Windows.Forms.ToolStripMenuItem();
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
            this.clbOrigTables = new System.Windows.Forms.CheckedListBox();
            this.lblExploreTablesOrig = new System.Windows.Forms.Label();
            this.lblExploreColumnsOrig = new System.Windows.Forms.Label();
            this.lblExploreTablesDest = new System.Windows.Forms.Label();
            this.dgvOrigColumns = new System.Windows.Forms.DataGridView();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.obvInsertTables = new BrightIdeasSoftware.ObjectListView();
            this.lbOrderInsert = new System.Windows.Forms.Label();
            this.clbDestTables = new System.Windows.Forms.CheckedListBox();
            this.btnAddProject = new System.Windows.Forms.Label();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.ToolStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiGenScript = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbProjects = new System.Windows.Forms.ToolStripComboBox();
            this.rtbFrom = new System.Windows.Forms.RichTextBox();
            this.rtbInsert = new System.Windows.Forms.RichTextBox();
            this.dgvSelectFields = new System.Windows.Forms.DataGridView();
            this.colOrigColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panelHeader.SuspendLayout();
            this.Taskbar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigColumns)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obvInsertTables)).BeginInit();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectFields)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
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
            this.Taskbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Taskbar1.Dock = System.Windows.Forms.DockStyle.None;
            this.Taskbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tmsiConfig,
            this.toolStripMenuItem1});
            this.Taskbar1.Location = new System.Drawing.Point(3, 0);
            this.Taskbar1.Name = "Taskbar1";
            this.Taskbar1.Size = new System.Drawing.Size(132, 24);
            this.Taskbar1.TabIndex = 1;
            this.Taskbar1.Text = "menuStrip1";
            // 
            // tsmiNew
            // 
            this.tsmiNew.ForeColor = System.Drawing.Color.White;
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(40, 20);
            this.tsmiNew.Text = "FILE";
            // 
            // tmsiConfig
            // 
            this.tmsiConfig.ForeColor = System.Drawing.Color.White;
            this.tmsiConfig.Name = "tmsiConfig";
            this.tmsiConfig.Size = new System.Drawing.Size(62, 20);
            this.tmsiConfig.Text = "CONFIG";
            this.tmsiConfig.Click += new System.EventHandler(this.tmsiConfig_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // LblOrigDB
            // 
            this.LblOrigDB.BackColor = System.Drawing.Color.Transparent;
            this.LblOrigDB.ForeColor = System.Drawing.Color.White;
            this.LblOrigDB.Location = new System.Drawing.Point(129, 1);
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
            this.txtOrigDB.Location = new System.Drawing.Point(225, 5);
            this.txtOrigDB.Name = "txtOrigDB";
            this.txtOrigDB.Size = new System.Drawing.Size(100, 20);
            this.txtOrigDB.TabIndex = 3;
            // 
            // txtOrigSVR
            // 
            this.txtOrigSVR.BackColor = System.Drawing.Color.Gray;
            this.txtOrigSVR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigSVR.Location = new System.Drawing.Point(364, 5);
            this.txtOrigSVR.Name = "txtOrigSVR";
            this.txtOrigSVR.Size = new System.Drawing.Size(100, 20);
            this.txtOrigSVR.TabIndex = 5;
            // 
            // lblOrigSVR
            // 
            this.lblOrigSVR.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigSVR.ForeColor = System.Drawing.Color.White;
            this.lblOrigSVR.Location = new System.Drawing.Point(326, 1);
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
            this.txtOrigPass.Location = new System.Drawing.Point(495, 5);
            this.txtOrigPass.Name = "txtOrigPass";
            this.txtOrigPass.Size = new System.Drawing.Size(100, 20);
            this.txtOrigPass.TabIndex = 7;
            // 
            // lblOrigPass
            // 
            this.lblOrigPass.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigPass.ForeColor = System.Drawing.Color.White;
            this.lblOrigPass.Location = new System.Drawing.Point(463, 1);
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
            this.lblDiv.Location = new System.Drawing.Point(640, 4);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(38, 32);
            this.lblDiv.TabIndex = 8;
            this.lblDiv.Text = "|";
            // 
            // txtDestPass
            // 
            this.txtDestPass.BackColor = System.Drawing.Color.Gray;
            this.txtDestPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestPass.Location = new System.Drawing.Point(1013, 5);
            this.txtDestPass.Name = "txtDestPass";
            this.txtDestPass.Size = new System.Drawing.Size(100, 20);
            this.txtDestPass.TabIndex = 14;
            // 
            // lblDestPass
            // 
            this.lblDestPass.BackColor = System.Drawing.Color.Transparent;
            this.lblDestPass.ForeColor = System.Drawing.Color.White;
            this.lblDestPass.Location = new System.Drawing.Point(981, 1);
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
            this.txtDestSVR.Location = new System.Drawing.Point(882, 5);
            this.txtDestSVR.Name = "txtDestSVR";
            this.txtDestSVR.Size = new System.Drawing.Size(100, 20);
            this.txtDestSVR.TabIndex = 12;
            // 
            // lblDestSVR
            // 
            this.lblDestSVR.BackColor = System.Drawing.Color.Transparent;
            this.lblDestSVR.ForeColor = System.Drawing.Color.White;
            this.lblDestSVR.Location = new System.Drawing.Point(844, 1);
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
            this.txtDestDB.Location = new System.Drawing.Point(743, 5);
            this.txtDestDB.Name = "txtDestDB";
            this.txtDestDB.Size = new System.Drawing.Size(100, 20);
            this.txtDestDB.TabIndex = 10;
            // 
            // lblDestDB
            // 
            this.lblDestDB.BackColor = System.Drawing.Color.Transparent;
            this.lblDestDB.ForeColor = System.Drawing.Color.White;
            this.lblDestDB.Location = new System.Drawing.Point(651, 1);
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
            this.lblConnectOrigin.Location = new System.Drawing.Point(605, 4);
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
            this.lblConnectDestiny.Location = new System.Drawing.Point(1119, 4);
            this.lblConnectDestiny.Name = "lblConnectDestiny";
            this.lblConnectDestiny.Size = new System.Drawing.Size(29, 23);
            this.lblConnectDestiny.TabIndex = 16;
            this.lblConnectDestiny.Click += new System.EventHandler(this.lblConnectDestiny_Click);
            // 
            // clbOrigTables
            // 
            this.clbOrigTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.clbOrigTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbOrigTables.ForeColor = System.Drawing.SystemColors.Info;
            this.clbOrigTables.FormattingEnabled = true;
            this.clbOrigTables.Location = new System.Drawing.Point(12, 94);
            this.clbOrigTables.Name = "clbOrigTables";
            this.clbOrigTables.Size = new System.Drawing.Size(184, 180);
            this.clbOrigTables.TabIndex = 17;
            this.clbOrigTables.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbOrigTables_ItemCheck);
            this.clbOrigTables.SelectedIndexChanged += new System.EventHandler(this.clbOrigTables_SelectedIndexChanged);
            // 
            // lblExploreTablesOrig
            // 
            this.lblExploreTablesOrig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExploreTablesOrig.BackColor = System.Drawing.Color.SteelBlue;
            this.lblExploreTablesOrig.ForeColor = System.Drawing.Color.White;
            this.lblExploreTablesOrig.Location = new System.Drawing.Point(12, 64);
            this.lblExploreTablesOrig.Name = "lblExploreTablesOrig";
            this.lblExploreTablesOrig.Size = new System.Drawing.Size(184, 27);
            this.lblExploreTablesOrig.TabIndex = 19;
            this.lblExploreTablesOrig.Text = "Explorador de Tabelas Origem";
            this.lblExploreTablesOrig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExploreColumnsOrig
            // 
            this.lblExploreColumnsOrig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExploreColumnsOrig.BackColor = System.Drawing.Color.SteelBlue;
            this.lblExploreColumnsOrig.ForeColor = System.Drawing.Color.White;
            this.lblExploreColumnsOrig.Location = new System.Drawing.Point(12, 277);
            this.lblExploreColumnsOrig.Name = "lblExploreColumnsOrig";
            this.lblExploreColumnsOrig.Size = new System.Drawing.Size(184, 27);
            this.lblExploreColumnsOrig.TabIndex = 23;
            this.lblExploreColumnsOrig.Text = "Explorador de Colunas";
            this.lblExploreColumnsOrig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExploreTablesDest
            // 
            this.lblExploreTablesDest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExploreTablesDest.BackColor = System.Drawing.Color.SeaGreen;
            this.lblExploreTablesDest.ForeColor = System.Drawing.Color.White;
            this.lblExploreTablesDest.Location = new System.Drawing.Point(981, 64);
            this.lblExploreTablesDest.Name = "lblExploreTablesDest";
            this.lblExploreTablesDest.Size = new System.Drawing.Size(184, 27);
            this.lblExploreTablesDest.TabIndex = 20;
            this.lblExploreTablesDest.Text = "Explorador de Tabelas Destino";
            this.lblExploreTablesDest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrigColumns
            // 
            this.dgvOrigColumns.AllowUserToAddRows = false;
            this.dgvOrigColumns.AllowUserToDeleteRows = false;
            this.dgvOrigColumns.AllowUserToResizeColumns = false;
            this.dgvOrigColumns.AllowUserToResizeRows = false;
            this.dgvOrigColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrigColumns.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvOrigColumns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.NullValue = "null";
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrigColumns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvOrigColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrigColumns.ColumnHeadersVisible = false;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrigColumns.DefaultCellStyle = dataGridViewCellStyle38;
            this.dgvOrigColumns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvOrigColumns.GridColor = System.Drawing.Color.Black;
            this.dgvOrigColumns.Location = new System.Drawing.Point(12, 307);
            this.dgvOrigColumns.MultiSelect = false;
            this.dgvOrigColumns.Name = "dgvOrigColumns";
            this.dgvOrigColumns.ReadOnly = true;
            this.dgvOrigColumns.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrigColumns.RowHeadersVisible = false;
            this.dgvOrigColumns.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.NullValue = "NULL";
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrigColumns.RowsDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvOrigColumns.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrigColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrigColumns.Size = new System.Drawing.Size(184, 356);
            this.dgvOrigColumns.TabIndex = 24;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.MainPanel.Controls.Add(this.obvInsertTables);
            this.MainPanel.Controls.Add(this.lbOrderInsert);
            this.MainPanel.Controls.Add(this.clbDestTables);
            this.MainPanel.Controls.Add(this.btnAddProject);
            this.MainPanel.Controls.Add(this.bntSalvar);
            this.MainPanel.Controls.Add(this.ToolStrip);
            this.MainPanel.Controls.Add(this.lblConnectDestiny);
            this.MainPanel.Controls.Add(this.lblExploreTablesDest);
            this.MainPanel.Controls.Add(this.lblConnectOrigin);
            this.MainPanel.Controls.Add(this.dgvOrigColumns);
            this.MainPanel.Controls.Add(this.txtDestPass);
            this.MainPanel.Controls.Add(this.lblDestPass);
            this.MainPanel.Controls.Add(this.rtbFrom);
            this.MainPanel.Controls.Add(this.txtDestSVR);
            this.MainPanel.Controls.Add(this.rtbInsert);
            this.MainPanel.Controls.Add(this.lblDestSVR);
            this.MainPanel.Controls.Add(this.lblExploreTablesOrig);
            this.MainPanel.Controls.Add(this.txtDestDB);
            this.MainPanel.Controls.Add(this.dgvSelectFields);
            this.MainPanel.Controls.Add(this.lblDestDB);
            this.MainPanel.Controls.Add(this.lblExploreColumnsOrig);
            this.MainPanel.Controls.Add(this.lblDiv);
            this.MainPanel.Controls.Add(this.clbOrigTables);
            this.MainPanel.Controls.Add(this.txtOrigPass);
            this.MainPanel.Controls.Add(this.Taskbar1);
            this.MainPanel.Controls.Add(this.lblOrigPass);
            this.MainPanel.Controls.Add(this.LblOrigDB);
            this.MainPanel.Controls.Add(this.txtOrigSVR);
            this.MainPanel.Controls.Add(this.txtOrigDB);
            this.MainPanel.Controls.Add(this.lblOrigSVR);
            this.MainPanel.Location = new System.Drawing.Point(0, 31);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1177, 675);
            this.MainPanel.TabIndex = 25;
            // 
            // obvInsertTables
            // 
            this.obvInsertTables.AllColumns.Add(this.olvColumn1);
            this.obvInsertTables.AllColumns.Add(this.olvColumn2);
            this.obvInsertTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.obvInsertTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.obvInsertTables.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.obvInsertTables.CellEditTabChangesRows = true;
            this.obvInsertTables.CellEditUseWholeCell = false;
            this.obvInsertTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.obvInsertTables.Cursor = System.Windows.Forms.Cursors.Default;
            this.obvInsertTables.ForeColor = System.Drawing.Color.White;
            this.obvInsertTables.HasCollapsibleGroups = false;
            this.obvInsertTables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.obvInsertTables.HeaderUsesThemes = true;
            this.obvInsertTables.Location = new System.Drawing.Point(981, 383);
            this.obvInsertTables.Name = "obvInsertTables";
            this.obvInsertTables.ShowGroups = false;
            this.obvInsertTables.Size = new System.Drawing.Size(184, 281);
            this.obvInsertTables.TabIndex = 34;
            this.obvInsertTables.UseCompatibleStateImageBehavior = false;
            this.obvInsertTables.View = System.Windows.Forms.View.Details;
            // 
            // lbOrderInsert
            // 
            this.lbOrderInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOrderInsert.BackColor = System.Drawing.Color.ForestGreen;
            this.lbOrderInsert.ForeColor = System.Drawing.Color.White;
            this.lbOrderInsert.Location = new System.Drawing.Point(981, 355);
            this.lbOrderInsert.Name = "lbOrderInsert";
            this.lbOrderInsert.Size = new System.Drawing.Size(184, 27);
            this.lbOrderInsert.TabIndex = 33;
            this.lbOrderInsert.Text = "Ordem de Inserções";
            this.lbOrderInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clbDestTables
            // 
            this.clbDestTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.clbDestTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbDestTables.ForeColor = System.Drawing.Color.White;
            this.clbDestTables.FormattingEnabled = true;
            this.clbDestTables.Location = new System.Drawing.Point(981, 94);
            this.clbDestTables.Name = "clbDestTables";
            this.clbDestTables.Size = new System.Drawing.Size(184, 255);
            this.clbDestTables.TabIndex = 32;
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.DimGray;
            this.btnAddProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAddProject.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProject.Image")));
            this.btnAddProject.Location = new System.Drawing.Point(199, 32);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(20, 23);
            this.btnAddProject.TabIndex = 31;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.BackColor = System.Drawing.Color.Gray;
            this.bntSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSalvar.Location = new System.Drawing.Point(225, 32);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(100, 23);
            this.bntSalvar.TabIndex = 30;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = false;
            // 
            // ToolStrip
            // 
            this.ToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToolStrip.AutoSize = false;
            this.ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGenScript,
            this.tscbProjects});
            this.ToolStrip.Location = new System.Drawing.Point(3, 29);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1174, 29);
            this.ToolStrip.TabIndex = 26;
            this.ToolStrip.Text = "menuStrip1";
            // 
            // tsmiGenScript
            // 
            this.tsmiGenScript.ForeColor = System.Drawing.Color.White;
            this.tsmiGenScript.Name = "tsmiGenScript";
            this.tsmiGenScript.Size = new System.Drawing.Size(62, 25);
            this.tsmiGenScript.Text = "Projetos";
            // 
            // tscbProjects
            // 
            this.tscbProjects.Name = "tscbProjects";
            this.tscbProjects.Size = new System.Drawing.Size(121, 25);
            this.tscbProjects.SelectedIndexChanged += new System.EventHandler(this.tscbProjects_SelectedIndexChanged);
            // 
            // rtbFrom
            // 
            this.rtbFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rtbFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbFrom.ForeColor = System.Drawing.Color.White;
            this.rtbFrom.Location = new System.Drawing.Point(225, 551);
            this.rtbFrom.Name = "rtbFrom";
            this.rtbFrom.Size = new System.Drawing.Size(732, 113);
            this.rtbFrom.TabIndex = 2;
            this.rtbFrom.Text = "";
            // 
            // rtbInsert
            // 
            this.rtbInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rtbInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbInsert.ForeColor = System.Drawing.Color.White;
            this.rtbInsert.Location = new System.Drawing.Point(225, 64);
            this.rtbInsert.Name = "rtbInsert";
            this.rtbInsert.Size = new System.Drawing.Size(732, 98);
            this.rtbInsert.TabIndex = 1;
            this.rtbInsert.Text = "";
            // 
            // dgvSelectFields
            // 
            this.dgvSelectFields.AllowDrop = true;
            this.dgvSelectFields.AllowUserToAddRows = false;
            this.dgvSelectFields.AllowUserToDeleteRows = false;
            this.dgvSelectFields.AllowUserToResizeColumns = false;
            this.dgvSelectFields.AllowUserToResizeRows = false;
            this.dgvSelectFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectFields.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSelectFields.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvSelectFields.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSelectFields.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSelectFields.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvSelectFields.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvSelectFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrigColumn,
            this.colDefaultValue,
            this.colAs,
            this.colDestColumn,
            this.colDestColumnType});
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectFields.DefaultCellStyle = dataGridViewCellStyle42;
            this.dgvSelectFields.Location = new System.Drawing.Point(225, 168);
            this.dgvSelectFields.MultiSelect = false;
            this.dgvSelectFields.Name = "dgvSelectFields";
            this.dgvSelectFields.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSelectFields.RowHeadersVisible = false;
            this.dgvSelectFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSelectFields.Size = new System.Drawing.Size(732, 377);
            this.dgvSelectFields.TabIndex = 0;
            // 
            // colOrigColumn
            // 
            this.colOrigColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrigColumn.DataPropertyName = "colOrigColumn";
            this.colOrigColumn.FillWeight = 61.54822F;
            this.colOrigColumn.HeaderText = "Coluna Origem";
            this.colOrigColumn.Name = "colOrigColumn";
            this.colOrigColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colOrigColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colOrigColumn.ToolTipText = "Coluna da base original para converter";
            // 
            // colDefaultValue
            // 
            this.colDefaultValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colDefaultValue.DataPropertyName = "colDefaultValue";
            this.colDefaultValue.FillWeight = 61.54822F;
            this.colDefaultValue.HeaderText = "Valor Padrão";
            this.colDefaultValue.Name = "colDefaultValue";
            this.colDefaultValue.ReadOnly = true;
            this.colDefaultValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDefaultValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDefaultValue.ToolTipText = "Valor Padrão do campo no destino";
            this.colDefaultValue.Width = 67;
            // 
            // colAs
            // 
            this.colAs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colAs.DataPropertyName = "colAs";
            this.colAs.FillWeight = 253.8071F;
            this.colAs.HeaderText = "As";
            this.colAs.Name = "colAs";
            this.colAs.ReadOnly = true;
            this.colAs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAs.ToolTipText = "Purely Visual";
            this.colAs.Width = 25;
            // 
            // colDestColumn
            // 
            this.colDestColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDestColumn.DataPropertyName = "colDestColumn";
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.White;
            this.colDestColumn.DefaultCellStyle = dataGridViewCellStyle41;
            this.colDestColumn.FillWeight = 61.54822F;
            this.colDestColumn.HeaderText = "Coluna Destino";
            this.colDestColumn.Name = "colDestColumn";
            this.colDestColumn.ReadOnly = true;
            this.colDestColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDestColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDestColumn.ToolTipText = "Coluna alvo para conversão";
            // 
            // colDestColumnType
            // 
            this.colDestColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDestColumnType.DataPropertyName = "colDestColumnType";
            this.colDestColumnType.FillWeight = 61.54822F;
            this.colDestColumnType.HeaderText = "Formato do Campo";
            this.colDestColumnType.Name = "colDestColumnType";
            this.colDestColumnType.ReadOnly = true;
            this.colDestColumnType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDestColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDestColumnType.ToolTipText = "Formato do campo destino";
            this.colDestColumnType.Width = 62;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "table";
            this.olvColumn1.Text = "Tabela";
            this.olvColumn1.Width = 123;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "order";
            this.olvColumn2.Text = "Ordem";
            this.olvColumn2.Width = 127;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1177, 706);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Taskbar1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLBuilder";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.Taskbar1.ResumeLayout(false);
            this.Taskbar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigColumns)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obvInsertTables)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblProgramTitle;
        private System.Windows.Forms.MenuStrip Taskbar1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
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
        private System.Windows.Forms.CheckedListBox clbOrigTables;
        private System.Windows.Forms.Label lblExploreTablesOrig;
        private System.Windows.Forms.Label lblExploreColumnsOrig;
        private System.Windows.Forms.Label lblExploreTablesDest;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView dgvOrigColumns;
        private DataGridView dgvSelectFields;
        private DataGridViewTextBoxColumn colOrigColumn;
        private DataGridViewTextBoxColumn colDefaultValue;
        private DataGridViewTextBoxColumn colAs;
        private DataGridViewTextBoxColumn colDestColumn;
        private DataGridViewTextBoxColumn colDestColumnType;
        private RichTextBox rtbFrom;
        private RichTextBox rtbInsert;
        private MenuStrip ToolStrip;
        private ToolStripMenuItem tsmiGenScript;
        public ToolStripMenuItem tmsiConfig;
        private ToolStripComboBox tscbProjects;
        private Button bntSalvar;
        private Label btnAddProject;
        private CheckedListBox clbDestTables;
        private BrightIdeasSoftware.ObjectListView obvInsertTables;
        private Label lbOrderInsert;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;

    }
}

