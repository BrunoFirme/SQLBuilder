using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Oracle.DataAccess.Client; // ODP.NET Oracle managed provider
using Oracle.DataAccess.Types;
using Microsoft.VisualBasic;
using BrightIdeasSoftware;

namespace Project_SQLBuilder
{

    public partial class FormMain : Form
    {

        bool isUIChange = false;

        public FormMain()
        {

            InitializeComponent();
            populateProjectsCmb();          

        }

        #region Basic form functionality.

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        #endregion

        #region Side lists related functions.

        //Connect buttons.
        private void lblConnectOrigin_Click(object sender, EventArgs e)
        {

            clbOrigTables.DataSource = SelectDataOraAsDt(txtOrigDB.Text, txtOrigSVR.Text, txtOrigPass.Text, "table_name, rownum", "user_Tables", null);
            clbOrigTables.DisplayMember = "table_name";
            clbOrigTables.ValueMember = "rownum";

        }

        private void lblConnectDestiny_Click(object sender, EventArgs e)
        {

            //DataTable dt = SelectDataOraAsDt(txtDestDB.Text, txtDestSVR.Text, txtDestPass.Text, "table_name as Tabela", "user_Tables", null);
            DataTable dt = SelectDataOraAsDt("m2netglobalprint", "bruno", "usetudo", "table_name as Tabela", "user_Tables", null); // FOR TESTING, USE TOP ONE WHEN DONE.
            dlvDestTables.DataSource = dt;

            isUIChange = true;

            checkInsertTables();

            isUIChange = false;

        }

        //Panel interactions.
        private void clbOrigTables_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < clbOrigTables.Items.Count; ++ix)
                if (ix != e.Index) clbOrigTables.SetItemChecked(ix, false);
        }

        private void clbOrigTables_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvOrigColumns.DataSource = SelectDataOraAsDt(txtOrigDB.Text, txtOrigSVR.Text, txtOrigPass.Text, "column_name as Coluna, concat(data_type, data_length) as Tipo", "user_tab_columns", "table_name = '" + clbOrigTables.Text + "'");

        }

        private void dlvDestTables_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            dgvSelectFields.DataSource = SelectDataOraAsDt(txtDestDB.Text, txtDestSVR.Text, txtDestPass.Text, "null as colOrigColumn, data_default as colDefaultValue, 'AS' as colAs, column_name as colDestColumn, concat(data_type, data_length) as colDestColumnType", "user_tab_columns", "table_name = '" + dlvDestTables.SelectedItem.Text + "'");

        }

        //Check project's insert_table checkboxes in DestTable's list.
        private void checkInsertTables()
        {

            if (dlvDestTables.Items.Count != 0)
                dlvDestTables.UncheckAll();

            Entities Context = new Entities();

            if(tscbProjects.SelectedItem != null)
            {

                int pID = getCurrentProjectId();

                var query = from it in Context.insert_table
                            where it.fk_project == pID
                            select it;

                foreach (insert_table it in query)
                {

                    for (int i = 0; i < dlvDestTables.GetItemCount(); i++)
                    {

                        if (dlvDestTables.Items[i].Text == it.table)
                            dlvDestTables.GetItem(i).Checked = true;

                    }

                }

            }

        }

        //Fetch origin/destiny data-base information as DataTable.
        private DataTable SelectDataOraAsDt(string origDB, string origSVR, string origPass, string column, string table, string where)
        {

            OracleCommand cmd = new OracleCommand();

            try
            {

                string ConString = "Data Source=" + origSVR + ";User Id=" + origDB + ";Password=" + origPass + ";";
                using (OracleConnection con = new OracleConnection(ConString))
                {

                    if (where == null) // sem where
                    {

                        cmd = new OracleCommand("select " + column + " from " + table, con);


                    }
                    else
                    {

                        cmd = new OracleCommand("select " + column + " from " + table + " where " + where, con);

                    }

                    OracleDataAdapter oda = new OracleDataAdapter(cmd);

                    DataTable ds = new DataTable();

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

        private void populateProjectsCmb()
        {

            tscbProjects.Items.Clear();

            Entities Context = new Entities();
            var query = from it in Context.project orderby it.name select it;

            foreach (project p in query)
            {

                tscbProjects.Items.Add(p.name);

            }

        }

        private int getCurrentProjectId()
        {

            Entities Context = new Entities();

            int Qfk_project = (from o in Context.project
                               where o.name == tscbProjects.SelectedItem.ToString()
                               select o.id).Max();

            return Qfk_project;

        }

        //Create new Project.
        private void btnAddProject_Click(object sender, EventArgs e)
        {

            string name = Microsoft.VisualBasic.Interaction.InputBox("Nome do Projeto: ", "Novo Projeto", "*", 100, 100);
            string dest_db_type = Microsoft.VisualBasic.Interaction.InputBox("Banco de dados: ", "Novo Projeto", "*", 100, 100);

            while (name == null || name == "")
            {

                MessageBox.Show("Nome Inválido");
                name = Microsoft.VisualBasic.Interaction.InputBox("Nome do Projeto: ", "Novo Projeto", "*", 100, 100);

            }

            while (dest_db_type == null || dest_db_type == "")
            {

                MessageBox.Show("Banco Inválido");
                dest_db_type = Microsoft.VisualBasic.Interaction.InputBox("Banco de dados: ", "Novo Projeto", "*", 100, 100);

            }

            project NewProject = new project();

            NewProject.name = name;
            NewProject.dest_db_type = dest_db_type;

            Entities Context = new Entities();

            Context.project.Add(NewProject);

            Context.SaveChanges();

            populateProjectsCmb();

        }

        private void tscbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {

            isUIChange = true;

            checkInsertTables();

            populateInsertTablesList();

            isUIChange = false;

        }

        #endregion 

        #region Insert_table object related functions.

        private void dlvDestTables_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            if (isUIChange == false)
            {

                scanCheckedItems();

            }

        }

        private void scanCheckedItems()
        {

            int hasRow;
            int pID = getCurrentProjectId();

            Entities Context = new Entities();

            var query = from it in Context.insert_table
                        where it.fk_project == pID
                        select it;

            for (int i = 0; i < dlvDestTables.GetItemCount(); i++)
            {

                hasRow = 0;

                if (dlvDestTables.Items[i].Checked == true)
                {

                    foreach (insert_table it in query)
                    {

                        if (dlvDestTables.Items[i].Text == it.table)
                        {

                            hasRow = 1;

                        }

                    }

                    if (hasRow == 0)
                    {

                        insertChecked(i);

                    }

                }

                else
                {

                    foreach (insert_table it in query)
                    {

                        if (dlvDestTables.Items[i].Text == it.table)
                        {

                            deleteUnchecked(it.id);

                        }

                    }

                }

            }

        }

        private void insertChecked(int index)
        {

            int pID = getCurrentProjectId();

            Entities Context = new Entities();

            insert_table newTable = new insert_table();

            newTable.table = dlvDestTables.Items[index].Text;

            newTable.order = ((from o in Context.insert_table
                               where o.fk_project == pID
                               select o.order).Max()) + 1;

            newTable.fk_project = (from o in Context.project
                                   where o.name == tscbProjects.SelectedItem.ToString()
                                   select o.id).Max();

            Context.insert_table.Add(newTable);

            Context.SaveChanges();

        }

        private void deleteUnchecked(int index)
        {

            Entities context = new Entities();

            insert_table deleteTable = new insert_table() { id = index };

            context.insert_table.Attach(deleteTable);

            context.insert_table.Remove(deleteTable);

            context.SaveChanges();

        }

        #endregion

        private void populateInsertTablesList()
        {

            int pID = getCurrentProjectId();

            Entities Context = new Entities();

            var query = from it in Context.insert_table
                        where it.fk_project == pID
                        select it;

            olvInserttables.SetObjects(query.ToList());

        }

    }

}
