using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client; // ODP.NET Oracle managed provider
using Microsoft.VisualBasic;

namespace Project_SQLBuilder
{
    public partial class FormMain : Form
    {
        private bool _isUiChange;
        private bool _hasSelectedProject;
        private bool _isTableSwap;
        private string _currentTable = "";

        public FormMain()
        {
            InitializeComponent();
            PopulateProjectsCmb();

            txtDestSVR.Text = @"bruno";
            txtDestPass.Text = @"usetudo";
            txtDestDB.Text = @"m2netglobalprint";

            txtOrigSVR.Text = @"bruno";
            txtOrigPass.Text = @"usetudo";
            txtOrigDB.Text = @"m2globalprint";
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

        #region Sidebar ListViews related functions.

        //Connect to databases and load table information as DataTables to the ListViews.
        private void lblConnectOrigin_Click(object sender, EventArgs e)
        {
            dlvOrigTables.DataSource = SelectDataOraAsDt(txtOrigDB.Text, txtOrigSVR.Text, txtOrigPass.Text,
                "table_name", "user_Tables", null);
        }

        private void lblConnectDestiny_Click(object sender, EventArgs e)
        {
            var dt = SelectDataOraAsDt(txtDestDB.Text, txtDestSVR.Text, txtDestPass.Text, "table_name as Tabela",
                "user_Tables", null);
            //DataTable dt = SelectDataOraAsDt("m2netglobalprint", "bruno", "usetudo", "table_name as Tabela", "user_Tables", null); // FOR TESTING, USE TOP ONE WHEN DONE.
            dlvDestTables.DataSource = dt;

            _isUiChange = true;

            CheckInsertTables();

            _isUiChange = false;
        }

        //Panel interactions.
        private void dlvOrigTables_SelectionChanged(object sender, EventArgs e)
        {
            if (dlvOrigTables.SelectedItem == null) return;

            dlvOrigColumns.DataSource = SelectDataOraAsDt(txtOrigDB.Text, txtOrigSVR.Text, txtOrigPass.Text,
                "column_name as Coluna, concat(data_type, data_length) as Tipo", "user_tab_columns",
                "table_name = '" + dlvOrigTables.SelectedItem.Text + "'");
        }

        private void dlvDestTables_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tscbProjects.SelectedIndex == -1) return;

            rtbFrom.Text = null;
            rtbInsert.Text = null;

            if (dlvDestTables.SelectedItem == null) return;
            _currentTable = dlvDestTables.SelectedItem.Text;

            dgvSelectFields.DataSource = SelectDataOraAsDt(txtDestDB.Text, txtDestSVR.Text, txtDestPass.Text,
                "null as colOrigColumn, data_default as colDefaultValue, 'AS' as colAs, column_name as colDestColumn, concat(data_type, data_length) as colDestColumnType",
                "user_tab_columns", "table_name = '" + dlvDestTables.SelectedItem.Text + "'");
            lblInsert.Text = @"INSERT INTO " + _currentTable;

            if (dlvDestTables.Items[dlvDestTables.SelectedIndex].Checked) LoadCommands();

            lblSaveState.BackColor = Color.Green;
        }

        private void olvInsertTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tscbProjects.SelectedIndex == -1) return;

            rtbFrom.Text = null;
            rtbInsert.Text = null;

            if (olvInsertTable.SelectedItem == null) return;
            _currentTable = olvInsertTable.SelectedItem.Text;

            dgvSelectFields.DataSource = SelectDataOraAsDt(txtDestDB.Text, txtDestSVR.Text, txtDestPass.Text,
                "null as colOrigColumn, data_default as colDefaultValue, 'AS' as colAs, column_name as colDestColumn, concat(data_type, data_length) as colDestColumnType",
                "user_tab_columns", "table_name = '" + olvInsertTable.SelectedItem.Text + "'");
            lblInsert.Text = @"INSERT INTO " + _currentTable;

            LoadCommands();

            lblSaveState.BackColor = Color.Green;
        }

        //Check project's insert_table checkboxes in DestTable's list.
        private void CheckInsertTables()
        {
            if (dlvDestTables.Items.Count != 0)
                dlvDestTables.UncheckAll();

            var context = new Entities();

            if (tscbProjects.SelectedItem == null) return;
            var pId = GetCurrentProjectId();

            var query = from it in context.insert_table
                where it.fk_project == pId
                select it;

            foreach (var it in query)
            {
                for (var i = 0; i < dlvDestTables.GetItemCount(); i++)
                {
                    if (dlvDestTables.Items[i].Text == it.table)
                        dlvDestTables.GetItem(i).Checked = true;
                }
            }
        }

        //Fetch origin/destiny data-base information as DataTable.
        private DataTable SelectDataOraAsDt(string origDb, string origSvr, string origPass, string column, string table,
            string where)
        {
            try
            {
                var conString = "Data Source=" + origSvr + ";User Id=" + origDb + ";Password=" + origPass + ";";
                using (var con = new OracleConnection(conString))
                {
                    var cmd = where == null
                        ? new OracleCommand("select " + column + " from " + table, con)
                        : new OracleCommand("select " + column + " from " + table + " where " + where, con);

                    var oda = new OracleDataAdapter(cmd);

                    var ds = new DataTable();

                    oda.Fill(ds);

                    return ds;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
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
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            var name = Interaction.InputBox("Nome do Projeto: ", "Novo Projeto", "*", 100, 100);
            var destDbType =
                Interaction.InputBox("Banco de dados: ", "Novo Projeto", "*", 100, 100);

            while (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(@"Nome Inválido");
                name = Interaction.InputBox("Nome do Projeto: ", "Novo Projeto", "*", 100, 100);
            }

            while (string.IsNullOrEmpty(destDbType))
            {
                MessageBox.Show(@"Banco Inválido");
                destDbType =
                    Interaction.InputBox("Banco de dados: ", "Novo Projeto", "*", 100, 100);
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

            _hasSelectedProject = true;

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
            var pId = GetCurrentProjectId();

            var context = new Entities();

            olvInsertTable.SetObjects(context.insert_table.Where(x => x.fk_project == pId).ToList());
        }

        //Add or remove an Insert_Table entry in data-base based on item being checked on the Destiny Tables ListView.
        private void dlvDestTables_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var pId = GetCurrentProjectId();
            var context = new Entities();
            var updateTable =
                context.insert_table.SingleOrDefault(x => x.table == _currentTable && x.fk_project == pId);

            if (_isUiChange || !_hasSelectedProject) return;

            if (dlvDestTables.Items[e.Item.Index].Checked && updateTable == null)
            {
                InsertChecked(e.Item.Index);
            }
            else if (!dlvDestTables.Items[e.Item.Index].Checked)
            {
                DeleteUnchecked(e.Item.Index);
            }

            PopulateInsertTablesList();
        }

        //Confirm table deletion from project.
        private void dlvDestTables_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_isUiChange) return;
            if (e.NewValue == CheckState.Checked) return;
            if (MessageBox.Show(@"Deseja mesmo excluir esta tabela e suas informações da conversão?", @"Alerta!",
                    MessageBoxButtons.YesNo) == DialogResult.No) e.NewValue = e.CurrentValue;
        }

        private void InsertChecked(int index)
        {
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

        private void DeleteUnchecked(int index)
        {
            var pId = GetCurrentProjectId();

            var context = new Entities();

            var table = dlvDestTables.Items[index].Text;

            var deleteTable = context.insert_table.SingleOrDefault(x => x.table == table && x.fk_project == pId);

            if (deleteTable == null) return;
            context.insert_table.Remove(deleteTable);
            context.SaveChanges();
        }

        #endregion

        #region Command Persistence related functions

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            var context = new Entities();
            var pId = GetCurrentProjectId();

            var insertTable =
                context.insert_table.SingleOrDefault(x => x.table == _currentTable && x.fk_project == pId);

            if (insertTable == null)
            {
                Interaction.MsgBox(
                    "Erro: Tabela não foi incluida para conversão, inclua antes de salvar suas colunas.");
                return;
            }
            if (!_hasSelectedProject)
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
            var pId = GetCurrentProjectId();

            var context = new Entities();

            var updateTable = context.insert_table.SingleOrDefault(x => x.table == _currentTable && x.fk_project == pId);

            if (updateTable == null) return;

            updateTable.insert_comand = rtbInsert.Text ;
            context.SaveChanges();
        }

        private void SaveFromCommand()
        {
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
            var context = new Entities();
            var pId = GetCurrentProjectId();
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
            _isTableSwap = true;

            var context = new Entities();
            var pId = GetCurrentProjectId();
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

        private void btnGenerateScript_Click(object sender, EventArgs e)
        {
            var script = GenerateScript(_currentTable);
            if (script != null) new ScriptVisualizationForm(script).Show();
            else Interaction.MsgBox("Não há tabela para gerar.");
        }

        private void btnGenerateAllScripts_Click(object sender, EventArgs e)
        {

            var allScripts = new StringBuilder();
            var pId = GetCurrentProjectId();
            var context = new Entities();
            var scriptProject = context.project.SingleOrDefault(x => x.id == pId);

            // ReSharper disable once SuggestVarOrType_SimpleTypes
            // fucc resharper
            foreach (insert_table table in scriptProject.insert_table)
            {
                allScripts.Append(("\n\n").PadRight(60, '-') + "\n" + GenerateScript(table.table));
            }

            new ScriptVisualizationForm(allScripts.ToString()).Show();

        }

        private string GenerateScript(string tableToGenerate)
        {

            var pId = GetCurrentProjectId();
            var context = new Entities();
            var scriptTable = context.insert_table.SingleOrDefault(x => x.table == tableToGenerate && x.fk_project == pId);

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

            script.Append("\n\n" + lblFrom.Text + " " + rtbFrom.Text);

            return script.ToString();

        }

    }
}