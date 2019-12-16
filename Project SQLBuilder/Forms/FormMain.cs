using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Project_SQLBuilder.Interfaces;

namespace Project_SQLBuilder.Forms
{
    public partial class FormMain : Form
    {
        //parameter used to know when its a UI transition and not user-input that should be saved in DB.
        private bool _isUiChange;
        private bool _isTableSwap;
        private string _currentTable = "";

        //Connections set in the connection form.
        private IConversionDataGetter _originConn;
        private IConversionDataGetter _destinyConn;

        public FormMain()
        {
            InitializeComponent();
            PopulateProjectsCmb();
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
            new DataBaseConnectionForm(this).Show();
        }

        //COLOR CHANGES TO SAVESTATE LABEL
        private void rtbInsert_TextChanged(object sender, EventArgs e)
        {
            if (_isTableSwap) return;
            lblSaveState.BackColor = Color.Yellow;
        }

        private void rtbFrom_TextChanged(object sender, EventArgs e)
        {
            if (_isTableSwap) return;
            lblSaveState.BackColor = Color.Yellow;
        }

        private void dgvSelectFields_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_isTableSwap) return;
            lblSaveState.BackColor = Color.Yellow;
        }

        #endregion

        #region ListViews related functions.

        public void SetOriginConnection(IConversionDataGetter newConn)
        {
            _originConn = newConn;
            PopulateOriginTables();
        }

        public void SetDestinyConnection(IConversionDataGetter newConn)
        {
            _destinyConn = newConn;
            PopulateDestinyTables();
        }

        //Populate list of origin data-base tables.
        public void PopulateOriginTables()
        {
            dlvOrigTables.DataSource = _originConn.SelectTables();
        }

        //Populate list of destiny data-base tables
        public void PopulateDestinyTables()
        {
            dlvDestTables.DataSource = _destinyConn.SelectTables();

            _isUiChange = true;
            CheckInsertTables();
            _isUiChange = false;
        }

        //Populate list of origin data-base columns and types.
        private void dlvOrigTables_SelectionChanged(object sender, EventArgs e)
        {
            if (dlvOrigTables.SelectedItem == null) return;

            dlvOrigColumns.DataSource = _originConn.SelectColumns(dlvOrigTables.SelectedItem.Text);
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

            if (_destinyConn == null)
            {
                Interaction.MsgBox("Não há conexão com o banco de dados destino. Por favor conecte-se para recuperar as informações do banco.");
                return;
            }

            if (tscbProjects.SelectedIndex == -1) return;
            rtbFrom.Text = null;
            rtbInsert.Text = null;
           
            lblInsert.Text = @"INSERT INTO " + _currentTable;

            dgvSelectFields.DataSource = _destinyConn.SelectColumns(_currentTable);

            var context = new Entities();

            if (context.select_field.Any(x =>
                x.insert_table.table == _currentTable && x.insert_table.fk_project == pId))
            {
                LoadCommands();
                lblSaveState.BackColor = Color.Green;
            }
            else
            {
                lblSaveState.BackColor = Color.Yellow;
            }

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
               
        private int GetCurrentProjectId()
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

        //Create new Project.
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var name = Interaction.InputBox("Nome do Projeto: ", "Novo Projeto", "*", 100, 100);
            var destDbType =
                Interaction.InputBox("Banco de dados: ", "Novo Projeto", "*", 100, 100);

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(@"Nome Inválido");
                return;
            }

            if (string.IsNullOrEmpty(destDbType))
            {
                MessageBox.Show(@"Banco Inválido");
                return;
            }

            var newProject = new project
            {
                name = name,
                dest_db_type = destDbType
            };

            var context = new Entities();

            context.project.Add(newProject);

            context.SaveChanges();

            dgvSelectFields.DataSource = null;
            rtbFrom.Text = null;
            rtbInsert.Text = null;
            _currentTable = "";

            PopulateProjectsCmb();
        }

        //Check destiny table checkboxes and load Insert_tables list.
        private void tscbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isUiChange = true;

            CheckInsertTables();

            PopulateInsertTablesList();

            dgvSelectFields.DataSource = null;
            rtbFrom.Text = null;
            rtbInsert.Text = null;
            _currentTable = "";

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

        #region Command Persistence related functions

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var context = new Entities();
            var insertTable =
                context.insert_table.SingleOrDefault(x => x.table == _currentTable && x.fk_project == pId);

            if (insertTable == null)
            {
                Interaction.MsgBox(
                    "Erro: Tabela não foi incluida para conversão, inclua antes de salvar suas colunas.");
                return;
            }
            if (tscbProjects.SelectedIndex == -1)
            {
                Interaction.MsgBox("Erro: Não há nada para salvar.");
                return;
            }

            SaveInsertCommand();
            SaveFromCommand();
            SaveSelectCommands();

            lblSaveState.BackColor = Color.Green;
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
                    Interaction.MsgBox(
                        "Houve um erro no carregamento da conversão. Por favor, verifique a seleção do projeto/tabela.");
                    _isTableSwap = false;
                    return;
                }

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
            else Interaction.MsgBox("Não há tabela para gerar. Você marcou a tabela em questão?");
        }

        //Generate All Project Scripts
        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LINQ does not take C# methods as values.
            var pId = GetCurrentProjectId();

            var allScripts = new StringBuilder();

            var context = new Entities();
            var scriptProject = context.project.SingleOrDefault(x => x.id == pId);

            if (scriptProject == null || scriptProject.insert_table.Count == 0)
            {
                Interaction.MsgBox("Projeto não selecionado ou sem tabelas.");
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
                    allScripts.Append(("\n").PadRight(60, '-') +
                                      GenerateScript(scriptProject.insert_table
                                          .SingleOrDefault(x => x.order == index + 1).table));
            }

            new ScriptVisualizationForm(allScripts.ToString()).Show();
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

            var script = new StringBuilder(scriptTable.insert_comand);
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