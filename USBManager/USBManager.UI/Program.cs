﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using USBManager.UI.Commons;
using USBManager.UI.Views.MainViews;

namespace USBManager.UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            R.MainUI = new MainForm();
            Application.Run(R.MainUI);
        }
    }
}
