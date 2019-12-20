using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project_SQLBuilder.Forms
{
    public partial class ScriptVisualizationForm : Form
    {

        #region Screen move and list editing util
        // ReSharper disable once InconsistentNaming
        public const int WM_NCLBUTTONDOWN = 0xA1;
        // ReSharper disable once InconsistentNaming
        public const int HT_CAPTION = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region Basic Form Functionality.

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

        public ScriptVisualizationForm(string script)
        {
            InitializeComponent();
            rtbScript.Text = script;
        }
    }
}
