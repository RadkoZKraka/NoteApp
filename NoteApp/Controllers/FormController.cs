using System.Threading;
using System.Windows.Forms;
using NoteApp.UI;

namespace NoteApp.Controllers
{
    public static class FormController
    {
        private static Thread th;
        public static void StartProgram(EntryForm entryForm)
        {
            entryForm.Dispose();
            th = new Thread(openMainView);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private static void openMainView()
        {
            MainView mainView = new MainView();
            Application.Run(new Form1(mainView));
        }
    }
}