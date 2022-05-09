using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp.Lib;
using NoteApp.UI;

namespace NoteApp
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

            Run();
        }

        static void Run()
        {
            FirstView firstView = new FirstView();
            Application.Run(new EntryForm(firstView));
        }
    }
}