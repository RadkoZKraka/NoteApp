using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp.UI;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        public Form1(Control mainView)
        {
            InitializeComponent();
            Controls.Add(mainView);
            mainView.Dock = DockStyle.Fill;
            
        }
        public void StartProgram()
        {
            var mainView = new MainView();
            Form1 form1 = new Form1(mainView);
            form1.ShowDialog(mainView);
        }
    }
}