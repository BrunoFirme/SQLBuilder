using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project_SQLBuilder.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSaveState = new System.Windows.Forms.Label();
            this.lblExploreColumnsOrig = new System.Windows.Forms.Label();
            this.dgvSelectFields = new System.Windows.Forms.DataGridView();
            this.colOrigColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblExploreTablesOrig = new System.Windows.Forms.Label();
            this.rtbInsert = new System.Windows.Forms.RichTextBox();
            this.rtbFrom = new System.Windows.Forms.RichTextBox();
            this.lblExploreTablesDest = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiProject = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbProjects = new System.Windows.Forms.ToolStripComboBox();
            this.lbOrderInsert = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiv1 = new System.Windows.Forms.Label();
            this.lvlDiv2 = new System.Windows.Forms.Label();
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
            this.lblRemoveCustomField = new System.Windows.Forms.Label();
            this.olvCustomField = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblAddCustomField = new System.Windows.Forms.Label();
            this.lblCustomFields = new System.Windows.Forms.Label();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.ToolStrip = new System.Windows.Forms.MenuStrip();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esteScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosParaTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvDestTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvInsertTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrigTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrigColumns)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCustomField)).BeginInit();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelHeader.Controls.Add(this.label2);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(69, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "por Bruno Firme";
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
            this.lblProgramTitle.Size = new System.Drawing.Size(60, 13);
            this.lblProgramTitle.TabIndex = 2;
            this.lblProgramTitle.Text = "SQLBuilder";
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
            // lblSaveState
            // 
            this.lblSaveState.BackColor = System.Drawing.Color.Green;
            this.lblSaveState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaveState.Location = new System.Drawing.Point(351, 7);
            this.lblSaveState.Name = "lblSaveState";
            this.lblSaveState.Size = new System.Drawing.Size(22, 24);
            this.lblSaveState.TabIndex = 44;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectFields.ColumnHeadersHeight = 20;
            this.dgvSelectFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSelectFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrigColumn,
            this.colDefaultValue,
            this.colAs,
            this.colColumn,
            this.colColumnType});
            this.dgvSelectFields.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectFields.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.dgvSelectFields.TabIndex = 4;
            this.dgvSelectFields.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectFields_CellValueChanged);
            // 
            // colOrigColumn
            // 
            this.colOrigColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrigColumn.DataPropertyName = "colNullValue";
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
            // colColumn
            // 
            this.colColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colColumn.DataPropertyName = "colColumn";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.colColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.colColumn.FillWeight = 61.54822F;
            this.colColumn.HeaderText = "COLUNA DESTINO";
            this.colColumn.Name = "colColumn";
            this.colColumn.ReadOnly = true;
            this.colColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colColumn.ToolTipText = "Coluna alvo para conversão";
            // 
            // colColumnType
            // 
            this.colColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colColumnType.DataPropertyName = "colColumnType";
            this.colColumnType.FillWeight = 61.54822F;
            this.colColumnType.HeaderText = "FORMATO";
            this.colColumnType.Name = "colColumnType";
            this.colColumnType.ReadOnly = true;
            this.colColumnType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colColumnType.ToolTipText = "Formato do campo destino";
            // 
            // lblExploreTablesOrig
            // 
            this.lblExploreTablesOrig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExploreTablesOrig.BackColor = System.Drawing.Color.SteelBlue;
            this.lblExploreTablesOrig.ForeColor = System.Drawing.Color.White;
            this.lblExploreTablesOrig.Location = new System.Drawing.Point(0, 38);
            this.lblExploreTablesOrig.Name = "lblExploreTablesOrig";
            this.lblExploreTablesOrig.Size = new System.Drawing.Size(212, 27);
            this.lblExploreTablesOrig.TabIndex = 19;
            this.lblExploreTablesOrig.Text = "Explorador de Tabelas Origem";
            this.lblExploreTablesOrig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbInsert
            // 
            this.rtbInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rtbInsert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInsert.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rtbInsert.ForeColor = System.Drawing.Color.White;
            this.rtbInsert.Location = new System.Drawing.Point(214, 38);
            this.rtbInsert.Name = "rtbInsert";
            this.rtbInsert.Size = new System.Drawing.Size(752, 109);
            this.rtbInsert.TabIndex = 3;
            this.rtbInsert.Text = "";
            this.rtbInsert.TextChanged += new System.EventHandler(this.rtbInsert_TextChanged);
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
            this.rtbFrom.TabIndex = 5;
            this.rtbFrom.Text = "";
            this.rtbFrom.TextChanged += new System.EventHandler(this.rtbFrom_TextChanged);
            // 
            // lblExploreTablesDest
            // 
            this.lblExploreTablesDest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExploreTablesDest.BackColor = System.Drawing.Color.SeaGreen;
            this.lblExploreTablesDest.ForeColor = System.Drawing.Color.White;
            this.lblExploreTablesDest.Location = new System.Drawing.Point(968, 39);
            this.lblExploreTablesDest.Name = "lblExploreTablesDest";
            this.lblExploreTablesDest.Size = new System.Drawing.Size(209, 27);
            this.lblExploreTablesDest.TabIndex = 20;
            this.lblExploreTablesDest.Text = "Seleção de Tabelas Destino";
            this.lblExploreTablesDest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tsmiProject
            // 
            this.tsmiProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.tsmiProject.ForeColor = System.Drawing.Color.White;
            this.tsmiProject.Name = "tsmiProject";
            this.tsmiProject.Size = new System.Drawing.Size(57, 35);
            this.tsmiProject.Text = "Projeto";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // tscbProjects
            // 
            this.tscbProjects.Name = "tscbProjects";
            this.tscbProjects.Size = new System.Drawing.Size(121, 35);
            this.tscbProjects.SelectedIndexChanged += new System.EventHandler(this.tscbProjects_SelectedIndexChanged);
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
            this.label1.Location = new System.Drawing.Point(0, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1178, 2);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            // 
            // lblDiv1
            // 
            this.lblDiv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiv1.Enabled = false;
            this.lblDiv1.Location = new System.Drawing.Point(968, 38);
            this.lblDiv1.Name = "lblDiv1";
            this.lblDiv1.Size = new System.Drawing.Size(2, 640);
            this.lblDiv1.TabIndex = 36;
            // 
            // lvlDiv2
            // 
            this.lvlDiv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlDiv2.Enabled = false;
            this.lvlDiv2.Location = new System.Drawing.Point(210, 37);
            this.lvlDiv2.Name = "lvlDiv2";
            this.lvlDiv2.Size = new System.Drawing.Size(2, 650);
            this.lvlDiv2.TabIndex = 37;
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
            this.dlvDestTables.Location = new System.Drawing.Point(971, 68);
            this.dlvDestTables.MultiSelect = false;
            this.dlvDestTables.Name = "dlvDestTables";
            this.dlvDestTables.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dlvDestTables.ShowGroups = false;
            this.dlvDestTables.Size = new System.Drawing.Size(205, 204);
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
            this.olvColumn3.AspectName = "colTable";
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
            this.olvInsertTable.CheckBoxes = true;
            this.olvInsertTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvTable,
            this.olvOrder});
            this.olvInsertTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvInsertTable.ForeColor = System.Drawing.Color.White;
            this.olvInsertTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.olvInsertTable.IsSimpleDragSource = true;
            this.olvInsertTable.IsSimpleDropSink = true;
            this.olvInsertTable.Location = new System.Drawing.Point(972, 302);
            this.olvInsertTable.MultiSelect = false;
            this.olvInsertTable.Name = "olvInsertTable";
            this.olvInsertTable.ShowGroups = false;
            this.olvInsertTable.Size = new System.Drawing.Size(206, 215);
            this.olvInsertTable.TabIndex = 39;
            this.olvInsertTable.UseCompatibleStateImageBehavior = false;
            this.olvInsertTable.View = System.Windows.Forms.View.Details;
            this.olvInsertTable.CanDrop += new System.EventHandler<BrightIdeasSoftware.OlvDropEventArgs>(this.olvInsertTable_CanDrop);
            this.olvInsertTable.Dropped += new System.EventHandler<BrightIdeasSoftware.OlvDropEventArgs>(this.olvInsertTable_Dropped);
            this.olvInsertTable.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.olvInsertTable_ItemCheck);
            this.olvInsertTable.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.olvInsertTable_ItemChecked);
            this.olvInsertTable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvInsertTable_MouseDoubleClick);
            // 
            // olvTable
            // 
            this.olvTable.AspectName = "Table";
            this.olvTable.MaximumWidth = 185;
            this.olvTable.MinimumWidth = 185;
            this.olvTable.Text = "Tabela";
            this.olvTable.Width = 185;
            // 
            // olvOrder
            // 
            this.olvOrder.AspectName = "Order";
            this.olvOrder.IsEditable = false;
            this.olvOrder.MaximumWidth = 20;
            this.olvOrder.MinimumWidth = 20;
            this.olvOrder.Sortable = false;
            this.olvOrder.Text = "Ordem";
            this.olvOrder.Width = 20;
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
            this.dlvOrigTables.Location = new System.Drawing.Point(3, 68);
            this.dlvOrigTables.MultiSelect = false;
            this.dlvOrigTables.Name = "dlvOrigTables";
            this.dlvOrigTables.ShowGroups = false;
            this.dlvOrigTables.Size = new System.Drawing.Size(205, 204);
            this.dlvOrigTables.TabIndex = 42;
            this.dlvOrigTables.UseCompatibleStateImageBehavior = false;
            this.dlvOrigTables.UseExplorerTheme = true;
            this.dlvOrigTables.View = System.Windows.Forms.View.Details;
            this.dlvOrigTables.SelectionChanged += new System.EventHandler(this.dlvOrigTables_SelectionChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "colTable";
            this.olvColumn1.IsVisible = false;
            this.olvColumn1.MaximumWidth = 188;
            this.olvColumn1.MinimumWidth = 188;
            this.olvColumn1.Text = "Tabela";
            this.olvColumn1.Width = 188;
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
            this.dlvOrigColumns.ShowItemToolTips = true;
            this.dlvOrigColumns.Size = new System.Drawing.Size(208, 373);
            this.dlvOrigColumns.TabIndex = 43;
            this.dlvOrigColumns.UseCompatibleStateImageBehavior = false;
            this.dlvOrigColumns.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "colColumn";
            this.olvColumn2.MaximumWidth = 120;
            this.olvColumn2.MinimumWidth = 120;
            this.olvColumn2.Text = "Coluna";
            this.olvColumn2.Width = 120;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "colColumnType";
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
            this.MainPanel.Controls.Add(this.lblRemoveCustomField);
            this.MainPanel.Controls.Add(this.olvCustomField);
            this.MainPanel.Controls.Add(this.lblAddCustomField);
            this.MainPanel.Controls.Add(this.lblCustomFields);
            this.MainPanel.Controls.Add(this.lblStatusText);
            this.MainPanel.Controls.Add(this.lblSaveState);
            this.MainPanel.Controls.Add(this.dlvOrigColumns);
            this.MainPanel.Controls.Add(this.dlvOrigTables);
            this.MainPanel.Controls.Add(this.lblFrom);
            this.MainPanel.Controls.Add(this.lblInsert);
            this.MainPanel.Controls.Add(this.olvInsertTable);
            this.MainPanel.Controls.Add(this.dlvDestTables);
            this.MainPanel.Controls.Add(this.lvlDiv2);
            this.MainPanel.Controls.Add(this.lblDiv1);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.lbOrderInsert);
            this.MainPanel.Controls.Add(this.ToolStrip);
            this.MainPanel.Controls.Add(this.lblExploreTablesDest);
            this.MainPanel.Controls.Add(this.rtbFrom);
            this.MainPanel.Controls.Add(this.rtbInsert);
            this.MainPanel.Controls.Add(this.lblExploreTablesOrig);
            this.MainPanel.Controls.Add(this.dgvSelectFields);
            this.MainPanel.Controls.Add(this.lblExploreColumnsOrig);
            this.MainPanel.Location = new System.Drawing.Point(0, 31);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1177, 675);
            this.MainPanel.TabIndex = 25;
            // 
            // lblRemoveCustomField
            // 
            this.lblRemoveCustomField.BackColor = System.Drawing.Color.SeaGreen;
            this.lblRemoveCustomField.ForeColor = System.Drawing.Color.White;
            this.lblRemoveCustomField.Image = ((System.Drawing.Image)(resources.GetObject("lblRemoveCustomField.Image")));
            this.lblRemoveCustomField.Location = new System.Drawing.Point(970, 518);
            this.lblRemoveCustomField.Name = "lblRemoveCustomField";
            this.lblRemoveCustomField.Size = new System.Drawing.Size(29, 27);
            this.lblRemoveCustomField.TabIndex = 49;
            this.lblRemoveCustomField.Click += new System.EventHandler(this.lblRemoveCustomField_Click);
            // 
            // olvCustomField
            // 
            this.olvCustomField.AllColumns.Add(this.olvColumn5);
            this.olvCustomField.AllColumns.Add(this.olvColumn6);
            this.olvCustomField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.olvCustomField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.olvCustomField.CellEditUseWholeCell = false;
            this.olvCustomField.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn5,
            this.olvColumn6});
            this.olvCustomField.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvCustomField.ForeColor = System.Drawing.Color.White;
            this.olvCustomField.FullRowSelect = true;
            this.olvCustomField.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.olvCustomField.Location = new System.Drawing.Point(970, 545);
            this.olvCustomField.Name = "olvCustomField";
            this.olvCustomField.ShowGroups = false;
            this.olvCustomField.ShowItemToolTips = true;
            this.olvCustomField.Size = new System.Drawing.Size(206, 130);
            this.olvCustomField.TabIndex = 48;
            this.olvCustomField.UseCompatibleStateImageBehavior = false;
            this.olvCustomField.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Column";
            this.olvColumn5.MaximumWidth = 115;
            this.olvColumn5.MinimumWidth = 115;
            this.olvColumn5.Width = 115;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "DefaultValue";
            this.olvColumn6.MaximumWidth = 85;
            this.olvColumn6.MinimumWidth = 85;
            this.olvColumn6.Width = 85;
            // 
            // lblAddCustomField
            // 
            this.lblAddCustomField.BackColor = System.Drawing.Color.SeaGreen;
            this.lblAddCustomField.ForeColor = System.Drawing.Color.White;
            this.lblAddCustomField.Image = ((System.Drawing.Image)(resources.GetObject("lblAddCustomField.Image")));
            this.lblAddCustomField.Location = new System.Drawing.Point(1147, 518);
            this.lblAddCustomField.Name = "lblAddCustomField";
            this.lblAddCustomField.Size = new System.Drawing.Size(29, 27);
            this.lblAddCustomField.TabIndex = 47;
            this.lblAddCustomField.Click += new System.EventHandler(this.lblddCustomField_Click);
            // 
            // lblCustomFields
            // 
            this.lblCustomFields.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomFields.BackColor = System.Drawing.Color.SeaGreen;
            this.lblCustomFields.ForeColor = System.Drawing.Color.White;
            this.lblCustomFields.Location = new System.Drawing.Point(999, 518);
            this.lblCustomFields.Name = "lblCustomFields";
            this.lblCustomFields.Size = new System.Drawing.Size(148, 27);
            this.lblCustomFields.TabIndex = 46;
            this.lblCustomFields.Text = "Campos Customizados";
            this.lblCustomFields.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusText.ForeColor = System.Drawing.Color.White;
            this.lblStatusText.Location = new System.Drawing.Point(378, 12);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(61, 15);
            this.lblStatusText.TabIndex = 45;
            this.lblStatusText.Text = "StatusText";
            this.lblStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToolStrip
            // 
            this.ToolStrip.AutoSize = false;
            this.ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProject,
            this.tscbProjects,
            this.conectarToolStripMenuItem,
            this.gerarToolStripMenuItem,
            this.salvarToolStripMenuItem});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1177, 39);
            this.ToolStrip.TabIndex = 26;
            this.ToolStrip.Text = "menuStrip1";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(67, 35);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // gerarToolStripMenuItem
            // 
            this.gerarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esteScriptToolStripMenuItem,
            this.todosToolStripMenuItem,
            this.todosParaTxtToolStripMenuItem});
            this.gerarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gerarToolStripMenuItem.Name = "gerarToolStripMenuItem";
            this.gerarToolStripMenuItem.Size = new System.Drawing.Size(47, 35);
            this.gerarToolStripMenuItem.Text = "Gerar";
            // 
            // esteScriptToolStripMenuItem
            // 
            this.esteScriptToolStripMenuItem.Name = "esteScriptToolStripMenuItem";
            this.esteScriptToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.esteScriptToolStripMenuItem.Text = "Este script";
            this.esteScriptToolStripMenuItem.Click += new System.EventHandler(this.esteScriptToolStripMenuItem_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // todosParaTxtToolStripMenuItem
            // 
            this.todosParaTxtToolStripMenuItem.Name = "todosParaTxtToolStripMenuItem";
            this.todosParaTxtToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.todosParaTxtToolStripMenuItem.Text = "Todos para txt";
            this.todosParaTxtToolStripMenuItem.Click += new System.EventHandler(this.todosParaTxtToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(50, 35);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // MainForm
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
            this.Name = "MainForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.olvCustomField)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblProgramTitle;
        private Label label4;
        private Label lblSaveState;
        private Label lblExploreColumnsOrig;
        private DataGridView dgvSelectFields;
        private Label lblExploreTablesOrig;
        private RichTextBox rtbInsert;
        private RichTextBox rtbFrom;
        private Label lblExploreTablesDest;
        private MenuStrip miniToolStrip;
        private ToolStripMenuItem tsmiProject;
        private ToolStripComboBox tscbProjects;
        private Label lbOrderInsert;
        private Label label1;
        private Label lblDiv1;
        private Label lvlDiv2;
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
        private DataGridViewTextBoxColumn colOrigColumn;
        private DataGridViewTextBoxColumn colDefaultValue;
        private DataGridViewTextBoxColumn colAs;
        private DataGridViewTextBoxColumn colColumn;
        private DataGridViewTextBoxColumn colColumnType;
        private ToolStripMenuItem conectarToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem gerarToolStripMenuItem;
        private ToolStripMenuItem esteScriptToolStripMenuItem;
        private ToolStripMenuItem todosToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripMenuItem todosParaTxtToolStripMenuItem;
        public Label lblStatusText;
        private Label lblAddCustomField;
        private Label lblCustomFields;
        private BrightIdeasSoftware.ObjectListView olvCustomField;
        private Label lblRemoveCustomField;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private Label label2;

    }
}

