﻿using System;
using System.Configuration;
using System.Windows.Forms;

namespace DeploymentBuddy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var settingsFileLocation = ConfigurationManager.AppSettings["settingsFileLocation"];
            Singleton.Instance.Load(settingsFileLocation);
            
            Application.Run(new Dashboard());
        }
    }
}
