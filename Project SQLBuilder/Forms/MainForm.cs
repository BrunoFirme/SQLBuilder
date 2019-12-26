using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Project_SQLBuilder.Interfaces;
using SQLBuilderModel;

namespace Project_SQLBuilder.Forms
{
    public partial class MainForm : Form
    {
        //Parameters used to know when its an UI transition and not user-input that should be saved in DB or reacted in some way.
        private bool _isUiChange;

        //Used to avoid wrong SaveState label coloring.
        private bool _isTableSwap;

        //Used for script generation.
        private string _currentTable = "";

        //Used to check if anything has changed in the script so the user doesnt leave without unnintentionaly not saving.
        private bool _hasScriptChange;

        //Connections set in the connection form.
        public DataBaseConnectionForm ConfigForm;

        //Getters of data-base information, set in the DataBaseConnectionForm.
        public IConversionDataGetter OriginConn;
        public IConversionDataGetter DestinyConn;

        public MainForm()
        {
            InitializeComponent();
            _hasScriptChange = false;
            PopulateProjectsCmb();
            lblStatusText.Text = "";
            panelBottomState.BackColor = Color.FromArgb(45,45,45);
            RetractOriginTab();

        }

        #region Basic form functionality.

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized) WindowState = FormWindowState.Normal;
        }

        public void ExpandOriginTab()
        {
            panelLeft.Width = 230;
            lblOrigPanelIndicator.BackColor = Color.Transparent;
            lblExpandOrigin.BackColor = Color.Transparent;
        }

        public void RetractOriginTab()
        {
            panelLeft.Width = 0;
            lblOrigPanelIndicator.BackColor = Color.SteelBlue;
        }

        private void lblCloseOriginTab_Click(object sender, EventArgs e)
        {
            RetractOriginTab();
        }

        private void lblExpandOrigin_Click(object sender, EventArgs e)
        {
            if (panelLeft.Width == 0) ExpandOriginTab();
        }

        private void lblExpandOrigin_MouseEnter(object sender, EventArgs e)
        {
            if (panelLeft.Width == 0) lblExpandOrigin.BackColor = Color.SteelBlue;
            else
            {
                lblExpandOrigin.BackColor = Color.Transparent;
                lblOrigPanelIndicator.BackColor = Color.Transparent;
            }
            
        }

        private void lblExpandOrigin_MouseLeave(object sender, EventArgs e)
        {
            if (panelLeft.Width == 0)
            {
                lblOrigPanelIndicator.BackColor = Color.SteelBlue;
                lblExpandOrigin.BackColor = Color.Transparent;
            }
            else
            {
                lblExpandOrigin.BackColor = Color.Transparent;
                lblOrigPanelIndicator.BackColor = Color.Transparent;
            }
        }

        private void FormHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized) WindowState = FormWindowState.Normal;
        }

        private void dgvSelectFields_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvSelectFields.IsCurrentCellDirty)
            {
                dgvSelectFields.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        //Open connection form.
        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfigForm == null)
            {
                ConfigForm = new DataBaseConnectionForm(this);
                ConfigForm.Show();
            }
            else
            {
                ConfigForm.Close();
                ConfigForm = null;
            }
        }

        //Apply color change to SaveState label when a change occurs to data in SelectField.
        private void rtbInsert_TextChanged(object sender, EventArgs e)
        {
            if (_isTableSwap) return;
            panelBottomState.BackColor = Color.DarkOrange;
            lblStatusText.Text = @"Alterado...";
            _hasScriptChange = true;

        }

        private void rtbFrom_TextChanged(object sender, EventArgs e)
        {
            if (_isTableSwap) return;
            panelBottomState.BackColor = Color.DarkOrange;
            lblStatusText.Text = @"Alterado...";
            _hasScriptChange = true;
        }

        private void dgvSelectFields_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_isTableSwap) return;
            panelBottomState.BackColor = Color.DarkOrange;
            lblStatusText.Text = @"Alterado...";
            _hasScriptChange = true;
        }

        #endregion

        #region ListViews related functions.

        //Populate list of origin data-base tables.
        public void PopulateOriginTables()
        {
            dlvOrigTables.DataSource = OriginConn.SelectTables();
        }

        //Populate list of destiny data-base tables
        public void PopulateDestinyTables()
        {
            dlvDestTables.DataSource = DestinyConn.SelectTables();

            _isUiChange = true;
            CheckInsertTables();
            _isUiChange = false;
        }

        //Populate list of origin data-base columns and types.
        private void dlvOrigTables_SelectionChanged(object sender, EventArgs e)
        {
            if (dlvOrigTables.SelectedItem == null) return;

            if (OriginConn == null) return;
            dlvOrigColumns.DataSource = OriginConn.SelectColumns(dlvOrigTables.SelectedItem.Text, null);
        }

        //Call method to populate SelectGrid with destiny table data.
        private void dlvDestTables_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dlvDestTables.SelectedItem == null) return;

            if (_hasScriptChange)
            {
                AlertUnsavedChanges();
                return;
            }

            _currentTable = dlvDestTables.SelectedItem.Text;
            PopulateSelectField();
        }

        //Call method to populate SelectGrid with destiny table data.
        private void olvInsertTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (olvInsertTable.SelectedItem == null) return;

            if (_hasScriptChange)
            {
                AlertUnsavedChanges();
                return;
            }

            _currentTable = olvInsertTable.SelectedItem.Text;
            PopulateSelectField();
        }

        //Check if connection is open and if so, populate SelectGrid with the columns. Calls UpdateSelectFieldtoProjectState at the end to check persistence.
        private void PopulateSelectField()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            if (DestinyConn == null)
            {
                panelBottomState.BackColor = Color.DarkRed;
                lblStatusText.Text =
                    @"Não há conexão com o banco de dados destino. Por favor conecte-se para recuperar as informações do banco.";
                return;
            }
            if (tscbProjects.SelectedIndex == -1) return;

            //Avoid incorrect color painting of saving indicator. This parameter for the process of table change. 
            _isTableSwap = true;

            CleanSelectField();

            var context = new Entities();
            dgvSelectFields.DataSource = DestinyConn.SelectColumns(_currentTable, context.CustomFields.Where(x => x.InsertTable.Table == _currentTable && x.InsertTable.FkProject == pId));
            lblInsert.Text = @"INSERT INTO " + _currentTable;

            UpdateSelectFieldtoProjectState();
        }

        //Checks if table loaded to SelectGrid has data saved in data-base, if so calls the appropriate loading methods and paint the SaveState accordingly.
        private void UpdateSelectFieldtoProjectState()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            //Check if table has been saved already, if so load its data, if not show its SaveStatus of not saved.
            if (context.SelectFields.Any(x =>
                x.InsertTable.Table == _currentTable && x.InsertTable.FkProject == pId))
            {
                LoadSelectFieldExpressions();
                PopulateCustomFields();
                panelBottomState.BackColor = Color.DarkGreen;
                lblStatusText.Text = @"Campos estão atualizados no banco.";
                _isTableSwap = false;
            }
            else
            {
                olvCustomField.ClearObjects();
                panelBottomState.BackColor = Color.DarkOrange;
                lblStatusText.Text = @"Campos não salvos.";
                _isTableSwap = false;
            }

            //Verify if the last column is saved on the data-base. This is to prevent wrong coloring when user has added a column but no saved it yet in DB "select_fields".
            var lastAddedColumn = dgvSelectFields[3, dgvSelectFields.RowCount - 1].Value.ToString();
            if (!context.SelectFields.Any(x =>
                x.Column == lastAddedColumn && x.InsertTable.Table == _currentTable && x.InsertTable.FkProject == pId))
            {
                panelBottomState.BackColor = Color.DarkOrange;
                lblStatusText.Text = @"Campos não salvos.";
                _isTableSwap = false;
            }
        }

        //Clean all SelectGrid cells and textboxes of any table/user data, as to prepare for a new table.
        private void CleanSelectField()
        {
            rtbFrom.Text = null;
            rtbInsert.Text = null;

            //This little trick clears the rows without fucking up column names (damn datagrid and data-sources)
            if (dgvSelectFields.DataSource == null) return;
            var dt = dgvSelectFields.DataSource as DataTable;
            // ReSharper disable once PossibleNullReferenceException
            dt.Rows.Clear();
            dgvSelectFields.DataSource = dt;
        }

        //Clears lists and connections to set up a fresh screen.
        private void ClearAll()
        {
            dlvOrigTables.ClearObjects();
            dlvOrigColumns.ClearObjects();
            dlvDestTables.ClearObjects();
            olvInsertTable.ClearObjects();
            olvCustomField.ClearObjects();
            rtbFrom.Text = null;
            rtbInsert.Text = null;
            lblInsert.Text = @"INSERT INTO";
            _currentTable = "";
            lblStatusText.Text = @"";
            panelBottomState.BackColor = Color.DarkGreen;
            DestinyConn = null;
            OriginConn = null;

            //This little trick clears the rows without fucking up column names (damn datagrid and data-sources)
            if (dgvSelectFields.DataSource == null) return;
            var dt = dgvSelectFields.DataSource as DataTable;
            // ReSharper disable once PossibleNullReferenceException
            dt.Rows.Clear();
            dgvSelectFields.DataSource = dt;
        }

        #endregion

        #region Project object related functions.

        private void PopulateProjectsCmb()
        {
            tscbProjects.Items.Clear();

            var context = new Entities();
            var query = from it in context.Projects orderby it.Name select it;

            foreach (var p in query)
            {
                tscbProjects.Items.Add(p.Name);
            }
        }

        public int GetCurrentProjectId()
        {
            var context = new Entities();

            var qfkProject = 0;

            if (tscbProjects.SelectedItem != null)
            {
                qfkProject = (from o in context.Projects
                    where o.Name == tscbProjects.SelectedItem.ToString()
                    select o.Id).Max();
            }

            return qfkProject;
        }

        //Create new project.
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var name = Interaction.InputBox("Nome do Projeto: ", "Novo Projeto", "*", 100, 100);

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(@"Nome Inválido");
                return;
            }

            var newProject = new Project()
            {
                Name = name
            };

            var context = new Entities();

            context.Projects.AddObject(newProject);

            context.SaveChanges();

            ClearAll();

            PopulateProjectsCmb();
        }

        //Delete existing selected project.
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            if (tscbProjects.SelectedIndex == -1)
            {
                panelBottomState.BackColor = Color.DarkRed;
                lblStatusText.Text = @"Nenhum projeto selecionado.";
                return;
            }

            var context = new Entities();

            var deleteProject = context.Projects.SingleOrDefault(x => x.Id == pId);

            if (deleteProject == null) return;

            if (MessageBox.Show(@"Deseja mesmo excluir o projeto " + deleteProject.Name + @"?", @"Alerta!",
                    MessageBoxButtons.YesNo) == DialogResult.No) return;

            context.Projects.DeleteObject(deleteProject);
            context.SaveChanges();

            PopulateProjectsCmb();

            tscbProjects.SelectedIndex = -1;

        }

        //Check destiny table checkboxes and load Insert_tables list.
        private void tscbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_hasScriptChange)
            {
                AlertUnsavedChanges();
                return;
            }

            _isUiChange = true;

            ClearAll();
            CheckInsertTables();
            PopulateInsertTablesList();

            _isUiChange = false;
        }

        #endregion

        #region Insert_table object related functions.

        //Populate InsertTables list with project selected tables.
        private void PopulateInsertTablesList()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            olvInsertTable.SetObjects(context.InsertTables.Where(x => x.FkProject == pId).OrderBy(x => x.Order));

            _isUiChange = true;
            olvInsertTable.CheckAll();
            _isUiChange = false;
        }

        //Check project tables in destiny data-base table's list.
        private void CheckInsertTables()
        {
            if (dlvDestTables.Items.Count != 0)
                dlvDestTables.UncheckAll();

            if (tscbProjects.SelectedItem == null) return;

            var pId = GetCurrentProjectId();
            var context = new Entities();
            var query = from it in context.InsertTables
                where it.FkProject == pId
                select it;

            foreach (var it in query)
            {
                for (var i = 0; i < dlvDestTables.GetItemCount(); i++)
                {
                    if (dlvDestTables.Items[i].Text == it.Table)
                    {
                        dlvDestTables.GetItem(i).Checked = true;
                    }
                }
            }
        }

        //Next two methods: Add or remove an Insert_Table entry in data-base based on item being checked on the Destiny Tables ListView.
        private void dlvDestTables_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            if (_isUiChange || tscbProjects.SelectedIndex == -1) return;

            var context = new Entities();
            var tablename = e.Item.Text;
            var updateTable =
                context.InsertTables.SingleOrDefault(x => x.Table == tablename && x.FkProject == pId);

            if (e.Item.Checked && updateTable == null)
            {
                InsertCheckedTableInProject(e.Item.Index);
            }
            else if (!e.Item.Checked)
            {
                DeleteUncheckedTableFromProject(e.Item.Text);
            }

            PopulateInsertTablesList();
        }

        private void olvInsertTable_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked || _isUiChange) return;
            DeleteUncheckedTableFromProject(e.Item.Text);

            for (var i = 0; i < dlvDestTables.GetItemCount(); i++)
            {
                if (dlvDestTables.Items[i].Text != e.Item.Text) continue;
                _isUiChange = true;
                dlvDestTables.GetItem(i).Checked = false;
                i = dlvDestTables.GetItemCount();
                _isUiChange = false;
            }
        }

        //Next two methods: Confirm table deletion from project.
        private void dlvDestTables_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_isUiChange) return;
            if (e.NewValue == CheckState.Checked) return;
            if (MessageBox.Show(@"Deseja mesmo excluir esta tabela e suas informações da conversão?", @"Alerta!",
                    MessageBoxButtons.YesNo) == DialogResult.No) e.NewValue = e.CurrentValue;
        }

        private void olvInsertTable_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_isUiChange) return;
            if (e.NewValue == CheckState.Checked) return;
            if (MessageBox.Show(@"Deseja mesmo excluir esta tabela e suas informações da conversão?", @"Alerta!",
                    MessageBoxButtons.YesNo) == DialogResult.No) e.NewValue = e.CurrentValue;
        }

        //Takes table that has been checked in destiny database list and saves it in the database project's InsertTables.
        private void InsertCheckedTableInProject(int index)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();

            var newTable = new InsertTable()
            {
                Table = dlvDestTables.Items[index].Text,
                Order = ((from o in context.InsertTables
                            where o.FkProject == pId
                            select o.Order).Max()) + 1,
                FkProject = pId
            };

            context.InsertTables.AddObject(newTable);

            context.SaveChanges();
        }

        //Takes table that has been unchecked in destiny database list/InsertTables list and removes it from the database project's InsertTables.
        private void DeleteUncheckedTableFromProject(string tableName)
        {
            //LINQ does not take C# methods as values. 
            var pId = GetCurrentProjectId();

            var context = new Entities();

            var deleteTable = context.InsertTables.SingleOrDefault(x => x.Table == tableName && x.FkProject == pId);

            if (deleteTable == null) return;

            if (deleteTable.Order == (from o in context.InsertTables where o.FkProject == pId select o.Order).Max())
            {
                context.InsertTables.DeleteObject(deleteTable);
                context.SaveChanges();
                PopulateInsertTablesList();
            }
            else
            {
                context.InsertTables.DeleteObject(deleteTable);
                var project = context.Projects.SingleOrDefault(x => x.Id == pId);
                if (project == null) return;
                var tables = project.InsertTables.OrderBy(x => x.Id);

                // ReSharper disable once PossibleMultipleEnumeration
                // fucc resharper
                for (var orderIndex = 0; orderIndex < tables.Count(); orderIndex++)
                {
                    // ReSharper disable once PossibleMultipleEnumeration
                    tables.ElementAt(orderIndex).Order = orderIndex + 1;
                }

                context.SaveChanges();
                PopulateInsertTablesList();
            }
        }

        //Reordering of table conversion.
        private void olvInsertTable_CanDrop(object sender, BrightIdeasSoftware.OlvDropEventArgs e)
        {
            var target = e.DropTargetItem;

            if (target == null) e.Effect = DragDropEffects.None;

            else if (e.DropTargetItem.Text == olvInsertTable.SelectedItem.Text)
            {
                e.Effect = DragDropEffects.None;
                e.InfoMessage = "Item já está nesta posição da ordem!";
            }
            else
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void olvInsertTable_Dropped(object sender, BrightIdeasSoftware.OlvDropEventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            var dragtablename = olvInsertTable.SelectedItem.Text;
            var draggedTable =
                context.InsertTables.SingleOrDefault(x => x.Table == dragtablename && x.FkProject == pId);
            var targetTable =
                context.InsertTables.SingleOrDefault(x => x.Table == e.DropTargetItem.Text && x.FkProject == pId);

            //fucc resharper get smarter
            // ReSharper disable once PossibleNullReferenceException
            var orderBackup = draggedTable.Order;

            // ReSharper disable once PossibleNullReferenceException
            draggedTable.Order = targetTable.Order;
            targetTable.Order = orderBackup;

            context.SaveChanges();

            PopulateInsertTablesList();
        }

        #endregion

        #region Custom Field related functions.

        //Create new CustomField and save to data-base project's CustomFields.
        private void lblddCustomField_Click(object sender, EventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();
            var context = new Entities();

            if (_currentTable == "")
            {
                panelBottomState.BackColor = Color.DarkRed;
                lblStatusText.Text = @"Sem tabela para adicionar campo customizado";
                return;
            }

            if (!context.InsertTables
                    .Any(x => x.Table == _currentTable && x.FkProject == pId))
            {
                panelBottomState.BackColor = Color.DarkRed;
                lblStatusText.Text = @"Marque a tabela antes de adicionar um campo customizado.";
                return;
            }

            if (!context.SelectFields
                .Any(x => x.InsertTable.Table == _currentTable && x.InsertTable.FkProject == pId))
            {
                panelBottomState.BackColor = Color.DarkRed;
                lblStatusText.Text = @"Salve a tabela antes de adicionar um campo customizado.";
                return;
            }

            // ReSharper disable once PossibleNullReferenceException
            var idInsertTable = context.InsertTables
                .SingleOrDefault(x => x.Table == _currentTable && x.FkProject == pId).Id;

            var columnName = Interaction.InputBox("Nome da Coluna: ", "Coluna Customizada", "*", 100, 100);
            if (string.IsNullOrEmpty(columnName) || context.CustomFields.Any(x => x.Column == columnName && x.FkInsertTable == idInsertTable))
            {
                panelBottomState.BackColor = Color.DarkRed;
                lblStatusText.Text = @"Coluna Inválida ou já existente.";
                return;
            }
            var columnType = Interaction.InputBox("Tipo da Coluna: ", "Coluna Customizada", "*", 100, 100);
            if (string.IsNullOrEmpty(columnType))
            {
                panelBottomState.BackColor = Color.DarkRed;
                lblStatusText.Text = @"Coluna Inválida";
                return;
            }
            var defaultValue = Interaction.InputBox("Valor Padrão: ", "Coluna Customizada", "*", 100, 100);

            var column = new CustomField()
            {
                Column = columnName,
                Columntype = columnType,
                DefaultValue = defaultValue,
                FkInsertTable = idInsertTable
            };

            context.CustomFields.AddObject(column);
            context.SaveChanges();

            panelBottomState.BackColor = Color.DarkOrange;
            lblStatusText.Text = @"Campos não salvos.";

            PopulateSelectField();
        }

        //Populate the list of CustomFields.
        private void PopulateCustomFields()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            var customfields = context.CustomFields.Where(x =>
                x.InsertTable.Table == _currentTable && x.InsertTable.FkProject == pId);

            olvCustomField.SetObjects(customfields);
        }

        //Removes CustomField and (if exists) its saved SelectFields from the data-base. Reloads SelectGrid to show changes.
        private void lblRemoveCustomField_Click(object sender, EventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            if (olvCustomField.SelectedIndex == -1) return;

            var context = new Entities();
            var deleteCustomField = context.CustomFields.SingleOrDefault(x =>
                x.Column == olvCustomField.SelectedItem.Text && x.InsertTable.Table == _currentTable &&
                x.InsertTable.FkProject == pId);

            var cfSelectLine = context.SelectFields.SingleOrDefault(x =>
                x.Column == deleteCustomField.Column && x.InsertTable.Table == deleteCustomField.InsertTable.Table &&
                x.InsertTable.FkProject == pId);

            if (MessageBox.Show(@"Deseja mesmo excluir este campo customizado?", @"Alerta!",
                    MessageBoxButtons.YesNo) == DialogResult.No) return;
            if (deleteCustomField != null)
                context.CustomFields.DeleteObject(deleteCustomField);
            if (cfSelectLine != null)
                context.SelectFields.DeleteObject(cfSelectLine);

            context.SaveChanges();

            olvCustomField.ClearObjects();
            PopulateSelectField();
        }

        #endregion

        #region Connection related functions.

        public void SetOriginConnection(IConversionDataGetter newConn)
        {
            OriginConn = newConn;
            PopulateOriginTables();
        }

        public void SetDestinyConnection(IConversionDataGetter newConn)
        {
            DestinyConn = newConn;
            PopulateDestinyTables();
        }

        #endregion

        #region Persistence related functions

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            var insertTable =
                context.InsertTables.SingleOrDefault(x => x.Table == _currentTable && x.FkProject == pId);

            if (tscbProjects.SelectedIndex == -1)
            {
                panelBottomState.BackColor = Color.DarkRed;
                lblStatusText.Text = @"Erro: Não há nada para salvar.";
                return;
            }

            SaveConnectionParameters();
            lblStatusText.Text = @"Parametros de conexão salvos. Para salvar as colunas desta tabela, marque-a.";

            if (insertTable == null) return;

            SaveInsertCommand();
            SaveFromCommand();
            SaveSelectFieldExpressions();
            panelBottomState.BackColor = Color.DarkGreen;
            lblStatusText.Text = @"Tabela e parametros de conexão salvos.";
            _hasScriptChange = false;
        }

        //Save text above SelectGrid to come before the Insert Expression.
        private void SaveInsertCommand()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();

            var updateTable =
                context.InsertTables.SingleOrDefault(x => x.Table == _currentTable && x.FkProject == pId);

            if (updateTable == null) return;

            updateTable.InsertComand = rtbInsert.Text;
            context.SaveChanges();
        }

        //Save text to come after "from" in the script.
        private void SaveFromCommand()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();

            var updateTable =
                context.InsertTables.SingleOrDefault(x => x.Table == _currentTable && x.FkProject == pId);

            if (updateTable == null) return;

            updateTable.FromComand = rtbFrom.Text;
            context.SaveChanges();
        }

        //Saves the expressions in the SelectGrid.
        private void SaveSelectFieldExpressions()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            // ReSharper disable once PossibleNullReferenceException
            // Get the insert table fk, cant actually be null because it has to have its checkbox checked (aka in the data-base) in order to get to this.
            var idInsertTable = context.InsertTables
                .SingleOrDefault(x => x.Table == _currentTable && x.FkProject == pId).Id;

            foreach (DataGridViewRow row in dgvSelectFields.Rows)
            {
                var columnName = row.Cells[3].Value.ToString();

                var updateField = context.SelectFields.FirstOrDefault(s =>
                    s.FkInsertTable == idInsertTable && s.InsertTable.FkProject == pId && s.Column == columnName);

                if (updateField == null)
                {
                    var newField = new SelectField
                    {
                        Column = columnName,
                        FkInsertTable = idInsertTable,
                        SelectedField = row.Cells[0].Value.ToString(),
                        DefaultValue = row.Cells[1].Value.ToString()
                    };

                    context.SelectFields.AddObject(newField);
                }
                else
                {
                    updateField.SelectedField = row.Cells[0].Value.ToString();
                    updateField.DefaultValue = row.Cells[1].Value.ToString();
                }
            }

            context.SaveChanges();
        }

        //Saves the information in the current connection string(s) to the data-base to be loaded when project is selected.
        private void SaveConnectionParameters()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();

            var updateProject = context.Projects.SingleOrDefault(x => x.Id == pId);

            if (updateProject == null) return;

            if (DestinyConn != null)
            {
                updateProject.DestinyDbType = DestinyConn.Type;
                updateProject.DestinyHost = DestinyConn.Host;
                updateProject.DestinyPort = DestinyConn.Port;
                updateProject.DestinyDb = DestinyConn.Database;
                updateProject.DestinySchema = DestinyConn.Schema;
                updateProject.DestinyUser = DestinyConn.User;
            }
            if (OriginConn != null)
            {
                updateProject.OriginDbType = OriginConn.Type;
                updateProject.OriginHost = OriginConn.Host;
                updateProject.OriginPort = OriginConn.Port;
                updateProject.OriginDb = OriginConn.Database;
                updateProject.OriginSchema = OriginConn.Schema;
                updateProject.OriginUser = OriginConn.User;
            }

            if (OriginConn != null || DestinyConn != null) context.SaveChanges();
        }

        //Loads SelectField expressions and insert/from to the SelectGrid.
        private void LoadSelectFieldExpressions()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            // ReSharper disable once PossibleNullReferenceException
            // Get the insert table fk, cant actually be null because it has to have its checkbox checked (aka in the data-base) in order to get to this.
            var insertTable =
                context.InsertTables.SingleOrDefault(x => x.Table == _currentTable && x.FkProject == pId);
            foreach (DataGridViewRow row in dgvSelectFields.Rows)
            {
                var column = row.Cells[3].Value.ToString();
                var selectField = context.SelectFields.SingleOrDefault(x =>
                    x.Column == column && x.FkInsertTable == insertTable.Id && x.InsertTable.FkProject == pId);

                if (selectField == null)
                {
                    _isTableSwap = false;
                    return;
                }

                if (insertTable == null)
                {
                    panelBottomState.BackColor = Color.DarkRed;
                    lblStatusText.Text =
                        @"Houve um erro no carregamento da conversão. Por favor, verifique a seleção do projeto/tabela.";
                    _isTableSwap = false;
                    return;
                }

                //Load commands.
                rtbInsert.Text = insertTable.InsertComand;
                rtbFrom.Text = insertTable.FromComand;

                row.Cells[0].Value = selectField.SelectedField;
                row.Cells[1].Value = selectField.DefaultValue;
            }           
           
        }

        //Checks if anything has been changed (using class boolean) and if so stop the operation thats undergoing;
        private void AlertUnsavedChanges()
        {
            panelBottomState.BackColor = Color.DarkRed;
            lblStatusText.Text = @"Clique novamente para sair sem salvar suas alterações.";
            _hasScriptChange = false;
        }

        #endregion

        #region Script Generation related functions.

        //Generate Single Script.
        private void esteScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var script = GenerateScript(_currentTable);
            if (script != null) new ScriptVisualizationForm(script).Show();
            else
            {
                panelBottomState.BackColor = Color.DarkRed;
                lblStatusText.Text = @"Não há tabela para gerar. Você marcou a tabela em questão?";
            }
        }

        //Generate All project Scripts
        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var allScripts = new StringBuilder();

            var context = new Entities();
            var scriptProject = context.Projects.SingleOrDefault(x => x.Id == pId);

            if (scriptProject == null || scriptProject.InsertTables.Count == 0)
            {
                panelBottomState.BackColor = Color.DarkRed;
                lblStatusText.Text = @"Projeto não selecionado ou sem tabelas.";
                return;
            }

            // ReSharper disable once SuggestVarOrType_SimpleTypes
            // fucc resharper
            for (var index = 0; index < scriptProject.InsertTables.Count; index++)
            {
                // ReSharper disable once PossibleNullReferenceException
                if (scriptProject.InsertTables.SingleOrDefault(x => x.Order == index + 1).SelectFields.Count == 0)
                    // ReSharper disable once PossibleNullReferenceException
                    allScripts.Append(("\n").PadRight(60, '-') + "\nScript vazio para a tabela " +
                                      scriptProject.InsertTables.SingleOrDefault(x => x.Order == index + 1).Table +
                                      ".");
                else if (index == 0)
                    // ReSharper disable once PossibleNullReferenceException
                    allScripts.Append(GenerateScript(scriptProject.InsertTables
                        .SingleOrDefault(x => x.Order == index + 1).Table));
                else
                    // ReSharper disable once PossibleNullReferenceException
                    allScripts.Append(("\n").PadRight(60, '-') + "\n" +
                                      GenerateScript(scriptProject.InsertTables
                                          .SingleOrDefault(x => x.Order == index + 1).Table));
            }

            new ScriptVisualizationForm(allScripts.ToString()).Show();
        }

        //Generate All project Scripts and save to txt.
        private void todosParaTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            var scriptProject = context.Projects.SingleOrDefault(x => x.Id == pId);

            if (scriptProject == null || scriptProject.InsertTables.Count == 0)
            {
                panelBottomState.BackColor = Color.DarkRed;
                lblStatusText.Text = @"Projeto não selecionado ou sem tabelas.";
                return;
            }

            var path = "C:\\SQLBuilder\\" + scriptProject.Name + "\\";

            Directory.CreateDirectory(path);
            if (Directory.EnumerateFiles(path).Count() != 0)
            {
                Directory.CreateDirectory(path + "\\old");
                if (Directory.EnumerateFiles(path + "\\old").Count() != 0)
                {
                    panelBottomState.BackColor = Color.DarkRed;
                    lblStatusText.Text = @"Já existem arquivos na pasta " + path +
                                         @"e seus backups, por favor limpe a pasta de scripts para gerar novos!";
                    return;
                }

                var files = Directory.EnumerateFiles(path, "*.sql")
                    .Select(filepath => new FileInfo(filepath));
                foreach (var file in files)
                    file.MoveTo(Path.Combine(path + "\\old", file.Name));
            }

            for (var index = 0; index < scriptProject.InsertTables.Count; index++)
            {
                var order = index + 1;
                // ReSharper disable once PossibleNullReferenceException
                var filename = order + ". " +
                               scriptProject.InsertTables.SingleOrDefault(x => x.Order == index + 1).Table + ".sql";
                var newScript =
                    // ReSharper disable once PossibleNullReferenceException
                    GenerateScript(scriptProject.InsertTables.SingleOrDefault(x => x.Order == order).Table);

                File.WriteAllText(path + filename, newScript);
            }

            lblStatusText.Text = @"Scripts salvos em '" + path + @"'.";
            panelBottomState.BackColor = Color.DarkGreen;
        }

        //Actual Script Generation process.
        private string GenerateScript(string tableToGenerate)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            var scriptTable =
                context.InsertTables.SingleOrDefault(x => x.Table == tableToGenerate && x.FkProject == pId);

            if (scriptTable == null)
            {
                return null;
            }

            var script = new StringBuilder();

            foreach (CustomField customField in scriptTable.CustomFields)
            {
                script.Append("ALTER TABLE " + tableToGenerate + " ADD " + customField.Column + " " + customField.Columntype);
                if (string.IsNullOrEmpty(customField.DefaultValue))
                {
                    script.Append(";");
                    continue;
                }
                script.Append(" default '" + customField.DefaultValue + "';\n\n");
            }

            script.Append(scriptTable.InsertComand);
            script.Append("\n\n" + "INSERT INTO " + scriptTable.Table + " (");

            //Insert value columns.
            for (var index = 0; index < scriptTable.SelectFields.Count; index++)
            {
                if (index != scriptTable.SelectFields.Count - 1)
                    script.Append(scriptTable.SelectFields.ElementAt(index).Column + ", ");
                else
                    script.Append(scriptTable.SelectFields.ElementAt(index).Column + ")");
            }

            script.Append("\nSELECT\n");

            // ReSharper disable once SuggestVarOrType_SimpleTypes
            // Resharper is anal as fuck and should die (jk). Inserts every select field in a new line.
            for (var index = 0; index < scriptTable.SelectFields.Count; index++)
            {
                string selectfield;

                if (index != scriptTable.SelectFields.Count - 1)
                {
                    if (scriptTable.SelectFields.ElementAt(index).DefaultValue == "" &&
                        scriptTable.SelectFields.ElementAt(index).SelectedField != "")
                        selectfield =
                            "\n" + scriptTable.SelectFields.ElementAt(index).SelectedField.PadRight(40, ' ') + "AS " +
                            scriptTable.SelectFields.ElementAt(index).Column + ",";

                    else if (scriptTable.SelectFields.ElementAt(index).DefaultValue != "" &&
                             scriptTable.SelectFields.ElementAt(index).SelectedField != "")
                        selectfield =
                            "\n" + ("NULLIF(" + scriptTable.SelectFields.ElementAt(index).SelectedField + ", '" +
                                    scriptTable.SelectFields.ElementAt(index).DefaultValue + "')").PadRight(40, ' ') +
                            "AS " + scriptTable.SelectFields.ElementAt(index).Column + ",";

                    else if (scriptTable.SelectFields.ElementAt(index).DefaultValue != "" &&
                             scriptTable.SelectFields.ElementAt(index).SelectedField == "")
                        selectfield = "\n'" + scriptTable.SelectFields.ElementAt(index).DefaultValue + "'".PadRight(40, ' ') +
                                      "AS " + scriptTable.SelectFields.ElementAt(index).Column + ",";
                    else
                        selectfield = "\n" + "NULL".PadRight(40, ' ') + "AS " +
                                      scriptTable.SelectFields.ElementAt(index).Column + ",";
                }
                else
                {
                    if (scriptTable.SelectFields.ElementAt(index).DefaultValue == "" &&
                        scriptTable.SelectFields.ElementAt(index).SelectedField != "")
                        selectfield =
                            "\n" + scriptTable.SelectFields.ElementAt(index).SelectedField.PadRight(40, ' ') + "AS " +
                            scriptTable.SelectFields.ElementAt(index).Column;

                    else if (scriptTable.SelectFields.ElementAt(index).DefaultValue != "" &&
                             scriptTable.SelectFields.ElementAt(index).SelectedField != "")
                        selectfield =
                            "\n" + ("NULLIF(" + scriptTable.SelectFields.ElementAt(index).SelectedField + ", " +
                                    scriptTable.SelectFields.ElementAt(index).DefaultValue + ")").PadRight(40, ' ') +
                            "AS " + scriptTable.SelectFields.ElementAt(index).Column;

                    else if (scriptTable.SelectFields.ElementAt(index).DefaultValue != "" &&
                             scriptTable.SelectFields.ElementAt(index).SelectedField == "")
                        selectfield = "\n" + scriptTable.SelectFields.ElementAt(index).DefaultValue.PadRight(40, ' ') +
                                      "AS " + scriptTable.SelectFields.ElementAt(index).Column;
                    else
                        selectfield = "\n" + "NULL".PadRight(40, ' ') + "AS " +
                                      scriptTable.SelectFields.ElementAt(index).Column;
                }
                script.Append(selectfield);
            }

            script.Append("\n\n" + lblFrom.Text + " " + scriptTable.FromComand);

            return script.ToString();
        }

        #endregion       
    }
}