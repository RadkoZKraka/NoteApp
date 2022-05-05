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
        private int _ret;
        private static string InputFile = File.ReadAllText(Const.FilePath);
        private ReadData Data = JsonSerializer.Deserialize<ReadData>(InputFile);
        public MainView()
        {
            InitializeComponent();
            GetNotes();
        }

        private void GetNotes()
        {
            var usersList = Data.Note.Keys.ToArray();

            if (comboBox1.InvokeRequired)
                comboBox1.Invoke((MethodInvoker) delegate { comboBox1.Items.AddRange(usersList); });
            else
            {
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(usersList);
            }
        }

        private void ShowNote(string selection, int pos)
        {
            
            var len = Data.Note[selection].Count;
            
            if (pos == 0) textBox1.Text = Data.Note[selection][pos];
            else
            {
                _ret += pos;
                if (_ret > len - 1) _ret = 0;
                if (_ret < 0) _ret = len - 1;
                
                textBox1.Text = Data.Note[selection][_ret];
            }

            label2.Text = $@"Notatki: {selection}";
        }

        private void AddNote(string note)
        {
            Data.Note[comboBox1.SelectedItem.ToString()].Add(note);
        }
        private void AddUser(string user)
        {
            textBox1.Text = String.Empty;
            Data.Note.Add(user,new List<string>()
            {
                textBox1.Text
            });
            comboBox1.Items.Add(user);
            comboBox1.SelectedItem = user;
        }
        private void RemoveNote()
        {
            Data.Note[comboBox1.SelectedItem.ToString()].Remove(textBox1.Text);
            textBox1.Text = Data.Note[comboBox1.SelectedItem.ToString()][_ret];
        }
        
        //newButton
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           
        }

        //delButton
        private void button4_Click(object sender, EventArgs e)
        {
            RemoveNote();   
        }

        //nextButton
        private void button1_Click(object sender, EventArgs e)
        {
            ShowNote(comboBox1.Text, 1);
        }

        //prevButton
        private void button2_Click(object sender, EventArgs e)
        {
            ShowNote(comboBox1.Text, -1);
        }

        //saveButton
        private void saveButton_Click(object sender, EventArgs e)
        {
            AddNote(textBox1.Text);
            var serializer = JsonSerializer.Serialize(Data);
            File.WriteAllText(Const.FilePath,serializer);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = comboBox1.SelectedItem;
            ShowNote(selection.ToString(), 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var newUser = Microsoft.VisualBasic.Interaction.InputBox("Question", "Test", "Użytkownik");
            AddUser(newUser);
            
        }
    }
}