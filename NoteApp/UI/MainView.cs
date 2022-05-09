using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using NoteApp.Lib;

namespace NoteApp.UI
{
    public partial class MainView : UserControl
    {
        private DataWrapper _dataWrapper = new DataWrapper();
        public MainView()
        {
            InitializeComponent();

        }

        //newButton
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        //delButton
        private void button4_Click(object sender, EventArgs e)
        {
            _dataWrapper.RemoveNote();
        }

        //nextButton
        private void button1_Click(object sender, EventArgs e)
        {
            _dataWrapper.ShowNote(comboBox1.Text, 1);
        }

        //prevButton
        private void button2_Click(object sender, EventArgs e)
        {
            _dataWrapper.ShowNote(comboBox1.Text, -1);
        }

        //saveButton
        private void saveButton_Click(object sender, EventArgs e)
        {
            _dataWrapper.SaveNote();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = comboBox1.SelectedItem;
            _dataWrapper.ShowNote(selection.ToString(), 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var newUser = Microsoft.VisualBasic.Interaction.InputBox("Question", "Test", "Użytkownik");
            _dataWrapper.AddUser(newUser);
        }

        private void loadNotes_Click(object sender, EventArgs e)
        {
            _dataWrapper.GetNotes();
        }
    }
}