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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.LblOrigDB = new System.Windows.Forms.Label();
            this.txtOrigDB = new System.Windows.Forms.TextBox();
            this.txtOrigSVR = new System.Windows.Forms.TextBox();
            this.lblOrigSVR = new System.Windows.Forms.Label();
            this.txtOrigPass = new System.Windows.Forms.TextBox();
            this.lblOrigPass = new System.Windows.Forms.Label();
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
            this.dlvDestTables = new BrightIdeasSoftware.DataListView();
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOrderInsert = new System.Windows.Forms.Label();
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
            this.olvInserttables = new BrightIdeasSoftware.ObjectListView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigColumns)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlvDestTables)).BeginInit();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvInserttables)).BeginInit();
            this.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(1177, 31);
            this.panelHeader.TabIndex = 0;
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
            // LblOrigDB
            // 
            this.LblOrigDB.BackColor = System.Drawing.Color.Transparent;
            this.LblOrigDB.ForeColor = System.Drawing.Color.White;
            this.LblOrigDB.Location = new System.Drawing.Point(335, 13);
            this.LblOrigDB.Name = "LblOrigDB";
            this.LblOrigDB.Size = new System.Drawing.Size(48, 24);
            this.LblOrigDB.TabIndex = 2;
            this.LblOrigDB.Text = "Origem:";
            this.LblOrigDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOrigDB
            // 
            this.txtOrigDB.BackColor = System.Drawing.Color.Gray;
            this.txtOrigDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigDB.Location = new System.Drawing.Point(383, 14);
            this.txtOrigDB.Name = "txtOrigDB";
            this.txtOrigDB.Size = new System.Drawing.Size(100, 20);
            this.txtOrigDB.TabIndex = 3;
            // 
            // txtOrigSVR
            // 
            this.txtOrigSVR.BackColor = System.Drawing.Color.Gray;
            this.txtOrigSVR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigSVR.Location = new System.Drawing.Point(529, 14);
            this.txtOrigSVR.Name = "txtOrigSVR";
            this.txtOrigSVR.Size = new System.Drawing.Size(63, 20);
            this.txtOrigSVR.TabIndex = 5;
            // 
            // lblOrigSVR
            // 
            this.lblOrigSVR.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigSVR.ForeColor = System.Drawing.Color.White;
            this.lblOrigSVR.Location = new System.Drawing.Point(485, 12);
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
            this.txtOrigPass.Location = new System.Drawing.Point(630, 14);
            this.txtOrigPass.Name = "txtOrigPass";
            this.txtOrigPass.Size = new System.Drawing.Size(60, 20);
            this.txtOrigPass.TabIndex = 7;
            // 
            // lblOrigPass
            // 
            this.lblOrigPass.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigPass.ForeColor = System.Drawing.Color.White;
            this.lblOrigPass.Location = new System.Drawing.Point(594, 13);
            this.lblOrigPass.Name = "lblOrigPass";
            this.lblOrigPass.Size = new System.Drawing.Size(36, 24);
            this.lblOrigPass.TabIndex = 6;
            this.lblOrigPass.Text = "Pass:";
            this.lblOrigPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDestPass
            // 
            this.txtDestPass.BackColor = System.Drawing.Color.Gray;
            this.txtDestPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestPass.Location = new System.Drawing.Point(1048, 15);
            this.txtDestPass.Name = "txtDestPass";
            this.txtDestPass.Size = new System.Drawing.Size(60, 20);
            this.txtDestPass.TabIndex = 14;
            // 
            // lblDestPass
            // 
            this.lblDestPass.BackColor = System.Drawing.Color.Transparent;
            this.lblDestPass.ForeColor = System.Drawing.Color.White;
            this.lblDestPass.Location = new System.Drawing.Point(1006, 11);
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
            this.txtDestSVR.Location = new System.Drawing.Point(945, 15);
            this.txtDestSVR.Name = "txtDestSVR";
            this.txtDestSVR.Size = new System.Drawing.Size(63, 20);
            this.txtDestSVR.TabIndex = 12;
            // 
            // lblDestSVR
            // 
            this.lblDestSVR.BackColor = System.Drawing.Color.Transparent;
            this.lblDestSVR.ForeColor = System.Drawing.Color.White;
            this.lblDestSVR.Location = new System.Drawing.Point(897, 12);
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
            this.txtDestDB.Location = new System.Drawing.Point(801, 14);
            this.txtDestDB.Name = "txtDestDB";
            this.txtDestDB.Size = new System.Drawing.Size(94, 20);
            this.txtDestDB.TabIndex = 10;
            // 
            // lblDestDB
            // 
            this.lblDestDB.BackColor = System.Drawing.Color.Transparent;
            this.lblDestDB.ForeColor = System.Drawing.Color.White;
            this.lblDestDB.Location = new System.Drawing.Point(747, 12);
            this.lblDestDB.Name = "lblDestDB";
            this.lblDestDB.Size = new System.Drawing.Size(48, 24);
            this.lblDestDB.TabIndex = 9;
            this.lblDestDB.Text = "Destino:";
            this.lblDestDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConnectOrigin
            // 
            this.lblConnectOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnectOrigin.ForeColor = System.Drawing.Color.Transparent;
            this.lblConnectOrigin.Image = ((System.Drawing.Image)(resources.GetObject("lblConnectOrigin.Image")));
            this.lblConnectOrigin.Location = new System.Drawing.Point(703, 13);
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
            this.lblConnectDestiny.Location = new System.Drawing.Point(1116, 12);
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
            this.clbOrigTables.Location = new System.Drawing.Point(3, 76);
            this.clbOrigTables.Name = "clbOrigTables";
            this.clbOrigTables.Size = new System.Drawing.Size(209, 195);
            this.clbOrigTables.TabIndex = 17;
            this.clbOrigTables.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbOrigTables_ItemCheck);
            this.clbOrigTables.SelectedIndexChanged += new System.EventHandler(this.clbOrigTables_SelectedIndexChanged);
            // 
            // lblExploreTablesOrig
            // 
            this.lblExploreTablesOrig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExploreTablesOrig.BackColor = System.Drawing.Color.SteelBlue;
            this.lblExploreTablesOrig.ForeColor = System.Drawing.Color.White;
            this.lblExploreTablesOrig.Location = new System.Drawing.Point(3, 47);
            this.lblExploreTablesOrig.Name = "lblExploreTablesOrig";
            this.lblExploreTablesOrig.Size = new System.Drawing.Size(209, 27);
            this.lblExploreTablesOrig.TabIndex = 19;
            this.lblExploreTablesOrig.Text = "Explorador de Tabelas Origem";
            this.lblExploreTablesOrig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExploreColumnsOrig
            // 
            this.lblExploreColumnsOrig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExploreColumnsOrig.BackColor = System.Drawing.Color.SteelBlue;
            this.lblExploreColumnsOrig.ForeColor = System.Drawing.Color.White;
            this.lblExploreColumnsOrig.Location = new System.Drawing.Point(3, 274);
            this.lblExploreColumnsOrig.Name = "lblExploreColumnsOrig";
            this.lblExploreColumnsOrig.Size = new System.Drawing.Size(209, 27);
            this.lblExploreColumnsOrig.TabIndex = 23;
            this.lblExploreColumnsOrig.Text = "Explorador de Colunas";
            this.lblExploreColumnsOrig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExploreTablesDest
            // 
            this.lblExploreTablesDest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExploreTablesDest.BackColor = System.Drawing.Color.SeaGreen;
            this.lblExploreTablesDest.ForeColor = System.Drawing.Color.White;
            this.lblExploreTablesDest.Location = new System.Drawing.Point(968, 47);
            this.lblExploreTablesDest.Name = "lblExploreTablesDest";
            this.lblExploreTablesDest.Size = new System.Drawing.Size(206, 27);
            this.lblExploreTablesDest.TabIndex = 20;
            this.lblExploreTablesDest.Text = "Seleção de Tabelas Destino";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.NullValue = "null";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrigColumns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrigColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrigColumns.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrigColumns.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrigColumns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvOrigColumns.GridColor = System.Drawing.Color.Black;
            this.dgvOrigColumns.Location = new System.Drawing.Point(3, 303);
            this.dgvOrigColumns.MultiSelect = false;
            this.dgvOrigColumns.Name = "dgvOrigColumns";
            this.dgvOrigColumns.ReadOnly = true;
            this.dgvOrigColumns.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrigColumns.RowHeadersVisible = false;
            this.dgvOrigColumns.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.NullValue = "NULL";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrigColumns.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOrigColumns.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrigColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrigColumns.Size = new System.Drawing.Size(209, 369);
            this.dgvOrigColumns.TabIndex = 24;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.MainPanel.Controls.Add(this.olvInserttables);
            this.MainPanel.Controls.Add(this.dlvDestTables);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.lbOrderInsert);
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
            this.MainPanel.Controls.Add(this.clbOrigTables);
            this.MainPanel.Controls.Add(this.txtOrigPass);
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
            // dlvDestTables
            // 
            this.dlvDestTables.AllColumns.Add(this.olvColumn3);
            this.dlvDestTables.AutoGenerateColumns = false;
            this.dlvDestTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dlvDestTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dlvDestTables.CellEditUseWholeCell = false;
            this.dlvDestTables.CheckBoxes = true;
            this.dlvDestTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn3});
            this.dlvDestTables.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlvDestTables.DataSource = null;
            this.dlvDestTables.ForeColor = System.Drawing.Color.White;
            this.dlvDestTables.Location = new System.Drawing.Point(971, 76);
            this.dlvDestTables.MultiSelect = false;
            this.dlvDestTables.Name = "dlvDestTables";
            this.dlvDestTables.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dlvDestTables.ShowGroups = false;
            this.dlvDestTables.Size = new System.Drawing.Size(203, 195);
            this.dlvDestTables.TabIndex = 38;
            this.dlvDestTables.UseCompatibleStateImageBehavior = false;
            this.dlvDestTables.UseExplorerTheme = true;
            this.dlvDestTables.View = System.Windows.Forms.View.Details;
            this.dlvDestTables.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.dlvDestTables_ItemChecked);
            this.dlvDestTables.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dlvDestTables_MouseDoubleClick);
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Tabela";
            this.olvColumn3.CheckBoxes = true;
            this.olvColumn3.Text = "Tabela";
            this.olvColumn3.Width = 203;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(210, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 628);
            this.label3.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(968, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 628);
            this.label2.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1177, 2);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            // 
            // lbOrderInsert
            // 
            this.lbOrderInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOrderInsert.BackColor = System.Drawing.Color.ForestGreen;
            this.lbOrderInsert.ForeColor = System.Drawing.Color.White;
            this.lbOrderInsert.Location = new System.Drawing.Point(968, 274);
            this.lbOrderInsert.Name = "lbOrderInsert";
            this.lbOrderInsert.Size = new System.Drawing.Size(206, 27);
            this.lbOrderInsert.TabIndex = 33;
            this.lbOrderInsert.Text = "Ordem de Inserções";
            this.lbOrderInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.DimGray;
            this.btnAddProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAddProject.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProject.Image")));
            this.btnAddProject.Location = new System.Drawing.Point(199, 11);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(20, 23);
            this.btnAddProject.TabIndex = 31;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.BackColor = System.Drawing.Color.Gray;
            this.bntSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSalvar.Location = new System.Drawing.Point(231, 11);
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
            this.ToolStrip.Location = new System.Drawing.Point(3, 8);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(322, 29);
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
            this.rtbFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rtbFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFrom.ForeColor = System.Drawing.Color.White;
            this.rtbFrom.Location = new System.Drawing.Point(210, 550);
            this.rtbFrom.Name = "rtbFrom";
            this.rtbFrom.Size = new System.Drawing.Size(760, 122);
            this.rtbFrom.TabIndex = 2;
            this.rtbFrom.Text = "";
            // 
            // rtbInsert
            // 
            this.rtbInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rtbInsert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInsert.ForeColor = System.Drawing.Color.White;
            this.rtbInsert.Location = new System.Drawing.Point(210, 46);
            this.rtbInsert.Name = "rtbInsert";
            this.rtbInsert.Size = new System.Drawing.Size(760, 116);
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
            this.dgvSelectFields.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvSelectFields.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSelectFields.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSelectFields.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvSelectFields.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSelectFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrigColumn,
            this.colDefaultValue,
            this.colAs,
            this.colDestColumn,
            this.colDestColumnType});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectFields.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSelectFields.Location = new System.Drawing.Point(210, 168);
            this.dgvSelectFields.MultiSelect = false;
            this.dgvSelectFields.Name = "dgvSelectFields";
            this.dgvSelectFields.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSelectFields.RowHeadersVisible = false;
            this.dgvSelectFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSelectFields.Size = new System.Drawing.Size(760, 377);
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
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.colDestColumn.DefaultCellStyle = dataGridViewCellStyle11;
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
            // olvInserttables
            // 
            this.olvInserttables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.olvInserttables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.olvInserttables.CellEditUseWholeCell = false;
            this.olvInserttables.Location = new System.Drawing.Point(971, 303);
            this.olvInserttables.Name = "olvInserttables";
            this.olvInserttables.ShowGroups = false;
            this.olvInserttables.Size = new System.Drawing.Size(203, 369);
            this.olvInserttables.TabIndex = 39;
            this.olvInserttables.UseCompatibleStateImageBehavior = false;
            this.olvInserttables.View = System.Windows.Forms.View.Details;
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
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLBuilder";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigColumns)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlvDestTables)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvInserttables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblProgramTitle;
        private System.Windows.Forms.Label LblOrigDB;
        private System.Windows.Forms.TextBox txtOrigDB;
        private System.Windows.Forms.TextBox txtOrigSVR;
        private System.Windows.Forms.Label lblOrigSVR;
        private System.Windows.Forms.TextBox txtOrigPass;
        private System.Windows.Forms.Label lblOrigPass;
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
        private ToolStripComboBox tscbProjects;
        private Button bntSalvar;
        private Label btnAddProject;
        private Label lbOrderInsert;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private BrightIdeasSoftware.DataListView dlvDestTables;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.ObjectListView olvInserttables;

    }
}

