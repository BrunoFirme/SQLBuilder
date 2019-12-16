using Project_SQLBuilder.Classes;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project_SQLBuilder.Forms
{
    public partial class DataBaseConnectionForm : Form
    {

        private FormMain MainForm;

        public DataBaseConnectionForm(FormMain mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;

            cmbOrigDbType.SelectedIndex = 0;
            cmbDestDbType.SelectedIndex = 0;

            txbDestHost.Text = @"bruno";
            txbDestUser.Text = @"m2netglobalprint";
            txbDestPass.Text = @"usetudo";

            txbOrigHost.Text = @"bruno";
            txbOrigUser.Text = @"m2globalprint";
            txbOrigPass.Text = @"usetudo";

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
                    txbOrigPort.Enabled = false;
                    lblOrigPort.ForeColor = Color.DarkGray;
                    txbOrigDatabase.Enabled = false;
                    lblOrigDatabase.ForeColor = Color.DarkGray;
                    txbOrigUser.Enabled = true;
                    lblOrigUser.ForeColor = Color.White;
                    txbOrigPass.Enabled = true;
                    lblOrigPass.ForeColor = Color.White;
                    txbOrigSchema.Enabled = false;
                    lblOrigSchema.ForeColor = Color.DarkGray;
                    break;
                case 1:
                    txbOrigHost.Enabled = true;
                    lblOrigHost.ForeColor = Color.White;
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
                    lblDestPort.ForeColor = Color.DarkGray;
                    txbDestDatabase.Enabled = false;
                    lblDestDatabase.ForeColor = Color.DarkGray;
                    txbDestUser.Enabled = true;
                    lblDestUser.ForeColor = Color.White;
                    txbDestPass.Enabled = true;
                    lblDestPass.ForeColor = Color.White;
                    txbDestSchema.Enabled = false;
                    lblDestSchema.ForeColor = Color.DarkGray;
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

        //Sets connection to the desired database on main form.
        private void lblConnectOrigin_Click(object sender, EventArgs e)
        {
            var factory = new ConversionDataFactory(txbOrigHost.Text, txbOrigPort.Text, txbOrigDatabase.Text, txbOrigUser.Text, txbOrigPass.Text, txbOrigSchema.Text).GetConversionDataGetter(cmbOrigDbType.Text);
            MainForm.SetOriginConnection(factory);
        }

        private void lblConnectDestiny_Click(object sender, EventArgs e)
        {
            var factory = new ConversionDataFactory(txbDestHost.Text, txbDestPort.Text, txbDestDatabase.Text, txbDestUser.Text, txbDestPass.Text, txbDestSchema.Text).GetConversionDataGetter(cmbDestDbType.Text);
            MainForm.SetDestinyConnection(factory);
        }
    }
}
