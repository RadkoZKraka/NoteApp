using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using NoteApp.UI;

namespace NoteApp.Lib
{
    public class DataWrapper
    {
        private int _ret;
        private static string InputFile = File.ReadAllText(Const.FilePath);
        private ReadData Data = JsonSerializer.Deserialize<ReadData>(InputFile);
        private MainView _mainView = new MainView();
        
        public void GetNotes()
        {
            var usersList = Data.Note.Keys.ToArray();

            if (_mainView.comboBox1.InvokeRequired)
                _mainView.comboBox1.Invoke((MethodInvoker) delegate { _mainView.comboBox1.Items.AddRange(usersList); });
            else
            {
                _mainView.comboBox1.Items.Clear();
                _mainView.comboBox1.Items.AddRange(usersList);
            }
        }
        
        public void ShowNote(string selection, int pos)
        {
            var len = Data.Note[selection].Count;
            
            if (pos == 0) _mainView.textBox1.Text = Data.Note[selection][pos];
            else
            {
                _ret += pos;
                if (_ret > len - 1) _ret = 0;
                if (_ret < 0) _ret = len - 1;
                
                _mainView.textBox1.Text = Data.Note[selection][_ret];
            }

            _mainView.label2.Text = $@"Notatki: {selection}";
        }
        
        public void AddNote(string note)
        {
            Data.Note[_mainView.comboBox1.SelectedItem.ToString()].Add(note);
        }
        
        public void AddUser(string user)
        {
            _mainView.textBox1.Text = String.Empty;
            Data.Note.Add(user,new List<string>()
            {
                _mainView.textBox1.Text
            });
            _mainView.comboBox1.Items.Add(user);
            _mainView.comboBox1.SelectedItem = user;
        }
        public void RemoveNote()
        {
            Data.Note[_mainView.comboBox1.SelectedItem.ToString()].Remove(_mainView.textBox1.Text);
            _mainView.textBox1.Text = Data.Note[_mainView.comboBox1.SelectedItem.ToString()][_ret];
        }
        
        public void SaveNote()
        {
            AddNote(_mainView.textBox1.Text);
            var serializer = JsonSerializer.Serialize(Data);
            File.WriteAllText(Const.FilePath,serializer);
        }
    }
}