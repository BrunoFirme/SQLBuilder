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

namespace Project_SQLBuilder
{

    public partial class FormMain : Form
    {

        #region standard form functions
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

        private void lblConnectOrigin_Click(object sender, EventArgs e)
        {

            ConnectOrigin(txtOrigDB.Text, txtOrigSVR.Text, txtOrigPass.Text);

        }

        private void lblConnectDestiny_Click(object sender, EventArgs e)
        {

            ConnectDest(txtDestDB.Text, txtDestSVR.Text, txtDestPass.Text);

        }
        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        private void ConnectOrigin(string origDB, string origSVR, string origPass)
        {



        }

        private void ConnectDest(string destDB, string destSVR, string destPass)
        {



        }

    }

}
