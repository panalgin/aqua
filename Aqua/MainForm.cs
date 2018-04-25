using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.IO;
using Aqua.Logic;
using System.Runtime.InteropServices;

namespace Aqua
{
    public partial class MainForm : Form
    {
        public ChromiumWebBrowser Browser { get; set; }

        public MainForm()
        {
            InitializeComponent();
            CreateBrowser();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Cef.Shutdown();
        }

        private void CreateBrowser()
        {
            Cef.Initialize();
            CefSharpSettings.LegacyJavascriptBindingEnabled = true;

            string loadPath = Path.Combine(Application.StartupPath, "View\\index.html");

            Browser = new ChromiumWebBrowser(loadPath);
            Browser.BrowserSettings = new BrowserSettings()
            {
                FileAccessFromFileUrls = CefState.Enabled,
                UniversalAccessFromFileUrls = CefState.Enabled,
                Javascript = CefState.Enabled,
            };

            Browser.Dock = DockStyle.Fill;
            Controls.Add(Browser);

            MainController controller = new MainController(this);
            Browser.RegisterAsyncJsObject("windowsApp", controller);
        }

        #region Default

        private void MainForm_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await Task.Delay(3000);
                this.BeginInvoke(new Action(delegate ()
                {
                    //MessageBox.Show("Unexpected error 0x000001H happened in memory-map.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.Close();
                }));
            });
        }
        #endregion
        #region Resizing & Dragging
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public void ForceDrag()
        {
            this.Invoke(new Action(() =>
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }));
        }

        public void ForceResize(ResizeDirection dir)
        {
            this.Invoke(new Action(() =>
            {
                ReleaseCapture();

                switch (dir)
                {
                    case ResizeDirection.Left: SendMessage(this.Handle, 0x112, (IntPtr)61441, IntPtr.Zero); break;
                    case ResizeDirection.Right: SendMessage(this.Handle, 0x112, (IntPtr)61442, IntPtr.Zero); break;
                    case ResizeDirection.Top: SendMessage(this.Handle, 0x112, (IntPtr)61443, IntPtr.Zero); break;
                    case ResizeDirection.Bottom: SendMessage(this.Handle, 0x112, (IntPtr)61446, IntPtr.Zero); break;
                    case ResizeDirection.TopLeft: SendMessage(this.Handle, 0x112, (IntPtr)61444, IntPtr.Zero); break;
                    case ResizeDirection.BottomLeft: SendMessage(this.Handle, 0x112, (IntPtr)61447, IntPtr.Zero); break;
                    case ResizeDirection.TopRight: SendMessage(this.Handle, 0x112, (IntPtr)61445, IntPtr.Zero); break;
                    case ResizeDirection.BottomRight: SendMessage(this.Handle, 0x112, (IntPtr)61448, IntPtr.Zero); break;
                }
            }));
        }
        #endregion
    }
}
