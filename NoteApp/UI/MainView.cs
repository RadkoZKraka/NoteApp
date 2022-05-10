using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using NoteApp.Controllers;
using NoteApp.Lib;

namespace NoteApp.UI
{
    public partial class MainView : UserControl
    {
        private readonly DataWrapper _dataWrapper;
        private MainController _mainController;
        public MainView()
        {
            _dataWrapper = new DataWrapper(filePath: @"C:\Notatki",this);
            _mainController = new MainController(_dataWrapper);
            InitializeComponent();
            _mainController.GetNotes();
        }
        
        //newButton
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; //jakims cudem to działa ale nie rozumiem jak to rozkminiłem
        }

        //delButton
        private void button4_Click(object sender, EventArgs e)
        {
            _mainController.RemoveNote();
        }

        //nextButton
        private void button1_Click(object sender, EventArgs e)
        {
            _mainController.ShowNote(comboBox1.Text, 1);
        }

        //prevButton
        private void button2_Click(object sender, EventArgs e)
        {
            _mainController.ShowNote(comboBox1.Text, -1);
        }

        //saveButton
        private void saveButton_Click(object sender, EventArgs e)
        {
            _mainController.SaveNote();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = comboBox1.SelectedItem;
            _mainController.ShowNote(selection.ToString(), 0);
        }
        
        //addUser
        private void button1_Click_1(object sender, EventArgs e)
        {
            var newUser = Microsoft.VisualBasic.Interaction.InputBox("Question", "Test", "Użytkownik");
            _mainController.AddUser(newUser);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            _mainController.RemoveUser();
        }
    }
}