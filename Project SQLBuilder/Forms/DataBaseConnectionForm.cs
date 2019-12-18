using Project_SQLBuilder.Classes;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project_SQLBuilder.Forms
{
    public partial class DataBaseConnectionForm : Form
    {
        private MainForm MainForm;

        public DataBaseConnectionForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;

            LoadProjectConnectionParameters();

            if (mainForm.OriginConn != null)
            {
                txbOrigHost.Text = mainForm.OriginConn.Host;
                txbOrigPort.Text = mainForm.OriginConn.Port;
                txbOrigDatabase.Text = mainForm.OriginConn.Database;
                txbOrigSchema.Text = mainForm.OriginConn.Schema;
                txbOrigUser.Text = mainForm.OriginConn.User;
                txbOrigPass.Text = mainForm.OriginConn.Password;
            }

            if (mainForm.DestinyConn != null)
            {
                txbDestHost.Text = mainForm.DestinyConn.Host;
                txbDestPort.Text = mainForm.DestinyConn.Port;
                txbDestDatabase.Text = mainForm.DestinyConn.Database;
                txbDestSchema.Text = mainForm.DestinyConn.Schema;
                txbDestUser.Text = mainForm.DestinyConn.User;
                txbDestPass.Text = mainForm.DestinyConn.Password;
            }
        }

        #region Basic form functionality.

        #region Screen move util
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            MainForm.ConfigForm = null;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Field adjustments based on database type

        //Adjust fields for data-base connection based on type selected;
        private void cmbOrigDbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustOrigDbFields();
        }

        private void cmbDestDbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustDestDbFields();
        }

        private void AdjustOrigDbFields()
        {
            switch (cmbOrigDbType.SelectedIndex)
            {
                case 0:
                    txbOrigHost.Enabled = true;
                    lblOrigHost.ForeColor = Color.White;
                    lblOrigHost.Text = @"Host:";
                    txbOrigPort.Enabled = false;
                    lblOrigPort.ForeColor = Color.DimGray;
                    txbOrigDatabase.Enabled = false;
                    lblOrigDatabase.ForeColor = Color.DimGray;
                    txbOrigUser.Enabled = true;
                    lblOrigUser.ForeColor = Color.White;
                    txbOrigPass.Enabled = true;
                    lblOrigPass.ForeColor = Color.White;
                    txbOrigSchema.Enabled = false;
                    lblOrigSchema.ForeColor = Color.DimGray;
                    break;
                case 1:
                    txbOrigHost.Enabled = true;
                    lblOrigHost.ForeColor = Color.White;
                    lblOrigHost.Text = @"Host:";
                    txbOrigPort.Enabled = true;
                    lblOrigPort.ForeColor = Color.White;
                    txbOrigDatabase.Enabled = true;
                    lblOrigDatabase.ForeColor = Color.White;
                    txbOrigUser.Enabled = true;
                    lblOrigUser.ForeColor = Color.White;
                    txbOrigPass.Enabled = true;
                    lblOrigPass.ForeColor = Color.White;
                    txbOrigSchema.Enabled = true;
                    lblOrigSchema.ForeColor = Color.White;
                    break;
                case 2:
                    txbOrigHost.Enabled = true;
                    lblOrigHost.ForeColor = Color.White;
                    lblOrigHost.Text = "Pasta:";
                    txbOrigPort.Enabled = false;
                    lblOrigPort.ForeColor = Color.DimGray;
                    txbOrigDatabase.Enabled = false;
                    lblOrigDatabase.ForeColor = Color.DimGray;
                    txbOrigUser.Enabled = false;
                    lblOrigUser.ForeColor = Color.DimGray;
                    txbOrigPass.Enabled = false;
                    lblOrigPass.ForeColor = Color.DimGray;
                    txbOrigSchema.Enabled = false;
                    lblOrigSchema.ForeColor = Color.DimGray;
                    break;
            }
        }

        private void AdjustDestDbFields()
        {
            switch (cmbDestDbType.SelectedIndex)
            {
                case 0:
                    txbDestHost.Enabled = true;
                    lblDestHost.ForeColor = Color.White;
                    txbDestPort.Enabled = false;
                    lblDestPort.ForeColor = Color.DimGray;
                    txbDestDatabase.Enabled = false;
                    lblDestDatabase.ForeColor = Color.DimGray;
                    txbDestUser.Enabled = true;
                    lblDestUser.ForeColor = Color.White;
                    txbDestPass.Enabled = true;
                    lblDestPass.ForeColor = Color.White;
                    txbDestSchema.Enabled = false;
                    lblDestSchema.ForeColor = Color.DimGray;
                    break;
                case 1:
                    txbDestHost.Enabled = true;
                    lblDestHost.ForeColor = Color.White;
                    txbDestPort.Enabled = true;
                    lblDestPort.ForeColor = Color.White;
                    txbDestDatabase.Enabled = true;
                    lblDestDatabase.ForeColor = Color.White;
                    txbDestUser.Enabled = true;
                    lblDestUser.ForeColor = Color.White;
                    txbDestPass.Enabled = true;
                    lblDestPass.ForeColor = Color.White;
                    txbDestSchema.Enabled = true;
                    lblDestSchema.ForeColor = Color.White;
                    break;
            }
        }

        #endregion

        //Load existing connection parameters from project.
        void LoadProjectConnectionParameters()
        {
            //LINQ does not take C# methods as values.
            var pId = MainForm.GetCurrentProjectId();

            var context = new Entities();
            var project = context.project.SingleOrDefault(x => x.id == pId);

            if (project == null) return;

            txbOrigHost.Text = project.origin_host;
            txbOrigPort.Text = project.origin_port;
            txbOrigDatabase.Text = project.origin_db;
            txbOrigSchema.Text = project.origin_schema;
            txbOrigUser.Text = project.origin_user;
            txbDestHost.Text = project.destiny_host;
            txbDestPort.Text = project.destiny_port;
            txbDestDatabase.Text = project.destiny_db;
            txbDestSchema.Text = project.destiny_schema;
            txbDestUser.Text = project.destiny_user;

            switch (project.origin_db_type)
            {
                case "Oracle":
                    cmbOrigDbType.SelectedIndex = 0;
                    break;
                case "Postgres":
                    cmbOrigDbType.SelectedIndex = 1;
                    break;
            }

            switch (project.destiny_db_type)
            {
                case "Oracle":
                    cmbDestDbType.SelectedIndex = 0;
                    break;
                case "Postgres":
                    cmbDestDbType.SelectedIndex = 1;
                    break;
            }
        }

        //Sets connection to the desired database on main form.
        private void lblConnectOrigin_Click(object sender, EventArgs e)
        {
            if (cmbOrigDbType.SelectedIndex == -1) return;
            MainForm.SetOriginConnection(new ConversionDataFactory(txbOrigHost.Text, txbOrigPort.Text, txbOrigDatabase.Text, txbOrigUser.Text, txbOrigPass.Text, txbOrigSchema.Text).GetConversionDataGetter(cmbOrigDbType.Text));
        }

        private void lblConnectDestiny_Click(object sender, EventArgs e)
        {
            if (cmbDestDbType.SelectedIndex == -1) return;
            MainForm.SetDestinyConnection(new ConversionDataFactory(txbDestHost.Text, txbDestPort.Text, txbDestDatabase.Text, txbDestUser.Text, txbDestPass.Text, txbDestSchema.Text).GetConversionDataGetter(cmbDestDbType.Text));
        }

    }
}
