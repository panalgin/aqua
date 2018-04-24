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

        private void MainForm_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await Task.Delay(3000);
                this.BeginInvoke(new Action(delegate ()
                {
                    MessageBox.Show("Unexpected error 0x000001H happened in memory-map.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }));
            });
        }
    }
}
