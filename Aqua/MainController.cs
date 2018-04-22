using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;

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
    }
}
