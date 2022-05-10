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
        private static readonly string InputFile = File.ReadAllText(Const.FilePath);

        //data wrapper nie powinien bezpośrednio zmieniać mainView tylko przyjmować akcje 
        
        private readonly MainView _mainView;
        private readonly FirstView _firstView;
        private readonly ReadData _data;
        
        //to powinien być main controller
        public DataWrapper( string filePath, MainView mainView = null, FirstView firstView = null)
        {
            _mainView = mainView;
            _firstView = firstView;
            _data = ReadFile(filePath);
        }

        public ReadData ReadFile(string filePath)
        {
            
            ReadData _data = JsonSerializer.Deserialize<ReadData>(InputFile);
            return _data;

        }
        public void GetNotes()
        {
            var usersList = _data.Note.Keys.ToArray();

            if (_firstView != null)
            {

                if (_firstView.noteList.InvokeRequired)
                    _firstView.noteList.Invoke((MethodInvoker) delegate { _firstView.noteList.Items.AddRange(usersList); });
                else
                {
                    _firstView.noteList.Items.Clear();
                    _firstView.noteList.Items.AddRange(usersList);
                    _firstView.noteList.SelectedIndex = 0;
                }
                return;
            }

            if (_mainView.comboBox1.InvokeRequired)
                _mainView.comboBox1.Invoke((MethodInvoker) delegate { _mainView.comboBox1.Items.AddRange(usersList); });
            else
            {
                _mainView.comboBox1.Items.Clear();
                _mainView.comboBox1.Items.AddRange(usersList);
                _mainView.comboBox1.SelectedIndex = 0;
            }
        }
        
        public void ShowNote(string selection, int pos)
        {
            var len = _data.Note[selection].Count;
            
            if (pos == 0) _mainView.textBox1.Text = _data.Note[selection][pos];
            else
            {
                _ret += pos;
                if (_ret > len - 1) _ret = 0;
                if (_ret < 0) _ret = len - 1;
                
                _mainView.textBox1.Text = _data.Note[selection][_ret];
            }

            _mainView.label2.Text = $@"Notatki: {selection}";
        }
        
        public void AddNote(string note)
        {
            _data.Note[_mainView.comboBox1.SelectedItem.ToString()].Add(note);
        }
        
        public void AddUser(string user)
        {
            if (_firstView != null)
            {
                _data.Note.Add(user,new List<string>() { });
                _firstView.noteList.Items.Add(user);
                _firstView.noteList.SelectedItem = user;
                return;
            }
            _mainView.textBox1.Text = String.Empty;
            _data.Note.Add(user,new List<string>()
            {
                _mainView.textBox1.Text
            });
            _mainView.comboBox1.Items.Add(user);
            _mainView.comboBox1.SelectedItem = user;
        }
        public void RemoveNote()
        {
            _data.Note[_mainView.comboBox1.SelectedItem.ToString()].Remove(_mainView.textBox1.Text);
            _mainView.textBox1.Text = _data.Note[_mainView.comboBox1.SelectedItem.ToString()][_ret];
        }
        public void RemoveUser()
        {
            var userToDelete = "";

            if (_firstView != null)
            {
                userToDelete = _firstView.noteList.SelectedItem.ToString() ?? "";
                _firstView.noteList.SelectedIndex = 0;
                _data.Note.Remove(userToDelete);
                GetNotes();
                return;
            }

            userToDelete = _mainView.comboBox1.SelectedItem.ToString();
            _data.Note.Remove(userToDelete);
            _mainView.comboBox1.SelectedIndex = 0;
        }
        
        public void SaveNote()
        {
            AddNote(_mainView.textBox1.Text);
            var serializer = JsonSerializer.Serialize(_data);
            File.WriteAllText(Const.FilePath,serializer);
        }
    }
}