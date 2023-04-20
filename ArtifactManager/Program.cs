using System;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.Interface;

namespace ArtifactManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String info = "Please check, that you have working MSSMS installed\n" +
                          "LocalDB is not enough!!";
            
            MessageBox.Show(info, @"REQUIREMENTS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppStart());
            // Application.Run(new Form1());
        }
    }
}