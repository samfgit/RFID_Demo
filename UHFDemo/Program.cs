﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UHFDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point of application program.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new R2000UartDemo());
        }
    }
}
