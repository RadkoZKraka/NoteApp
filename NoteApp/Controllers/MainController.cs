using System.Threading;
using System.Windows.Forms;
using NoteApp.Lib;
using NoteApp.UI;

namespace NoteApp.Controllers
{
    //controller powinien przyjmować data wrappera i main view by przyjmował controllera zamiast wrappera i controller powinien w sumie mieć odwołania do wrappera i jego metod
    //wrapper nie powinien być wywoływane z mainview tylko z controller
    //ToDo: poprawne usuwanie użytkowników
    //ToDo: by mainView ładował się z poprawnym użytkownikiem wybranym
    public class MainController
    {
        private Thread th;
        private readonly DataWrapper _dataWrapper;

        public MainController(DataWrapper dataWrapper)
        {
            _dataWrapper = dataWrapper;
        }

        public void GetNotes()
        {
            _dataWrapper.GetNotes();
        }
        
        public void ShowNote(string selection, int pos)
        {
            _dataWrapper.ShowNote(selection,pos);
        }
        
        public void AddNote(string note)
        {
            _dataWrapper.AddNote(note);
        }
        
        public void AddUser(string user)
        {
            _dataWrapper.AddUser(user);
        }
        
        public void RemoveNote()
        {
            _dataWrapper.RemoveNote();
        }
        
        public void RemoveUser()
        {
            _dataWrapper.RemoveUser();
        }
        
        public void SaveNote()
        {
            _dataWrapper.SaveNote();
        }
        
    }
}