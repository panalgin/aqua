using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;

namespace Aqua
{
    public class MainController
    {
        public MainForm Parent { get; set; }

        public MainController(MainForm form)
        {
            Parent = form;
        }

        public void ShowDevTools()
        {
            if (Parent.Browser != null)
                Parent.Browser.ShowDevTools();
        }

        public void Close()
        {
            this.Parent.BeginInvoke(new Action(delegate ()
            {
                this.Parent.Close();
            }));
        }

        public void ToggleWindow()
        {
            this.Parent.BeginInvoke(new Action(delegate ()
            {
                if (this.Parent.WindowState == FormWindowState.Normal)
                    this.Parent.WindowState = FormWindowState.Maximized;
                else
                    this.Parent.WindowState = FormWindowState.Normal;
            }));
        }

        public void Minimize()
        {
            this.Parent.BeginInvoke(new Action(delegate ()
            {
                this.Parent.WindowState = FormWindowState.Minimized;
            }));
        }
    }
}
