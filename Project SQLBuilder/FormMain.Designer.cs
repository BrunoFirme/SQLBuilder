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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.lblSaveState = new System.Windows.Forms.Label();
            this.lblOrigSVR = new System.Windows.Forms.Label();
            this.txtOrigDB = new System.Windows.Forms.TextBox();
            this.txtOrigSVR = new System.Windows.Forms.TextBox();
            this.LblOrigDB = new System.Windows.Forms.Label();
            this.lblOrigPass = new System.Windows.Forms.Label();
            this.txtOrigPass = new System.Windows.Forms.TextBox();
            this.lblExploreColumnsOrig = new System.Windows.Forms.Label();
            this.lblDestDB = new System.Windows.Forms.Label();
            this.dgvSelectFields = new System.Windows.Forms.DataGridView();
            this.colOrigColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDestDB = new System.Windows.Forms.TextBox();
            this.lblExploreTablesOrig = new System.Windows.Forms.Label();
            this.lblDestSVR = new System.Windows.Forms.Label();
            this.rtbInsert = new System.Windows.Forms.RichTextBox();
            this.txtDestSVR = new System.Windows.Forms.TextBox();
            this.rtbFrom = new System.Windows.Forms.RichTextBox();
            this.lblDestPass = new System.Windows.Forms.Label();
            this.txtDestPass = new System.Windows.Forms.TextBox();
            this.lblConnectOrigin = new System.Windows.Forms.Label();
            this.lblExploreTablesDest = new System.Windows.Forms.Label();
            this.lblConnectDestiny = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiGenScript = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbProjects = new System.Windows.Forms.ToolStripComboBox();
            this.btnAddProject = new System.Windows.Forms.Label();
            this.lbOrderInsert = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dlvDestTables = new BrightIdeasSoftware.DataListView();
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvInsertTable = new BrightIdeasSoftware.ObjectListView();
            this.olvTable = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvOrder = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblInsert = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dlvOrigTables = new BrightIdeasSoftware.DataListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dlvOrigColumns = new BrightIdeasSoftware.DataListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnGenerateAllScripts = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerateScript = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ToolStrip = new System.Windows.Forms.MenuStrip();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvDestTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvInsertTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrigTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrigColumns)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.ToolStrip.SuspendLayout();
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
            // bntSalvar
            // 
            this.bntSalvar.BackColor = System.Drawing.Color.Gray;
            this.bntSalvar.FlatAppearance.BorderSize = 0;
            this.bntSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSalvar.Location = new System.Drawing.Point(216, 12);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(83, 23);
            this.bntSalvar.TabIndex = 30;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = false;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // lblSaveState
            // 
            this.lblSaveState.BackColor = System.Drawing.Color.Green;
            this.lblSaveState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaveState.Location = new System.Drawing.Point(300, 12);
            this.lblSaveState.Name = "lblSaveState";
            this.lblSaveState.Size = new System.Drawing.Size(21, 23);
            this.lblSaveState.TabIndex = 44;
            // 
            // lblOrigSVR
            // 
            this.lblOrigSVR.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigSVR.ForeColor = System.Drawing.Color.White;
            this.lblOrigSVR.Location = new System.Drawing.Point(926, 1);
            this.lblOrigSVR.Name = "lblOrigSVR";
            this.lblOrigSVR.Size = new System.Drawing.Size(42, 24);
            this.lblOrigSVR.TabIndex = 4;
            this.lblOrigSVR.Text = "Server:";
            this.lblOrigSVR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOrigDB
            // 
            this.txtOrigDB.BackColor = System.Drawing.Color.Gray;
            this.txtOrigDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigDB.Location = new System.Drawing.Point(831, 2);
            this.txtOrigDB.Name = "txtOrigDB";
            this.txtOrigDB.Size = new System.Drawing.Size(93, 20);
            this.txtOrigDB.TabIndex = 3;
            // 
            // txtOrigSVR
            // 
            this.txtOrigSVR.BackColor = System.Drawing.Color.Gray;
            this.txtOrigSVR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigSVR.Location = new System.Drawing.Point(968, 2);
            this.txtOrigSVR.Name = "txtOrigSVR";
            this.txtOrigSVR.Size = new System.Drawing.Size(63, 20);
            this.txtOrigSVR.TabIndex = 5;
            // 
            // LblOrigDB
            // 
            this.LblOrigDB.BackColor = System.Drawing.Color.Transparent;
            this.LblOrigDB.ForeColor = System.Drawing.Color.White;
            this.LblOrigDB.Location = new System.Drawing.Point(783, 1);
            this.LblOrigDB.Name = "LblOrigDB";
            this.LblOrigDB.Size = new System.Drawing.Size(48, 24);
            this.LblOrigDB.TabIndex = 2;
            this.LblOrigDB.Text = "Origem:";
            this.LblOrigDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrigPass
            // 
            this.lblOrigPass.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigPass.ForeColor = System.Drawing.Color.White;
            this.lblOrigPass.Location = new System.Drawing.Point(1031, 1);
            this.lblOrigPass.Name = "lblOrigPass";
            this.lblOrigPass.Size = new System.Drawing.Size(36, 24);
            this.lblOrigPass.TabIndex = 6;
            this.lblOrigPass.Text = "Pass:";
            this.lblOrigPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOrigPass
            // 
            this.txtOrigPass.BackColor = System.Drawing.Color.Gray;
            this.txtOrigPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigPass.Location = new System.Drawing.Point(1065, 2);
            this.txtOrigPass.Name = "txtOrigPass";
            this.txtOrigPass.Size = new System.Drawing.Size(60, 20);
            this.txtOrigPass.TabIndex = 7;
            // 
            // lblExploreColumnsOrig
            // 
            this.lblExploreColumnsOrig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExploreColumnsOrig.BackColor = System.Drawing.Color.SteelBlue;
            this.lblExploreColumnsOrig.ForeColor = System.Drawing.Color.White;
            this.lblExploreColumnsOrig.Location = new System.Drawing.Point(0, 274);
            this.lblExploreColumnsOrig.Name = "lblExploreColumnsOrig";
            this.lblExploreColumnsOrig.Size = new System.Drawing.Size(212, 27);
            this.lblExploreColumnsOrig.TabIndex = 23;
            this.lblExploreColumnsOrig.Text = "Explorador de Colunas";
            this.lblExploreColumnsOrig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestDB
            // 
            this.lblDestDB.BackColor = System.Drawing.Color.Transparent;
            this.lblDestDB.ForeColor = System.Drawing.Color.White;
            this.lblDestDB.Location = new System.Drawing.Point(781, 22);
            this.lblDestDB.Name = "lblDestDB";
            this.lblDestDB.Size = new System.Drawing.Size(48, 24);
            this.lblDestDB.TabIndex = 9;
            this.lblDestDB.Text = "Destino:";
            this.lblDestDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSelectFields
            // 
            this.dgvSelectFields.AllowDrop = true;
            this.dgvSelectFields.AllowUserToAddRows = false;
            this.dgvSelectFields.AllowUserToDeleteRows = false;
            this.dgvSelectFields.AllowUserToResizeColumns = false;
            this.dgvSelectFields.AllowUserToResizeRows = false;
            this.dgvSelectFields.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvSelectFields.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSelectFields.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSelectFields.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvSelectFields.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSelectFields.ColumnHeadersHeight = 20;
            this.dgvSelectFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSelectFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrigColumn,
            this.colDefaultValue,
            this.colAs,
            this.colDestColumn,
            this.colDestColumnType});
            this.dgvSelectFields.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectFields.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSelectFields.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSelectFields.EnableHeadersVisualStyles = false;
            this.dgvSelectFields.Location = new System.Drawing.Point(214, 170);
            this.dgvSelectFields.MultiSelect = false;
            this.dgvSelectFields.Name = "dgvSelectFields";
            this.dgvSelectFields.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSelectFields.RowHeadersVisible = false;
            this.dgvSelectFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSelectFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSelectFields.Size = new System.Drawing.Size(752, 375);
            this.dgvSelectFields.TabIndex = 0;
            this.dgvSelectFields.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectFields_CellValueChanged);
            // 
            // colOrigColumn
            // 
            this.colOrigColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrigColumn.DataPropertyName = "colOrigColumn";
            this.colOrigColumn.FillWeight = 61.54822F;
            this.colOrigColumn.HeaderText = "COLUNA ORIGEM";
            this.colOrigColumn.Name = "colOrigColumn";
            this.colOrigColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colOrigColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colOrigColumn.ToolTipText = "Coluna da base original para converter";
            // 
            // colDefaultValue
            // 
            this.colDefaultValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDefaultValue.DataPropertyName = "colDefaultValue";
            this.colDefaultValue.FillWeight = 61.54822F;
            this.colDefaultValue.HeaderText = "PADRÃO";
            this.colDefaultValue.Name = "colDefaultValue";
            this.colDefaultValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDefaultValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDefaultValue.ToolTipText = "Valor Padrão do campo no destino";
            // 
            // colAs
            // 
            this.colAs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAs.DataPropertyName = "colAs";
            this.colAs.FillWeight = 253.8071F;
            this.colAs.HeaderText = "AS";
            this.colAs.Name = "colAs";
            this.colAs.ReadOnly = true;
            this.colAs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAs.ToolTipText = "Purely Visual";
            this.colAs.Width = 26;
            // 
            // colDestColumn
            // 
            this.colDestColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDestColumn.DataPropertyName = "colDestColumn";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.colDestColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDestColumn.FillWeight = 61.54822F;
            this.colDestColumn.HeaderText = "COLUNA DESTINO";
            this.colDestColumn.Name = "colDestColumn";
            this.colDestColumn.ReadOnly = true;
            this.colDestColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDestColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDestColumn.ToolTipText = "Coluna alvo para conversão";
            // 
            // colDestColumnType
            // 
            this.colDestColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDestColumnType.DataPropertyName = "colDestColumnType";
            this.colDestColumnType.FillWeight = 61.54822F;
            this.colDestColumnType.HeaderText = "FORMATO";
            this.colDestColumnType.Name = "colDestColumnType";
            this.colDestColumnType.ReadOnly = true;
            this.colDestColumnType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDestColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDestColumnType.ToolTipText = "Formato do campo destino";
            // 
            // txtDestDB
            // 
            this.txtDestDB.BackColor = System.Drawing.Color.Gray;
            this.txtDestDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestDB.Location = new System.Drawing.Point(831, 23);
            this.txtDestDB.Name = "txtDestDB";
            this.txtDestDB.Size = new System.Drawing.Size(93, 20);
            this.txtDestDB.TabIndex = 10;
            // 
            // lblExploreTablesOrig
            // 
            this.lblExploreTablesOrig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExploreTablesOrig.BackColor = System.Drawing.Color.SteelBlue;
            this.lblExploreTablesOrig.ForeColor = System.Drawing.Color.White;
            this.lblExploreTablesOrig.Location = new System.Drawing.Point(0, 47);
            this.lblExploreTablesOrig.Name = "lblExploreTablesOrig";
            this.lblExploreTablesOrig.Size = new System.Drawing.Size(212, 27);
            this.lblExploreTablesOrig.TabIndex = 19;
            this.lblExploreTablesOrig.Text = "Explorador de Tabelas Origem";
            this.lblExploreTablesOrig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestSVR
            // 
            this.lblDestSVR.BackColor = System.Drawing.Color.Transparent;
            this.lblDestSVR.ForeColor = System.Drawing.Color.White;
            this.lblDestSVR.Location = new System.Drawing.Point(926, 22);
            this.lblDestSVR.Name = "lblDestSVR";
            this.lblDestSVR.Size = new System.Drawing.Size(42, 24);
            this.lblDestSVR.TabIndex = 11;
            this.lblDestSVR.Text = "Server:";
            this.lblDestSVR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbInsert
            // 
            this.rtbInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rtbInsert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInsert.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rtbInsert.ForeColor = System.Drawing.Color.White;
            this.rtbInsert.Location = new System.Drawing.Point(214, 49);
            this.rtbInsert.Name = "rtbInsert";
            this.rtbInsert.Size = new System.Drawing.Size(752, 98);
            this.rtbInsert.TabIndex = 1;
            this.rtbInsert.Text = "";
            this.rtbInsert.TextChanged += new System.EventHandler(this.rtbInsert_TextChanged);
            // 
            // txtDestSVR
            // 
            this.txtDestSVR.BackColor = System.Drawing.Color.Gray;
            this.txtDestSVR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestSVR.Location = new System.Drawing.Point(968, 23);
            this.txtDestSVR.Name = "txtDestSVR";
            this.txtDestSVR.Size = new System.Drawing.Size(63, 20);
            this.txtDestSVR.TabIndex = 12;
            // 
            // rtbFrom
            // 
            this.rtbFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rtbFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rtbFrom.ForeColor = System.Drawing.Color.White;
            this.rtbFrom.Location = new System.Drawing.Point(214, 570);
            this.rtbFrom.Name = "rtbFrom";
            this.rtbFrom.Size = new System.Drawing.Size(752, 105);
            this.rtbFrom.TabIndex = 2;
            this.rtbFrom.Text = "";
            this.rtbFrom.TextChanged += new System.EventHandler(this.rtbFrom_TextChanged);
            // 
            // lblDestPass
            // 
            this.lblDestPass.BackColor = System.Drawing.Color.Transparent;
            this.lblDestPass.ForeColor = System.Drawing.Color.White;
            this.lblDestPass.Location = new System.Drawing.Point(1031, 22);
            this.lblDestPass.Name = "lblDestPass";
            this.lblDestPass.Size = new System.Drawing.Size(36, 24);
            this.lblDestPass.TabIndex = 13;
            this.lblDestPass.Text = "Pass:";
            this.lblDestPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDestPass
            // 
            this.txtDestPass.BackColor = System.Drawing.Color.Gray;
            this.txtDestPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestPass.Location = new System.Drawing.Point(1065, 23);
            this.txtDestPass.Name = "txtDestPass";
            this.txtDestPass.Size = new System.Drawing.Size(60, 20);
            this.txtDestPass.TabIndex = 14;
            // 
            // lblConnectOrigin
            // 
            this.lblConnectOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnectOrigin.ForeColor = System.Drawing.Color.Transparent;
            this.lblConnectOrigin.Image = ((System.Drawing.Image)(resources.GetObject("lblConnectOrigin.Image")));
            this.lblConnectOrigin.Location = new System.Drawing.Point(1128, 0);
            this.lblConnectOrigin.Name = "lblConnectOrigin";
            this.lblConnectOrigin.Size = new System.Drawing.Size(49, 23);
            this.lblConnectOrigin.TabIndex = 15;
            this.lblConnectOrigin.Click += new System.EventHandler(this.lblConnectOrigin_Click);
            // 
            // lblExploreTablesDest
            // 
            this.lblExploreTablesDest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExploreTablesDest.BackColor = System.Drawing.Color.SeaGreen;
            this.lblExploreTablesDest.ForeColor = System.Drawing.Color.White;
            this.lblExploreTablesDest.Location = new System.Drawing.Point(968, 47);
            this.lblExploreTablesDest.Name = "lblExploreTablesDest";
            this.lblExploreTablesDest.Size = new System.Drawing.Size(209, 27);
            this.lblExploreTablesDest.TabIndex = 20;
            this.lblExploreTablesDest.Text = "Seleção de Tabelas Destino";
            this.lblExploreTablesDest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConnectDestiny
            // 
            this.lblConnectDestiny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnectDestiny.ForeColor = System.Drawing.Color.Transparent;
            this.lblConnectDestiny.Image = ((System.Drawing.Image)(resources.GetObject("lblConnectDestiny.Image")));
            this.lblConnectDestiny.Location = new System.Drawing.Point(1128, 23);
            this.lblConnectDestiny.Name = "lblConnectDestiny";
            this.lblConnectDestiny.Size = new System.Drawing.Size(49, 23);
            this.lblConnectDestiny.TabIndex = 16;
            this.lblConnectDestiny.Click += new System.EventHandler(this.lblConnectDestiny_Click);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(223, 35);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(216, 29);
            this.miniToolStrip.TabIndex = 26;
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
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.DimGray;
            this.btnAddProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAddProject.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProject.Image")));
            this.btnAddProject.Location = new System.Drawing.Point(185, 12);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(27, 23);
            this.btnAddProject.TabIndex = 31;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // lbOrderInsert
            // 
            this.lbOrderInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOrderInsert.BackColor = System.Drawing.Color.SeaGreen;
            this.lbOrderInsert.ForeColor = System.Drawing.Color.White;
            this.lbOrderInsert.Location = new System.Drawing.Point(968, 274);
            this.lbOrderInsert.Name = "lbOrderInsert";
            this.lbOrderInsert.Size = new System.Drawing.Size(209, 27);
            this.lbOrderInsert.TabIndex = 33;
            this.lbOrderInsert.Text = "Ordem de Inserções";
            this.lbOrderInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(968, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 628);
            this.label2.TabIndex = 36;
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
            this.dlvDestTables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.dlvDestTables.Location = new System.Drawing.Point(972, 76);
            this.dlvDestTables.MultiSelect = false;
            this.dlvDestTables.Name = "dlvDestTables";
            this.dlvDestTables.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dlvDestTables.ShowGroups = false;
            this.dlvDestTables.Size = new System.Drawing.Size(205, 196);
            this.dlvDestTables.TabIndex = 38;
            this.dlvDestTables.UseCompatibleStateImageBehavior = false;
            this.dlvDestTables.UseExplorerTheme = true;
            this.dlvDestTables.View = System.Windows.Forms.View.Details;
            this.dlvDestTables.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.dlvDestTables_ItemCheck);
            this.dlvDestTables.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.dlvDestTables_ItemChecked);
            this.dlvDestTables.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dlvDestTables_MouseDoubleClick);
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Tabela";
            this.olvColumn3.CheckBoxes = true;
            this.olvColumn3.MaximumWidth = 188;
            this.olvColumn3.MinimumWidth = 188;
            this.olvColumn3.Text = "Tabela";
            this.olvColumn3.Width = 188;
            // 
            // olvInsertTable
            // 
            this.olvInsertTable.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.olvInsertTable.AllColumns.Add(this.olvTable);
            this.olvInsertTable.AllColumns.Add(this.olvOrder);
            this.olvInsertTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.olvInsertTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.olvInsertTable.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvInsertTable.CellEditUseWholeCell = false;
            this.olvInsertTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvTable,
            this.olvOrder});
            this.olvInsertTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvInsertTable.ForeColor = System.Drawing.Color.White;
            this.olvInsertTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.olvInsertTable.Location = new System.Drawing.Point(972, 302);
            this.olvInsertTable.MultiSelect = false;
            this.olvInsertTable.Name = "olvInsertTable";
            this.olvInsertTable.ShowGroups = false;
            this.olvInsertTable.Size = new System.Drawing.Size(206, 373);
            this.olvInsertTable.TabIndex = 39;
            this.olvInsertTable.UseCompatibleStateImageBehavior = false;
            this.olvInsertTable.View = System.Windows.Forms.View.Details;
            this.olvInsertTable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvInsertTable_MouseDoubleClick);
            // 
            // olvTable
            // 
            this.olvTable.AspectName = "table";
            this.olvTable.Text = "Tabela";
            this.olvTable.Width = 140;
            // 
            // olvOrder
            // 
            this.olvOrder.AspectName = "order";
            this.olvOrder.Sortable = false;
            this.olvOrder.Text = "Ordem";
            this.olvOrder.Width = 55;
            // 
            // lblInsert
            // 
            this.lblInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblInsert.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsert.ForeColor = System.Drawing.Color.White;
            this.lblInsert.Location = new System.Drawing.Point(214, 145);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(752, 23);
            this.lblInsert.TabIndex = 40;
            this.lblInsert.Text = "INSERT INTO";
            // 
            // lblFrom
            // 
            this.lblFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(214, 547);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(752, 23);
            this.lblFrom.TabIndex = 41;
            this.lblFrom.Text = "FROM";
            // 
            // dlvOrigTables
            // 
            this.dlvOrigTables.AllColumns.Add(this.olvColumn1);
            this.dlvOrigTables.AutoGenerateColumns = false;
            this.dlvOrigTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dlvOrigTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dlvOrigTables.CellEditUseWholeCell = false;
            this.dlvOrigTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1});
            this.dlvOrigTables.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlvOrigTables.DataSource = null;
            this.dlvOrigTables.ForeColor = System.Drawing.Color.White;
            this.dlvOrigTables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.dlvOrigTables.Location = new System.Drawing.Point(0, 76);
            this.dlvOrigTables.MultiSelect = false;
            this.dlvOrigTables.Name = "dlvOrigTables";
            this.dlvOrigTables.ShowGroups = false;
            this.dlvOrigTables.Size = new System.Drawing.Size(208, 196);
            this.dlvOrigTables.TabIndex = 42;
            this.dlvOrigTables.UseCompatibleStateImageBehavior = false;
            this.dlvOrigTables.UseExplorerTheme = true;
            this.dlvOrigTables.View = System.Windows.Forms.View.Details;
            this.dlvOrigTables.SelectionChanged += new System.EventHandler(this.dlvOrigTables_SelectionChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "table_name";
            this.olvColumn1.IsVisible = false;
            this.olvColumn1.MaximumWidth = 190;
            this.olvColumn1.MinimumWidth = 190;
            this.olvColumn1.Text = "Tabela";
            this.olvColumn1.Width = 190;
            // 
            // dlvOrigColumns
            // 
            this.dlvOrigColumns.AllColumns.Add(this.olvColumn2);
            this.dlvOrigColumns.AllColumns.Add(this.olvColumn4);
            this.dlvOrigColumns.AutoGenerateColumns = false;
            this.dlvOrigColumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dlvOrigColumns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dlvOrigColumns.CellEditUseWholeCell = false;
            this.dlvOrigColumns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2,
            this.olvColumn4});
            this.dlvOrigColumns.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlvOrigColumns.DataSource = null;
            this.dlvOrigColumns.ForeColor = System.Drawing.Color.White;
            this.dlvOrigColumns.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.dlvOrigColumns.Location = new System.Drawing.Point(0, 302);
            this.dlvOrigColumns.MultiSelect = false;
            this.dlvOrigColumns.Name = "dlvOrigColumns";
            this.dlvOrigColumns.ShowGroups = false;
            this.dlvOrigColumns.Size = new System.Drawing.Size(208, 373);
            this.dlvOrigColumns.TabIndex = 43;
            this.dlvOrigColumns.UseCompatibleStateImageBehavior = false;
            this.dlvOrigColumns.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Coluna";
            this.olvColumn2.MaximumWidth = 120;
            this.olvColumn2.MinimumWidth = 120;
            this.olvColumn2.Text = "Coluna";
            this.olvColumn2.Width = 120;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Tipo";
            this.olvColumn4.MaximumWidth = 70;
            this.olvColumn4.MinimumWidth = 70;
            this.olvColumn4.Text = "Tipo";
            this.olvColumn4.Width = 70;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.MainPanel.Controls.Add(this.btnGenerateAllScripts);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.btnGenerateScript);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.lblSaveState);
            this.MainPanel.Controls.Add(this.dlvOrigColumns);
            this.MainPanel.Controls.Add(this.dlvOrigTables);
            this.MainPanel.Controls.Add(this.lblFrom);
            this.MainPanel.Controls.Add(this.lblInsert);
            this.MainPanel.Controls.Add(this.bntSalvar);
            this.MainPanel.Controls.Add(this.olvInsertTable);
            this.MainPanel.Controls.Add(this.dlvDestTables);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.lbOrderInsert);
            this.MainPanel.Controls.Add(this.btnAddProject);
            this.MainPanel.Controls.Add(this.ToolStrip);
            this.MainPanel.Controls.Add(this.lblConnectDestiny);
            this.MainPanel.Controls.Add(this.lblExploreTablesDest);
            this.MainPanel.Controls.Add(this.lblConnectOrigin);
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
            // btnGenerateAllScripts
            // 
            this.btnGenerateAllScripts.BackColor = System.Drawing.Color.Gray;
            this.btnGenerateAllScripts.FlatAppearance.BorderSize = 0;
            this.btnGenerateAllScripts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateAllScripts.Location = new System.Drawing.Point(417, 12);
            this.btnGenerateAllScripts.Name = "btnGenerateAllScripts";
            this.btnGenerateAllScripts.Size = new System.Drawing.Size(83, 23);
            this.btnGenerateAllScripts.TabIndex = 48;
            this.btnGenerateAllScripts.Text = "Gerar Todos";
            this.btnGenerateAllScripts.UseVisualStyleBackColor = false;
            this.btnGenerateAllScripts.Click += new System.EventHandler(this.btnGenerateAllScripts_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(325, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 30);
            this.label6.TabIndex = 47;
            // 
            // btnGenerateScript
            // 
            this.btnGenerateScript.BackColor = System.Drawing.Color.Gray;
            this.btnGenerateScript.FlatAppearance.BorderSize = 0;
            this.btnGenerateScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateScript.Location = new System.Drawing.Point(331, 12);
            this.btnGenerateScript.Name = "btnGenerateScript";
            this.btnGenerateScript.Size = new System.Drawing.Size(83, 23);
            this.btnGenerateScript.TabIndex = 46;
            this.btnGenerateScript.Text = "Gerar Script";
            this.btnGenerateScript.UseVisualStyleBackColor = false;
            this.btnGenerateScript.Click += new System.EventHandler(this.btnGenerateScript_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(776, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 47);
            this.label5.TabIndex = 45;
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
            this.ToolStrip.Location = new System.Drawing.Point(-6, 9);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(193, 29);
            this.ToolStrip.TabIndex = 26;
            this.ToolStrip.Text = "menuStrip1";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvDestTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvInsertTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrigTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrigColumns)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblProgramTitle;
        private Button bntSalvar;
        private Label label4;
        private Label lblSaveState;
        private Label lblOrigSVR;
        private TextBox txtOrigDB;
        private TextBox txtOrigSVR;
        private Label LblOrigDB;
        private Label lblOrigPass;
        private TextBox txtOrigPass;
        private Label lblExploreColumnsOrig;
        private Label lblDestDB;
        private DataGridView dgvSelectFields;
        private TextBox txtDestDB;
        private Label lblExploreTablesOrig;
        private Label lblDestSVR;
        private RichTextBox rtbInsert;
        private TextBox txtDestSVR;
        private RichTextBox rtbFrom;
        private Label lblDestPass;
        private TextBox txtDestPass;
        private Label lblConnectOrigin;
        private Label lblExploreTablesDest;
        private Label lblConnectDestiny;
        private MenuStrip miniToolStrip;
        private ToolStripMenuItem tsmiGenScript;
        private ToolStripComboBox tscbProjects;
        private Label btnAddProject;
        private Label lbOrderInsert;
        private Label label1;
        private Label label2;
        private Label label3;
        private BrightIdeasSoftware.DataListView dlvDestTables;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.ObjectListView olvInsertTable;
        private BrightIdeasSoftware.OLVColumn olvTable;
        private BrightIdeasSoftware.OLVColumn olvOrder;
        private Label lblInsert;
        private Label lblFrom;
        private BrightIdeasSoftware.DataListView dlvOrigTables;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.DataListView dlvOrigColumns;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private Panel MainPanel;
        private MenuStrip ToolStrip;
        private Label label5;
        private Label label6;
        private Button btnGenerateScript;
        private Button btnGenerateAllScripts;
        private DataGridViewTextBoxColumn colOrigColumn;
        private DataGridViewTextBoxColumn colDefaultValue;
        private DataGridViewTextBoxColumn colAs;
        private DataGridViewTextBoxColumn colDestColumn;
        private DataGridViewTextBoxColumn colDestColumnType;

    }
}

