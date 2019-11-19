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
using Project_SQLBuilder.Models;


namespace Project_SQLBuilder
{

    public partial class FormMain : Form
    {

        #region Parameters

        List<InsertTable> InsertTables = null;
        public string db { get; set; }
        public string server { get; set; }
        public string port { get; set; }
        public string user { get; set; }
        public string password { get; set; }

        #endregion

        #region standard form functions

        int confStatus = 0;

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }

        private void clbOrigTables_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < clbOrigTables.Items.Count; ++ix)
                if (ix != e.Index) clbOrigTables.SetItemChecked(ix, false);
        }

        private void lblConnectOrigin_Click(object sender, EventArgs e)
        {

            clbOrigTables.DataSource = SelectDataOraAsDt(txtOrigDB.Text, txtOrigSVR.Text, txtOrigPass.Text, "table_name, rownum", "user_Tables", null);
            clbOrigTables.DisplayMember = "table_name";
            clbOrigTables.ValueMember = "rownum";

        }

        private void lblConnectDestiny_Click(object sender, EventArgs e)
        {

            DataTable dt = SelectDataOraAsDt(txtDestDB.Text, txtDestSVR.Text, txtDestPass.Text, "table_name, rownum", "user_Tables", null);
            clbDestTables.DataSource = dt;
            clbDestTables.DisplayMember = "table_name";
            clbDestTables.ValueMember = "rownum";


        }

        private void clbOrigTables_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvOrigColumns.DataSource = SelectDataOraAsDt(txtOrigDB.Text, txtOrigSVR.Text, txtOrigPass.Text, "column_name as Coluna, concat(data_type, data_length) as Tipo", "user_tab_columns", "table_name = '" + clbOrigTables.Text + "'");

        }

        private void clbDestTables_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvSelectFields.DataSource = SelectDataOraAsDt(txtDestDB.Text, txtDestSVR.Text, txtDestPass.Text, "null as colOrigColumn, data_default as colDefaultValue, 'AS' as colAs, column_name as colDestColumn, concat(data_type, data_length) as colDestColumnType", "user_tab_columns", "table_name = '" + clbDestTables.Text + "'");

        }

        #endregion

        public FormMain()
        {

            InitializeComponent();

        }

        #region EF migration in progress

        private void tscbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (int i in clbDestTables.CheckedIndices)
            {
                clbDestTables.SetItemCheckState(i, CheckState.Unchecked);
            }



        }

        public void activateConfig()
        {

            tmsiConfig.Enabled = true;

        }

        private void tmsiConfig_Click(object sender, EventArgs e)
        {
            if (confStatus == 0)
            {

                FormConfig FormConf = new FormConfig(this);
                FormConf.MdiParent = this;
                this.MainPanel.Controls.Add(FormConf);

                FormConf.FormClosed += delegate
                {

                    confStatus = 0;

                };
                FormConf.BringToFront();
                FormConf.Show();
                confStatus = 1;

            }
            else
            {

                return;

            }

        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {



        }

        #endregion

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

    }

}
