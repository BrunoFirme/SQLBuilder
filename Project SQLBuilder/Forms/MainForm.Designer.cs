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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FormHeader = new System.Windows.Forms.Panel();
            this.btnResize = new System.Windows.Forms.Button();
            this.MainMenuToolStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiProject = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbProjects = new System.Windows.Forms.ToolStripComboBox();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esteScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosParaTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBottomState = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panelSelectGrid = new System.Windows.Forms.Panel();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.dgvSelectFields = new System.Windows.Forms.DataGridView();
            this.colOrigColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Div5 = new System.Windows.Forms.Panel();
            this.panelFrom = new System.Windows.Forms.Panel();
            this.rtbFrom = new System.Windows.Forms.RichTextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.Div4 = new System.Windows.Forms.Panel();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.rtbInsert = new System.Windows.Forms.RichTextBox();
            this.lblInsert = new System.Windows.Forms.Label();
            this.Div2 = new System.Windows.Forms.Panel();
            this.Div1 = new System.Windows.Forms.Panel();
            this.lblOrigPanelIndicator = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dlvDestTables = new BrightIdeasSoftware.DataListView();
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lbOrderInsert = new System.Windows.Forms.Label();
            this.olvInsertTable = new BrightIdeasSoftware.ObjectListView();
            this.olvTable = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvOrder = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panelCustomFieldTitleButtons = new System.Windows.Forms.Panel();
            this.lblCustomFields = new System.Windows.Forms.Label();
            this.lblAddCustomField = new System.Windows.Forms.Label();
            this.lblRemoveCustomField = new System.Windows.Forms.Label();
            this.olvCustomField = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblExploreTablesDest = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.dlvOrigColumns = new BrightIdeasSoftware.DataListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblExploreColumnsOrig = new System.Windows.Forms.Label();
            this.dlvOrigTables = new BrightIdeasSoftware.DataListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblExploreTablesOrig = new System.Windows.Forms.Label();
            this.Div3 = new System.Windows.Forms.Panel();
            this.Div6 = new System.Windows.Forms.Panel();
            this.FormHeader.SuspendLayout();
            this.MainMenuToolStrip.SuspendLayout();
            this.panelBottomState.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panelSelectGrid.SuspendLayout();
            this.panelSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectFields)).BeginInit();
            this.panelFrom.SuspendLayout();
            this.panelInsert.SuspendLayout();
            this.Div1.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlvDestTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvInsertTable)).BeginInit();
            this.panelCustomFieldTitleButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCustomField)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrigColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrigTables)).BeginInit();
            this.SuspendLayout();
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
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStatusText.ForeColor = System.Drawing.Color.White;
            this.lblStatusText.Location = new System.Drawing.Point(0, 0);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(77, 20);
            this.lblStatusText.TabIndex = 45;
            this.lblStatusText.Text = "StatusText";
            this.lblStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(955, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(897, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 30);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(984, 2);
            this.label4.TabIndex = 38;
            this.label4.Text = "label4";
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
            // FormHeader
            // 
            this.FormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.FormHeader.Controls.Add(this.label2);
            this.FormHeader.Controls.Add(this.lblProgramTitle);
            this.FormHeader.Controls.Add(this.btnMinimize);
            this.FormHeader.Controls.Add(this.btnResize);
            this.FormHeader.Controls.Add(this.btnClose);
            this.FormHeader.Controls.Add(this.label4);
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormHeader.Location = new System.Drawing.Point(0, 0);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(984, 32);
            this.FormHeader.TabIndex = 0;
            this.FormHeader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormHeader_MouseDoubleClick);
            this.FormHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // btnResize
            // 
            this.btnResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnResize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResize.FlatAppearance.BorderSize = 0;
            this.btnResize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResize.ForeColor = System.Drawing.Color.White;
            this.btnResize.Image = ((System.Drawing.Image)(resources.GetObject("btnResize.Image")));
            this.btnResize.Location = new System.Drawing.Point(926, 0);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(29, 30);
            this.btnResize.TabIndex = 40;
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // MainMenuToolStrip
            // 
            this.MainMenuToolStrip.AutoSize = false;
            this.MainMenuToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.MainMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProject,
            this.tscbProjects,
            this.conectarToolStripMenuItem,
            this.gerarToolStripMenuItem,
            this.salvarToolStripMenuItem});
            this.MainMenuToolStrip.Location = new System.Drawing.Point(0, 32);
            this.MainMenuToolStrip.Name = "MainMenuToolStrip";
            this.MainMenuToolStrip.Size = new System.Drawing.Size(984, 39);
            this.MainMenuToolStrip.TabIndex = 27;
            this.MainMenuToolStrip.Text = "menuStrip1";
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
            // panelBottomState
            // 
            this.panelBottomState.BackColor = System.Drawing.Color.DarkGreen;
            this.panelBottomState.Controls.Add(this.lblStatusText);
            this.panelBottomState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomState.Location = new System.Drawing.Point(0, 660);
            this.panelBottomState.Name = "panelBottomState";
            this.panelBottomState.Size = new System.Drawing.Size(984, 24);
            this.panelBottomState.TabIndex = 48;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.DarkGray;
            this.MainPanel.Controls.Add(this.panelSelectGrid);
            this.MainPanel.Controls.Add(this.panelRight);
            this.MainPanel.Controls.Add(this.panelLeft);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 73);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(984, 577);
            this.MainPanel.TabIndex = 49;
            // 
            // panelSelectGrid
            // 
            this.panelSelectGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelSelectGrid.Controls.Add(this.panelSelect);
            this.panelSelectGrid.Controls.Add(this.Div5);
            this.panelSelectGrid.Controls.Add(this.panelFrom);
            this.panelSelectGrid.Controls.Add(this.Div4);
            this.panelSelectGrid.Controls.Add(this.panelInsert);
            this.panelSelectGrid.Controls.Add(this.Div2);
            this.panelSelectGrid.Controls.Add(this.Div1);
            this.panelSelectGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelectGrid.Location = new System.Drawing.Point(230, 0);
            this.panelSelectGrid.Name = "panelSelectGrid";
            this.panelSelectGrid.Size = new System.Drawing.Size(524, 577);
            this.panelSelectGrid.TabIndex = 52;
            // 
            // panelSelect
            // 
            this.panelSelect.Controls.Add(this.dgvSelectFields);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelect.Location = new System.Drawing.Point(10, 160);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(504, 262);
            this.panelSelect.TabIndex = 49;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvSelectFields.ColumnHeadersHeight = 20;
            this.dgvSelectFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSelectFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrigColumn,
            this.colDefaultValue,
            this.colAs,
            this.colColumn,
            this.colColumnType});
            this.dgvSelectFields.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectFields.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvSelectFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectFields.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSelectFields.EnableHeadersVisualStyles = false;
            this.dgvSelectFields.Location = new System.Drawing.Point(0, 0);
            this.dgvSelectFields.MultiSelect = false;
            this.dgvSelectFields.Name = "dgvSelectFields";
            this.dgvSelectFields.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSelectFields.RowHeadersVisible = false;
            this.dgvSelectFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSelectFields.Size = new System.Drawing.Size(504, 262);
            this.dgvSelectFields.TabIndex = 4;
            this.dgvSelectFields.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectFields_CellValueChanged);
            // 
            // colOrigColumn
            // 
            this.colOrigColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOrigColumn.DataPropertyName = "colNullValue";
            this.colOrigColumn.FillWeight = 7.198624F;
            this.colOrigColumn.HeaderText = "COLUNA ORIGEM";
            this.colOrigColumn.MinimumWidth = 140;
            this.colOrigColumn.Name = "colOrigColumn";
            this.colOrigColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colOrigColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colOrigColumn.ToolTipText = "Coluna da base original para converter";
            this.colOrigColumn.Width = 140;
            // 
            // colDefaultValue
            // 
            this.colDefaultValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDefaultValue.DataPropertyName = "colDefaultValue";
            this.colDefaultValue.FillWeight = 224.597F;
            this.colDefaultValue.HeaderText = "PADRÃO";
            this.colDefaultValue.MinimumWidth = 100;
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
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            this.colColumn.DefaultCellStyle = dataGridViewCellStyle23;
            this.colColumn.FillWeight = 7.198624F;
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
            this.colColumnType.FillWeight = 7.198624F;
            this.colColumnType.HeaderText = "FORMATO";
            this.colColumnType.Name = "colColumnType";
            this.colColumnType.ReadOnly = true;
            this.colColumnType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colColumnType.ToolTipText = "Formato do campo destino";
            // 
            // Div5
            // 
            this.Div5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Div5.Location = new System.Drawing.Point(10, 422);
            this.Div5.Name = "Div5";
            this.Div5.Size = new System.Drawing.Size(504, 10);
            this.Div5.TabIndex = 52;
            // 
            // panelFrom
            // 
            this.panelFrom.Controls.Add(this.rtbFrom);
            this.panelFrom.Controls.Add(this.lblFrom);
            this.panelFrom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFrom.Location = new System.Drawing.Point(10, 432);
            this.panelFrom.Name = "panelFrom";
            this.panelFrom.Size = new System.Drawing.Size(504, 145);
            this.panelFrom.TabIndex = 51;
            // 
            // rtbFrom
            // 
            this.rtbFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rtbFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rtbFrom.ForeColor = System.Drawing.Color.White;
            this.rtbFrom.Location = new System.Drawing.Point(0, 23);
            this.rtbFrom.Name = "rtbFrom";
            this.rtbFrom.Size = new System.Drawing.Size(504, 122);
            this.rtbFrom.TabIndex = 42;
            this.rtbFrom.Text = "";
            this.rtbFrom.TextChanged += new System.EventHandler(this.rtbFrom_TextChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(0, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(504, 23);
            this.lblFrom.TabIndex = 41;
            this.lblFrom.Text = "FROM";
            // 
            // Div4
            // 
            this.Div4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Div4.Location = new System.Drawing.Point(10, 150);
            this.Div4.Name = "Div4";
            this.Div4.Size = new System.Drawing.Size(504, 10);
            this.Div4.TabIndex = 48;
            // 
            // panelInsert
            // 
            this.panelInsert.Controls.Add(this.rtbInsert);
            this.panelInsert.Controls.Add(this.lblInsert);
            this.panelInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInsert.Location = new System.Drawing.Point(10, 0);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(504, 150);
            this.panelInsert.TabIndex = 47;
            // 
            // rtbInsert
            // 
            this.rtbInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rtbInsert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInsert.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rtbInsert.ForeColor = System.Drawing.Color.White;
            this.rtbInsert.Location = new System.Drawing.Point(0, 0);
            this.rtbInsert.Name = "rtbInsert";
            this.rtbInsert.Size = new System.Drawing.Size(504, 127);
            this.rtbInsert.TabIndex = 41;
            this.rtbInsert.Text = "";
            this.rtbInsert.TextChanged += new System.EventHandler(this.rtbInsert_TextChanged);
            // 
            // lblInsert
            // 
            this.lblInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInsert.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsert.ForeColor = System.Drawing.Color.White;
            this.lblInsert.Location = new System.Drawing.Point(0, 127);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(504, 23);
            this.lblInsert.TabIndex = 40;
            this.lblInsert.Text = "INSERT INTO";
            // 
            // Div2
            // 
            this.Div2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Div2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Div2.Location = new System.Drawing.Point(514, 0);
            this.Div2.Name = "Div2";
            this.Div2.Size = new System.Drawing.Size(10, 577);
            this.Div2.TabIndex = 44;
            // 
            // Div1
            // 
            this.Div1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Div1.Controls.Add(this.lblOrigPanelIndicator);
            this.Div1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Div1.Location = new System.Drawing.Point(0, 0);
            this.Div1.Name = "Div1";
            this.Div1.Size = new System.Drawing.Size(10, 577);
            this.Div1.TabIndex = 43;
            this.Div1.Click += new System.EventHandler(this.Div1_Click);
            this.Div1.MouseEnter += new System.EventHandler(this.Div1_MouseEnter);
            this.Div1.MouseLeave += new System.EventHandler(this.Div1_MouseLeave);
            // 
            // lblOrigPanelIndicator
            // 
            this.lblOrigPanelIndicator.Location = new System.Drawing.Point(-4, 0);
            this.lblOrigPanelIndicator.Name = "lblOrigPanelIndicator";
            this.lblOrigPanelIndicator.Size = new System.Drawing.Size(10, 60);
            this.lblOrigPanelIndicator.TabIndex = 42;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelRight.Controls.Add(this.dlvDestTables);
            this.panelRight.Controls.Add(this.lbOrderInsert);
            this.panelRight.Controls.Add(this.olvInsertTable);
            this.panelRight.Controls.Add(this.panelCustomFieldTitleButtons);
            this.panelRight.Controls.Add(this.olvCustomField);
            this.panelRight.Controls.Add(this.lblExploreTablesDest);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(754, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(230, 577);
            this.panelRight.TabIndex = 51;
            // 
            // dlvDestTables
            // 
            this.dlvDestTables.AllColumns.Add(this.olvColumn3);
            this.dlvDestTables.AutoGenerateColumns = false;
            this.dlvDestTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dlvDestTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dlvDestTables.CellEditUseWholeCell = false;
            this.dlvDestTables.CheckBoxes = true;
            this.dlvDestTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn3});
            this.dlvDestTables.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlvDestTables.DataSource = null;
            this.dlvDestTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dlvDestTables.ForeColor = System.Drawing.Color.White;
            this.dlvDestTables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.dlvDestTables.Location = new System.Drawing.Point(0, 30);
            this.dlvDestTables.MultiSelect = false;
            this.dlvDestTables.Name = "dlvDestTables";
            this.dlvDestTables.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dlvDestTables.ShowGroups = false;
            this.dlvDestTables.Size = new System.Drawing.Size(230, 154);
            this.dlvDestTables.TabIndex = 39;
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
            this.olvColumn3.FillsFreeSpace = true;
            this.olvColumn3.MaximumWidth = 210;
            this.olvColumn3.MinimumWidth = 210;
            this.olvColumn3.Text = "Tabela";
            this.olvColumn3.Width = 210;
            // 
            // lbOrderInsert
            // 
            this.lbOrderInsert.BackColor = System.Drawing.Color.SeaGreen;
            this.lbOrderInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbOrderInsert.ForeColor = System.Drawing.Color.White;
            this.lbOrderInsert.Location = new System.Drawing.Point(0, 184);
            this.lbOrderInsert.Name = "lbOrderInsert";
            this.lbOrderInsert.Size = new System.Drawing.Size(230, 30);
            this.lbOrderInsert.TabIndex = 40;
            this.lbOrderInsert.Text = "Ordem de Inserções";
            this.lbOrderInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // olvInsertTable
            // 
            this.olvInsertTable.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.olvInsertTable.AllColumns.Add(this.olvTable);
            this.olvInsertTable.AllColumns.Add(this.olvOrder);
            this.olvInsertTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.olvInsertTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.olvInsertTable.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvInsertTable.CellEditUseWholeCell = false;
            this.olvInsertTable.CheckBoxes = true;
            this.olvInsertTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvTable,
            this.olvOrder});
            this.olvInsertTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvInsertTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.olvInsertTable.ForeColor = System.Drawing.Color.White;
            this.olvInsertTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.olvInsertTable.IsSimpleDragSource = true;
            this.olvInsertTable.IsSimpleDropSink = true;
            this.olvInsertTable.Location = new System.Drawing.Point(0, 214);
            this.olvInsertTable.MultiSelect = false;
            this.olvInsertTable.Name = "olvInsertTable";
            this.olvInsertTable.ShowGroups = false;
            this.olvInsertTable.Size = new System.Drawing.Size(230, 203);
            this.olvInsertTable.TabIndex = 41;
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
            // panelCustomFieldTitleButtons
            // 
            this.panelCustomFieldTitleButtons.Controls.Add(this.lblCustomFields);
            this.panelCustomFieldTitleButtons.Controls.Add(this.lblAddCustomField);
            this.panelCustomFieldTitleButtons.Controls.Add(this.lblRemoveCustomField);
            this.panelCustomFieldTitleButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCustomFieldTitleButtons.Location = new System.Drawing.Point(0, 417);
            this.panelCustomFieldTitleButtons.Name = "panelCustomFieldTitleButtons";
            this.panelCustomFieldTitleButtons.Size = new System.Drawing.Size(230, 30);
            this.panelCustomFieldTitleButtons.TabIndex = 42;
            // 
            // lblCustomFields
            // 
            this.lblCustomFields.BackColor = System.Drawing.Color.SeaGreen;
            this.lblCustomFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomFields.ForeColor = System.Drawing.Color.White;
            this.lblCustomFields.Location = new System.Drawing.Point(29, 0);
            this.lblCustomFields.Name = "lblCustomFields";
            this.lblCustomFields.Size = new System.Drawing.Size(172, 30);
            this.lblCustomFields.TabIndex = 47;
            this.lblCustomFields.Text = "Campos Customizados";
            this.lblCustomFields.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddCustomField
            // 
            this.lblAddCustomField.BackColor = System.Drawing.Color.SeaGreen;
            this.lblAddCustomField.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAddCustomField.ForeColor = System.Drawing.Color.White;
            this.lblAddCustomField.Image = ((System.Drawing.Image)(resources.GetObject("lblAddCustomField.Image")));
            this.lblAddCustomField.Location = new System.Drawing.Point(201, 0);
            this.lblAddCustomField.Name = "lblAddCustomField";
            this.lblAddCustomField.Size = new System.Drawing.Size(29, 30);
            this.lblAddCustomField.TabIndex = 47;
            this.lblAddCustomField.Click += new System.EventHandler(this.lblddCustomField_Click);
            // 
            // lblRemoveCustomField
            // 
            this.lblRemoveCustomField.BackColor = System.Drawing.Color.SeaGreen;
            this.lblRemoveCustomField.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRemoveCustomField.ForeColor = System.Drawing.Color.White;
            this.lblRemoveCustomField.Image = ((System.Drawing.Image)(resources.GetObject("lblRemoveCustomField.Image")));
            this.lblRemoveCustomField.Location = new System.Drawing.Point(0, 0);
            this.lblRemoveCustomField.Name = "lblRemoveCustomField";
            this.lblRemoveCustomField.Size = new System.Drawing.Size(29, 30);
            this.lblRemoveCustomField.TabIndex = 49;
            this.lblRemoveCustomField.Click += new System.EventHandler(this.lblRemoveCustomField_Click);
            // 
            // olvCustomField
            // 
            this.olvCustomField.AllColumns.Add(this.olvColumn5);
            this.olvCustomField.AllColumns.Add(this.olvColumn6);
            this.olvCustomField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.olvCustomField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.olvCustomField.CellEditUseWholeCell = false;
            this.olvCustomField.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn5,
            this.olvColumn6});
            this.olvCustomField.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvCustomField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.olvCustomField.ForeColor = System.Drawing.Color.White;
            this.olvCustomField.FullRowSelect = true;
            this.olvCustomField.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.olvCustomField.Location = new System.Drawing.Point(0, 447);
            this.olvCustomField.Name = "olvCustomField";
            this.olvCustomField.ShowGroups = false;
            this.olvCustomField.ShowItemToolTips = true;
            this.olvCustomField.Size = new System.Drawing.Size(230, 130);
            this.olvCustomField.TabIndex = 52;
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
            // lblExploreTablesDest
            // 
            this.lblExploreTablesDest.BackColor = System.Drawing.Color.SeaGreen;
            this.lblExploreTablesDest.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExploreTablesDest.ForeColor = System.Drawing.Color.White;
            this.lblExploreTablesDest.Location = new System.Drawing.Point(0, 0);
            this.lblExploreTablesDest.Name = "lblExploreTablesDest";
            this.lblExploreTablesDest.Size = new System.Drawing.Size(230, 30);
            this.lblExploreTablesDest.TabIndex = 20;
            this.lblExploreTablesDest.Text = "Seleção de Tabelas Destino";
            this.lblExploreTablesDest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelLeft.Controls.Add(this.dlvOrigColumns);
            this.panelLeft.Controls.Add(this.lblExploreColumnsOrig);
            this.panelLeft.Controls.Add(this.dlvOrigTables);
            this.panelLeft.Controls.Add(this.lblExploreTablesOrig);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(230, 577);
            this.panelLeft.TabIndex = 50;
            // 
            // dlvOrigColumns
            // 
            this.dlvOrigColumns.AllColumns.Add(this.olvColumn2);
            this.dlvOrigColumns.AllColumns.Add(this.olvColumn4);
            this.dlvOrigColumns.AutoGenerateColumns = false;
            this.dlvOrigColumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dlvOrigColumns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dlvOrigColumns.CellEditUseWholeCell = false;
            this.dlvOrigColumns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2,
            this.olvColumn4});
            this.dlvOrigColumns.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlvOrigColumns.DataSource = null;
            this.dlvOrigColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dlvOrigColumns.ForeColor = System.Drawing.Color.White;
            this.dlvOrigColumns.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.dlvOrigColumns.Location = new System.Drawing.Point(0, 251);
            this.dlvOrigColumns.MultiSelect = false;
            this.dlvOrigColumns.Name = "dlvOrigColumns";
            this.dlvOrigColumns.ShowGroups = false;
            this.dlvOrigColumns.ShowItemToolTips = true;
            this.dlvOrigColumns.Size = new System.Drawing.Size(230, 326);
            this.dlvOrigColumns.TabIndex = 47;
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
            // lblExploreColumnsOrig
            // 
            this.lblExploreColumnsOrig.BackColor = System.Drawing.Color.SteelBlue;
            this.lblExploreColumnsOrig.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExploreColumnsOrig.ForeColor = System.Drawing.Color.White;
            this.lblExploreColumnsOrig.Location = new System.Drawing.Point(0, 221);
            this.lblExploreColumnsOrig.Name = "lblExploreColumnsOrig";
            this.lblExploreColumnsOrig.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblExploreColumnsOrig.Size = new System.Drawing.Size(230, 30);
            this.lblExploreColumnsOrig.TabIndex = 46;
            this.lblExploreColumnsOrig.Text = "Explorador de Colunas";
            this.lblExploreColumnsOrig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dlvOrigTables
            // 
            this.dlvOrigTables.AllColumns.Add(this.olvColumn1);
            this.dlvOrigTables.AutoGenerateColumns = false;
            this.dlvOrigTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dlvOrigTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dlvOrigTables.CellEditUseWholeCell = false;
            this.dlvOrigTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1});
            this.dlvOrigTables.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlvOrigTables.DataSource = null;
            this.dlvOrigTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.dlvOrigTables.ForeColor = System.Drawing.Color.White;
            this.dlvOrigTables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.dlvOrigTables.Location = new System.Drawing.Point(0, 30);
            this.dlvOrigTables.MultiSelect = false;
            this.dlvOrigTables.Name = "dlvOrigTables";
            this.dlvOrigTables.ShowGroups = false;
            this.dlvOrigTables.Size = new System.Drawing.Size(230, 191);
            this.dlvOrigTables.TabIndex = 45;
            this.dlvOrigTables.UseCompatibleStateImageBehavior = false;
            this.dlvOrigTables.UseExplorerTheme = true;
            this.dlvOrigTables.View = System.Windows.Forms.View.Details;
            this.dlvOrigTables.SelectedIndexChanged += new System.EventHandler(this.dlvOrigTables_SelectionChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "colTable";
            this.olvColumn1.IsVisible = false;
            this.olvColumn1.MaximumWidth = 210;
            this.olvColumn1.MinimumWidth = 210;
            this.olvColumn1.Text = "Tabela";
            this.olvColumn1.Width = 210;
            // 
            // lblExploreTablesOrig
            // 
            this.lblExploreTablesOrig.BackColor = System.Drawing.Color.SteelBlue;
            this.lblExploreTablesOrig.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExploreTablesOrig.ForeColor = System.Drawing.Color.White;
            this.lblExploreTablesOrig.Location = new System.Drawing.Point(0, 0);
            this.lblExploreTablesOrig.Name = "lblExploreTablesOrig";
            this.lblExploreTablesOrig.Size = new System.Drawing.Size(230, 30);
            this.lblExploreTablesOrig.TabIndex = 44;
            this.lblExploreTablesOrig.Text = "Explorador de Tabelas Origem";
            this.lblExploreTablesOrig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Div3
            // 
            this.Div3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Div3.Location = new System.Drawing.Point(0, 71);
            this.Div3.Name = "Div3";
            this.Div3.Size = new System.Drawing.Size(984, 2);
            this.Div3.TabIndex = 51;
            // 
            // Div6
            // 
            this.Div6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Div6.Location = new System.Drawing.Point(0, 650);
            this.Div6.Name = "Div6";
            this.Div6.Size = new System.Drawing.Size(984, 10);
            this.Div6.TabIndex = 53;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(984, 684);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Div6);
            this.Controls.Add(this.Div3);
            this.Controls.Add(this.panelBottomState);
            this.Controls.Add(this.MainMenuToolStrip);
            this.Controls.Add(this.FormHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormHeader.ResumeLayout(false);
            this.FormHeader.PerformLayout();
            this.MainMenuToolStrip.ResumeLayout(false);
            this.MainMenuToolStrip.PerformLayout();
            this.panelBottomState.ResumeLayout(false);
            this.panelBottomState.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.panelSelectGrid.ResumeLayout(false);
            this.panelSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectFields)).EndInit();
            this.panelFrom.ResumeLayout(false);
            this.panelInsert.ResumeLayout(false);
            this.Div1.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlvDestTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvInsertTable)).EndInit();
            this.panelCustomFieldTitleButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvCustomField)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrigColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrigTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip miniToolStrip;
        public Label lblStatusText;
        private Button btnClose;
        private Button btnMinimize;
        private Label lblProgramTitle;
        private Label label4;
        private Label label2;
        private Panel FormHeader;
        private MenuStrip MainMenuToolStrip;
        private ToolStripMenuItem tsmiProject;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripComboBox tscbProjects;
        private ToolStripMenuItem conectarToolStripMenuItem;
        private ToolStripMenuItem gerarToolStripMenuItem;
        private ToolStripMenuItem esteScriptToolStripMenuItem;
        private ToolStripMenuItem todosToolStripMenuItem;
        private ToolStripMenuItem todosParaTxtToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        public Panel panelBottomState;
        private Panel MainPanel;
        private Panel panelRight;
        private Panel panelLeft;
        private BrightIdeasSoftware.DataListView dlvOrigColumns;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private Label lblExploreColumnsOrig;
        private BrightIdeasSoftware.DataListView dlvOrigTables;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private Label lblExploreTablesOrig;
        private Label lblFrom;
        private Label lblExploreTablesDest;
        private Label lbOrderInsert;
        private BrightIdeasSoftware.DataListView dlvDestTables;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private Panel panelSelectGrid;
        private Panel Div4;
        private Panel panelInsert;
        private RichTextBox rtbInsert;
        private Label lblInsert;
        private Panel Div2;
        private Panel Div1;
        private BrightIdeasSoftware.ObjectListView olvCustomField;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private Panel panelCustomFieldTitleButtons;
        private Label lblCustomFields;
        private Label lblAddCustomField;
        private Label lblRemoveCustomField;
        private BrightIdeasSoftware.ObjectListView olvInsertTable;
        private BrightIdeasSoftware.OLVColumn olvTable;
        private BrightIdeasSoftware.OLVColumn olvOrder;
        private Panel Div5;
        private Panel panelFrom;
        private RichTextBox rtbFrom;
        private Panel panelSelect;
        private DataGridView dgvSelectFields;
        private Panel Div3;
        private Panel Div6;
        private DataGridViewTextBoxColumn colOrigColumn;
        private DataGridViewTextBoxColumn colDefaultValue;
        private DataGridViewTextBoxColumn colAs;
        private DataGridViewTextBoxColumn colColumn;
        private DataGridViewTextBoxColumn colColumnType;
        private Button btnResize;
        private Label lblOrigPanelIndicator;

    }
}

