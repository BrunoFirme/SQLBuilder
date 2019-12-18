using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Project_SQLBuilder.Interfaces;

namespace Project_SQLBuilder.Forms
{
    public partial class MainForm : Form
    {
        //Parameters used to know when its an UI transition and not user-input that should be saved in DB or reacted in some way.
        private bool _isUiChange;

        private bool _isTableSwap;

        //Used for script generation.
        private string _currentTable = "";

        //Connections set in the connection form.
        public DataBaseConnectionForm ConfigForm;

        public IConversionDataGetter OriginConn;
        public IConversionDataGetter DestinyConn;

        public MainForm()
        {
            InitializeComponent();
            PopulateProjectsCmb();
            lblStatusText.Text = "";
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

        //COLOR CHANGES TO SAVESTATE LABEL
        private void rtbInsert_TextChanged(object sender, EventArgs e)
        {
            if (_isTableSwap) return;
            lblSaveState.BackColor = Color.Yellow;
            lblStatusText.Text = "";
        }

        private void rtbFrom_TextChanged(object sender, EventArgs e)
        {
            if (_isTableSwap) return;
            lblSaveState.BackColor = Color.Yellow;
            lblStatusText.Text = "";
        }

        private void dgvSelectFields_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_isTableSwap) return;
            lblSaveState.BackColor = Color.Yellow;
            lblStatusText.Text = "";
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

        //Populate select datagridview of destiny data-base columns.
        private void dlvDestTables_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dlvDestTables.SelectedItem == null) return;
            _currentTable = dlvDestTables.SelectedItem.Text;
            PopulateSelectFields();
        }

        private void olvInsertTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (olvInsertTable.SelectedItem == null) return;
            _currentTable = olvInsertTable.SelectedItem.Text;
            PopulateSelectFields();
        }

        private void PopulateSelectFields()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            if (DestinyConn == null)
            {
                lblSaveState.BackColor = Color.Red;
                lblStatusText.Text =
                    @"Não há conexão com o banco de dados destino. Por favor conecte-se para recuperar as informações do banco.";
                return;
            }

            if (tscbProjects.SelectedIndex == -1) return;
            rtbFrom.Text = null;
            rtbInsert.Text = null;

            lblInsert.Text = @"INSERT INTO " + _currentTable;

            var context = new Entities();

            olvCustomField.ClearObjects();
            dgvSelectFields.DataSource = DestinyConn.SelectColumns(_currentTable, context.custom_field.Where(x => x.insert_table.table == _currentTable && x.insert_table.fk_project == pId));

            if (context.select_field.Any(x =>
                x.insert_table.table == _currentTable && x.insert_table.fk_project == pId))
            {
                LoadCommands();
                PopulateCustomFields();
                lblSaveState.BackColor = Color.Green;
                lblStatusText.Text = "";
            }
            else
            {
                lblSaveState.BackColor = Color.Yellow;
                lblStatusText.Text = "";
            }

            var lastAddedColumn = dgvSelectFields[3, dgvSelectFields.RowCount - 1].Value.ToString();

            if (!context.select_field.Any(x =>
                x.column == lastAddedColumn && x.insert_table.table == _currentTable && x.insert_table.fk_project == pId))
            {
                lblSaveState.BackColor = Color.Yellow;
            }
        }

        //Clears lists and connections to set up a fresh screen.
        private void ClearAll()
        {
            DestinyConn = null;
            OriginConn = null;
            dgvSelectFields.DataSource = null;
            dlvOrigTables.DataSource = null;
            dlvOrigColumns.DataSource = null;
            dlvDestTables.DataSource = null;
            dlvDestTables.ClearObjects();
            olvInsertTable.ClearObjects();
            olvCustomField.ClearObjects();
            rtbFrom.Text = null;
            rtbInsert.Text = null;
            lblInsert.Text = @"INSERT INTO";
            _currentTable = "";
            lblStatusText.Text = @"";
            lblSaveState.BackColor = Color.Green;
        }

        //Check project tables in destiny data-base tables list.
        private void CheckInsertTables()
        {
            if (dlvDestTables.Items.Count != 0)
                dlvDestTables.UncheckAll();

            if (tscbProjects.SelectedItem == null) return;

            var pId = GetCurrentProjectId();
            var context = new Entities();
            var query = from it in context.insert_table
                where it.fk_project == pId
                select it;

            foreach (var it in query)
            {
                for (var i = 0; i < dlvDestTables.GetItemCount(); i++)
                {
                    if (dlvDestTables.Items[i].Text == it.table)
                    {
                        dlvDestTables.GetItem(i).Checked = true;
                    }
                }
            }
        }

        #endregion

        #region Project object related functions.

        private void PopulateProjectsCmb()
        {
            tscbProjects.Items.Clear();

            var context = new Entities();
            var query = from it in context.project orderby it.name select it;

            foreach (var p in query)
            {
                tscbProjects.Items.Add(p.name);
            }
        }

        public int GetCurrentProjectId()
        {
            var context = new Entities();

            var qfkProject = 0;

            if (tscbProjects.SelectedItem != null)
            {
                qfkProject = (from o in context.project
                    where o.name == tscbProjects.SelectedItem.ToString()
                    select o.id).Max();
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

            var newProject = new project
            {
                name = name
            };

            var context = new Entities();

            context.project.Add(newProject);

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
                lblSaveState.BackColor = Color.Red;
                lblStatusText.Text = @"Nenhum projeto selecionado.";
                return;
            }

            var context = new Entities();

            var deleteProject = context.project.SingleOrDefault(x => x.id == pId);

            if (deleteProject == null) return;

            if (MessageBox.Show(@"Deseja mesmo excluir o projeto " + deleteProject.name + @"?", @"Alerta!",
                    MessageBoxButtons.YesNo) == DialogResult.No) return;

            context.project.Remove(deleteProject);
            context.SaveChanges();

            PopulateProjectsCmb();

            tscbProjects.SelectedIndex = -1;

        }

        //Check destiny table checkboxes and load Insert_tables list.
        private void tscbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isUiChange = true;

            ClearAll();
            CheckInsertTables();
            PopulateInsertTablesList();

            _isUiChange = false;
        }

        #endregion

        #region Insert_table object related functions.

        private void PopulateInsertTablesList()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            olvInsertTable.SetObjects(context.insert_table.Where(x => x.fk_project == pId).OrderBy(x => x.order)
                .ToList());

            _isUiChange = true;
            olvInsertTable.CheckAll();
            _isUiChange = false;
        }

        //Add or remove an Insert_Table entry in data-base based on item being checked on the Destiny Tables ListView.
        private void dlvDestTables_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            if (_isUiChange || tscbProjects.SelectedIndex == -1) return;

            var context = new Entities();
            var tablename = e.Item.Text;
            var updateTable =
                context.insert_table.SingleOrDefault(x => x.table == tablename && x.fk_project == pId);

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

        //Confirm table deletion from project.
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

        private void InsertCheckedTableInProject(int index)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();

            var newTable = new insert_table
            {
                table = dlvDestTables.Items[index].Text,
                order = ((from o in context.insert_table
                            where o.fk_project == pId
                            select o.order).Max()) + 1,
                fk_project = pId
            };

            context.insert_table.Add(newTable);

            context.SaveChanges();
        }

        private void DeleteUncheckedTableFromProject(string tableName)
        {
            //LINQ does not take C# methods as values. 
            var pId = GetCurrentProjectId();

            var context = new Entities();

            var deleteTable = context.insert_table.SingleOrDefault(x => x.table == tableName && x.fk_project == pId);

            if (deleteTable == null) return;

            if (deleteTable.order == (from o in context.insert_table where o.fk_project == pId select o.order).Max())
            {
                context.insert_table.Remove(deleteTable);
                context.SaveChanges();
                PopulateInsertTablesList();
            }
            else
            {
                context.insert_table.Remove(deleteTable);
                var project = context.project.SingleOrDefault(x => x.id == pId);
                if (project == null) return;
                var tables = project.insert_table.OrderBy(x => x.id);

                // ReSharper disable once PossibleMultipleEnumeration
                // fucc resharper
                for (var orderIndex = 0; orderIndex < tables.Count(); orderIndex++)
                {
                    // ReSharper disable once PossibleMultipleEnumeration
                    tables.ElementAt(orderIndex).order = orderIndex + 1;
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
                context.insert_table.SingleOrDefault(x => x.table == dragtablename && x.fk_project == pId);
            var targetTable =
                context.insert_table.SingleOrDefault(x => x.table == e.DropTargetItem.Text && x.fk_project == pId);

            //fucc resharper get smarter
            // ReSharper disable once PossibleNullReferenceException
            var orderBackup = draggedTable.order;

            // ReSharper disable once PossibleNullReferenceException
            draggedTable.order = targetTable.order;
            targetTable.order = orderBackup;

            context.SaveChanges();

            PopulateInsertTablesList();
        }

        #endregion

        #region Custom Field related functions.

        private void lblddCustomField_Click(object sender, EventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();
            var context = new Entities();

            if (_currentTable == "")
            {
                lblSaveState.BackColor = Color.Red;
                lblStatusText.Text = @"Sem tabela para adicionar campo customizado";
                return;
            }

            if (!context.insert_table
                    .Any(x => x.table == _currentTable && x.fk_project == pId))
            {
                lblSaveState.BackColor = Color.Red;
                lblStatusText.Text = @"Marque a tabela antes de adicionar um campo customizado.";
                return;
            }

            if (!context.select_field
                .Any(x => x.insert_table.table == _currentTable && x.insert_table.fk_project == pId))
            {
                lblSaveState.BackColor = Color.Red;
                lblStatusText.Text = @"Salve a tabela antes de adicionar um campo customizado.";
                return;
            }

            // ReSharper disable once PossibleNullReferenceException
            var idInsertTable = context.insert_table
                .SingleOrDefault(x => x.table == _currentTable && x.fk_project == pId).id;

            var columnName = Interaction.InputBox("Nome da Coluna: ", "Coluna Customizada", "*", 100, 100);
            if (string.IsNullOrEmpty(columnName) || context.custom_field.Any(x => x.column == columnName && x.fk_insert_table == idInsertTable))
            {
                lblSaveState.BackColor = Color.Red;
                lblStatusText.Text = @"Coluna Inválida ou já existente.";
                return;
            }
            var columnType = Interaction.InputBox("Tipo da Coluna: ", "Coluna Customizada", "*", 100, 100);
            if (string.IsNullOrEmpty(columnType))
            {
                lblSaveState.BackColor = Color.Red;
                lblStatusText.Text = @"Coluna Inválida";
                return;
            }
            var defaultValue = Interaction.InputBox("Valor Padrão: ", "Coluna Customizada", "*", 100, 100);

            var column = new custom_field
            {
                column = columnName,
                columntype = columnType,
                default_value = defaultValue,
                fk_insert_table = idInsertTable
            };

            context.custom_field.Add(column);
            context.SaveChanges();

            lblSaveState.BackColor = Color.Yellow;

            PopulateCustomFields();
        }

        private void PopulateCustomFields()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            var customfields = context.custom_field.Where(x =>
                x.insert_table.table == _currentTable && x.insert_table.fk_project == pId);

            olvCustomField.SetObjects(customfields);

            UpdateSelectFieldWithNewCol(customfields);
        }

        private void UpdateSelectFieldWithNewCol(IQueryable<custom_field> customField)
        {
            dgvSelectFields.DataSource = DestinyConn.SelectColumns(_currentTable, customField);
        }

        private void lblRemoveCustomField_Click(object sender, EventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            if (olvCustomField.SelectedIndex == -1) return;

            var context = new Entities();
            var deleteCustomField = context.custom_field.SingleOrDefault(x =>
                x.column == olvCustomField.SelectedItem.Text && x.insert_table.table == _currentTable &&
                x.insert_table.fk_project == pId);

            var cfSelectLine = context.select_field.SingleOrDefault(x =>
                x.column == deleteCustomField.column && x.insert_table.table == deleteCustomField.insert_table.table &&
                x.insert_table.fk_project == pId);

            if (MessageBox.Show(@"Deseja mesmo excluir este campo customizado?", @"Alerta!",
                    MessageBoxButtons.YesNo) == DialogResult.No) return;
            if (deleteCustomField != null)
                context.custom_field.Remove(deleteCustomField);
            if (cfSelectLine != null)
                context.select_field.Remove(cfSelectLine);

            context.SaveChanges();

            olvCustomField.ClearObjects();
            PopulateCustomFields();
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
                context.insert_table.SingleOrDefault(x => x.table == _currentTable && x.fk_project == pId);

            if (tscbProjects.SelectedIndex == -1)
            {
                lblSaveState.BackColor = Color.Red;
                lblStatusText.Text = @"Erro: Não há nada para salvar.";
                return;
            }

            SaveConnectionParameters();
            lblStatusText.Text = @"Parametros de conexão salvos. Para salvar as colunas desta tabela, marque-a.";

            if (insertTable == null) return;

            SaveInsertCommand();
            SaveFromCommand();
            SaveSelectCommands();
            lblSaveState.BackColor = Color.Green;
            lblStatusText.Text = @"Tabela e parametros de conexão salvos.";
        }

        private void SaveInsertCommand()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();

            var updateTable =
                context.insert_table.SingleOrDefault(x => x.table == _currentTable && x.fk_project == pId);

            if (updateTable == null) return;

            updateTable.insert_comand = rtbInsert.Text;
            context.SaveChanges();
        }

        private void SaveFromCommand()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();

            var updateTable =
                context.insert_table.SingleOrDefault(x => x.table == _currentTable && x.fk_project == pId);

            if (updateTable == null) return;

            updateTable.from_comand = rtbFrom.Text;
            context.SaveChanges();
        }

        private void SaveSelectCommands()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            // ReSharper disable once PossibleNullReferenceException
            // Get the insert table fk, cant actually be null because it has to have its checkbox checked (aka in the data-base) in order to get to this.
            var idInsertTable = context.insert_table
                .SingleOrDefault(x => x.table == _currentTable && x.fk_project == pId).id;

            foreach (DataGridViewRow row in dgvSelectFields.Rows)
            {
                var columnName = row.Cells[3].Value.ToString();

                var updateField = context.select_field.FirstOrDefault(s =>
                    s.fk_insert_table == idInsertTable && s.insert_table.fk_project == pId && s.column == columnName);

                if (updateField == null)
                {
                    var newField = new select_field
                    {
                        column = columnName,
                        fk_insert_table = idInsertTable,
                        selected_field = row.Cells[0].Value.ToString(),
                        default_value = row.Cells[1].Value.ToString()
                    };

                    context.select_field.Add(newField);
                    context.SaveChanges();
                }
                else
                {
                    updateField.selected_field = row.Cells[0].Value.ToString();
                    updateField.default_value = row.Cells[1].Value.ToString();
                    context.SaveChanges();
                }
            }
        }

        private void SaveConnectionParameters()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();

            var updateProject = context.project.SingleOrDefault(x => x.id == pId);

            if (updateProject == null) return;

            if (DestinyConn != null)
            {
                updateProject.destiny_db_type = DestinyConn.Type;
                updateProject.destiny_host = DestinyConn.Host;
                updateProject.destiny_port = DestinyConn.Port;
                updateProject.destiny_db = DestinyConn.Database;
                updateProject.destiny_schema = DestinyConn.Schema;
                updateProject.destiny_user = DestinyConn.User;
            }
            if (OriginConn != null)
            {
                updateProject.origin_db_type = OriginConn.Type;
                updateProject.origin_host = OriginConn.Host;
                updateProject.origin_port = OriginConn.Port;
                updateProject.origin_db = OriginConn.Database;
                updateProject.origin_schema = OriginConn.Schema;
                updateProject.origin_user = OriginConn.User;
            }

            if (OriginConn != null || DestinyConn != null) context.SaveChanges();
        }

        private void LoadCommands()
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            //Avoid incorrect color painting of saving indicator. I literally only use this parameter for this function, and it works flawlessly, should refactor sometime tho.
            _isTableSwap = true;

            var context = new Entities();
            // ReSharper disable once PossibleNullReferenceException
            // Get the insert table fk, cant actually be null because it has to have its checkbox checked (aka in the data-base) in order to get to this.
            var insertTable =
                context.insert_table.SingleOrDefault(x => x.table == _currentTable && x.fk_project == pId);
            foreach (DataGridViewRow row in dgvSelectFields.Rows)
            {
                var column = row.Cells[3].Value.ToString();
                var selectField = context.select_field.SingleOrDefault(x =>
                    x.column == column && x.fk_insert_table == insertTable.id && x.insert_table.fk_project == pId);

                if (selectField == null)
                {
                    _isTableSwap = false;
                    return;
                }

                if (insertTable == null)
                {
                    lblSaveState.BackColor = Color.Red;
                    lblStatusText.Text =
                        @"Houve um erro no carregamento da conversão. Por favor, verifique a seleção do projeto/tabela.";
                    _isTableSwap = false;
                    return;
                }

                //Load commands.
                rtbInsert.Text = insertTable.insert_comand;
                rtbFrom.Text = insertTable.from_comand;

                row.Cells[0].Value = selectField.selected_field;
                row.Cells[1].Value = selectField.default_value;
            }

            _isTableSwap = false;
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
                lblSaveState.BackColor = Color.Red;
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
            var scriptProject = context.project.SingleOrDefault(x => x.id == pId);

            if (scriptProject == null || scriptProject.insert_table.Count == 0)
            {
                lblSaveState.BackColor = Color.Red;
                lblStatusText.Text = @"Projeto não selecionado ou sem tabelas.";
                return;
            }

            // ReSharper disable once SuggestVarOrType_SimpleTypes
            // fucc resharper
            for (var index = 0; index < scriptProject.insert_table.Count; index++)
            {
                // ReSharper disable once PossibleNullReferenceException
                if (scriptProject.insert_table.SingleOrDefault(x => x.order == index + 1).select_field.Count == 0)
                    // ReSharper disable once PossibleNullReferenceException
                    allScripts.Append(("\n").PadRight(60, '-') + "\nScript vazio para a tabela " +
                                      scriptProject.insert_table.SingleOrDefault(x => x.order == index + 1).table +
                                      ".");
                else if (index == 0)
                    // ReSharper disable once PossibleNullReferenceException
                    allScripts.Append(GenerateScript(scriptProject.insert_table
                        .SingleOrDefault(x => x.order == index + 1).table));
                else
                    // ReSharper disable once PossibleNullReferenceException
                    allScripts.Append(("\n").PadRight(60, '-') + "\n" +
                                      GenerateScript(scriptProject.insert_table
                                          .SingleOrDefault(x => x.order == index + 1).table));
            }

            new ScriptVisualizationForm(allScripts.ToString()).Show();
        }

        //Generate All project Scripts and save to txt.
        private void todosParaTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            var scriptProject = context.project.SingleOrDefault(x => x.id == pId);

            if (scriptProject == null || scriptProject.insert_table.Count == 0)
            {
                lblSaveState.BackColor = Color.Red;
                lblStatusText.Text = @"Projeto não selecionado ou sem tabelas.";
                return;
            }

            var path = "C:\\SQLBuilder\\" + scriptProject.name + "\\";

            Directory.CreateDirectory(path);
            if (Directory.EnumerateFiles(path).Count() != 0)
            {
                Directory.CreateDirectory(path + "\\old");
                if (Directory.EnumerateFiles(path + "\\old").Count() != 0)
                {
                    lblSaveState.BackColor = Color.Red;
                    lblStatusText.Text = @"Já existem arquivos na pasta " + path +
                                         @"e seus backups, por favor limpe a pasta de scripts para gerar novos!";
                    return;
                }

                var files = Directory.EnumerateFiles(path, "*.sql")
                    .Select(filepath => new FileInfo(filepath));
                foreach (var file in files)
                    file.MoveTo(Path.Combine(path + "\\old", file.Name));
            }

            for (var index = 0; index < scriptProject.insert_table.Count; index++)
            {
                var order = index + 1;
                // ReSharper disable once PossibleNullReferenceException
                var filename = order + ". " +
                               scriptProject.insert_table.SingleOrDefault(x => x.order == index + 1).table + ".sql";
                var newScript =
                    // ReSharper disable once PossibleNullReferenceException
                    GenerateScript(scriptProject.insert_table.SingleOrDefault(x => x.order == order).table);

                File.WriteAllText(path + filename, newScript);
            }

            lblStatusText.Text = @"Scripts salvos em '" + path + @"'.";
        }

        //Actual Script Generation process.
        private string GenerateScript(string tableToGenerate)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            var scriptTable =
                context.insert_table.SingleOrDefault(x => x.table == tableToGenerate && x.fk_project == pId);

            if (scriptTable == null)
            {
                return null;
            }

            var script = new StringBuilder();

            foreach (custom_field customField in scriptTable.custom_field)
            {
                script.Append("ALTER TABLE " + tableToGenerate + " ADD " + customField.column + " " + customField.columntype);
                if (string.IsNullOrEmpty(customField.default_value))
                {
                    script.Append(";");
                    continue;
                }
                script.Append(" default '" + customField.default_value + "';\n\n");
            }

            script.Append(scriptTable.insert_comand);
            script.Append("\n\n" + "INSERT INTO " + scriptTable.table + " (");

            //Insert value columns.
            for (var index = 0; index < scriptTable.select_field.Count; index++)
            {
                if (index != scriptTable.select_field.Count - 1)
                    script.Append(scriptTable.select_field.ElementAt(index).column + ", ");
                else
                    script.Append(scriptTable.select_field.ElementAt(index).column + ")");
            }

            script.Append("\nSELECT\n");

            // ReSharper disable once SuggestVarOrType_SimpleTypes
            // Resharper is anal as fuck and should die (jk). Inserts every select field in a new line.
            for (var index = 0; index < scriptTable.select_field.Count; index++)
            {
                string selectfield;

                if (index != scriptTable.select_field.Count - 1)
                {
                    if (scriptTable.select_field.ElementAt(index).default_value == "" &&
                        scriptTable.select_field.ElementAt(index).selected_field != "")
                        selectfield =
                            "\n" + scriptTable.select_field.ElementAt(index).selected_field.PadRight(40, ' ') + "AS " +
                            scriptTable.select_field.ElementAt(index).column + ",";

                    else if (scriptTable.select_field.ElementAt(index).default_value != "" &&
                             scriptTable.select_field.ElementAt(index).selected_field != "")
                        selectfield =
                            "\n" + ("NULLIF(" + scriptTable.select_field.ElementAt(index).selected_field + ", " +
                                    scriptTable.select_field.ElementAt(index).default_value + ")").PadRight(40, ' ') +
                            "AS " + scriptTable.select_field.ElementAt(index).column + ",";

                    else if (scriptTable.select_field.ElementAt(index).default_value != "" &&
                             scriptTable.select_field.ElementAt(index).selected_field == "")
                        selectfield = "\n" + scriptTable.select_field.ElementAt(index).default_value.PadRight(40, ' ') +
                                      "AS " + scriptTable.select_field.ElementAt(index).column + ",";
                    else
                        selectfield = "\n" + "NULL".PadRight(40, ' ') + "AS " +
                                      scriptTable.select_field.ElementAt(index).column + ",";
                }
                else
                {
                    if (scriptTable.select_field.ElementAt(index).default_value == "" &&
                        scriptTable.select_field.ElementAt(index).selected_field != "")
                        selectfield =
                            "\n" + scriptTable.select_field.ElementAt(index).selected_field.PadRight(40, ' ') + "AS " +
                            scriptTable.select_field.ElementAt(index).column;

                    else if (scriptTable.select_field.ElementAt(index).default_value != "" &&
                             scriptTable.select_field.ElementAt(index).selected_field != "")
                        selectfield =
                            "\n" + ("NULLIF(" + scriptTable.select_field.ElementAt(index).selected_field + ", " +
                                    scriptTable.select_field.ElementAt(index).default_value + ")").PadRight(40, ' ') +
                            "AS " + scriptTable.select_field.ElementAt(index).column;

                    else if (scriptTable.select_field.ElementAt(index).default_value != "" &&
                             scriptTable.select_field.ElementAt(index).selected_field == "")
                        selectfield = "\n" + scriptTable.select_field.ElementAt(index).default_value.PadRight(40, ' ') +
                                      "AS " + scriptTable.select_field.ElementAt(index).column;
                    else
                        selectfield = "\n" + "NULL".PadRight(40, ' ') + "AS " +
                                      scriptTable.select_field.ElementAt(index).column;
                }
                script.Append(selectfield);
            }

            script.Append("\n\n" + lblFrom.Text + " " + scriptTable.from_comand);

            return script.ToString();
        }

        #endregion
    }
}