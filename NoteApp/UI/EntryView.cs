using System;
using System.Windows.Forms;
using NoteApp.Controllers;
using NoteApp.Lib;

namespace NoteApp.UI
{
    public partial class FirstView : UserControl
    {
        private readonly DataWrapper _dataWrapper;
        private MainController _mainController;

        public FirstView()
        {
            _dataWrapper = new DataWrapper(firstView: this);
            _mainController = new MainController(_dataWrapper);
            InitializeComponent();
            _mainController.GetNotes();
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadNoteList_Click(object sender, EventArgs e)
        {
            EntryForm entryForm = new EntryForm(this);
            entryForm.StartProgram();
        }

        private void addNoteList_Click(object sender, EventArgs e)
        {
            var newUser = Microsoft.VisualBasic.Interaction.InputBox("Question", "Test", "Użytkownik");
            _mainController.AddUser(newUser);
        }

        private void deleteNoteList_Click(object sender, EventArgs e)
        {
            _mainController.RemoveUser();
        }
    }
}