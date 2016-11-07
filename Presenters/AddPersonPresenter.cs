// AddPersonPresenter - класс, отвечающий за взаимодействие между формой добавления контакта и коллекцией. 

using System;
using System.Windows.Forms;
using NoteBook.Model;
using NoteBook.Views;

namespace NoteBook.Presenters
{
    class AddPersonPresenter : Presenter
    {
        private AddPersonWindow addForm;

        public AddPersonPresenter(AddPersonWindow _window)
            : base()
        {
            addForm = _window;
            addForm.Save += SavePerson;
        }

        // Создание нового контакта в записной книжке. 
        private void SavePerson(object sender, EventArgs e)
        {
            try
            {
                noteBook.AddPerson(NewPerson(addForm));
                Refresh();
                MessageBox.Show("Запись добавлена.");
                addForm.Close();
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
    }
}