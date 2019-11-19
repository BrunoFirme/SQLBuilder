using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SQLBuilder
{
    public partial class FormConfig : Form
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

        #endregion 

        private FormMain formMain;

        public FormConfig(FormMain main)
        {

            InitializeComponent();

            formMain = main;

            txtDB.Text = main.db;
            txtPass.Text = main.password;
            txtSVR.Text = main.server;
            txtPort.Text = main.port;
            txtUser.Text = main.user;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            this.formMain.db = txtDB.Text;
            this.formMain.server = txtSVR.Text;
            this.formMain.password = txtPass.Text;
            this.formMain.user = txtUser.Text;
            this.formMain.port = txtPort.Text;

            this.Close();

        }

    }
}
