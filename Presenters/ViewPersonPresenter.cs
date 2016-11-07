// ViewPersonPresenter - класс, отвечающий за взаимодействие между формой просмотра полной инофрмации и коллекцией. 

using System;
using System.Windows.Forms;
using NoteBook.Model;
using NoteBook.Views;

namespace NoteBook.Presenters
{
    class ViewPersonPresenter : Presenter
    {
        private ViewPersonWindow viewForm;

        public ViewPersonPresenter(ViewPersonWindow _window)
            : base()
        {
            this.viewForm = _window;
            this.viewForm.ViewData += ViewPerson;
        }

        // Просмотр полной информации о выбранном контактакте.
        private void ViewPerson(object sender, EventArgs e)
        {
            try
            {
                PersonToDataGridView(noteBook, viewForm, window.MainPersonListDataGridView);
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}