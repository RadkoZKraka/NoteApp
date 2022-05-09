using System.Threading;
using System.Windows.Forms;
using NoteApp.Controllers;

namespace NoteApp.UI
{
    public partial class EntryForm : Form
    {
        private Thread th;

        public EntryForm(Control entryView)
        {
            
            InitializeComponent();
            Controls.Add(entryView);
            entryView.Dock = DockStyle.Fill;
        }

        public void StartProgram()
        {
            FormController.StartProgram(this);
            Hide();
            Application.Exit();
        }
    }
}