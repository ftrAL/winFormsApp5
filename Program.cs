using System;
using System.Windows.Forms;
using WinFormsApp5;

namespace MyEducationApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Langsung buka FormGrafik
            Application.Run(new FormGrafik());
        }
    }
} 