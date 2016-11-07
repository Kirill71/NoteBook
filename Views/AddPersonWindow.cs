// AddPersonWindow  - класс, представляющий форму добавления контакта.

using System;
using System.Drawing;
using System.Windows.Forms;
using NoteBook.Presenters;
namespace NoteBook.Views
{
    public partial class AddPersonWindow : AbstractWindow
    {
        public AddPersonWindow()
        {
             save = null;
            InitializeComponent();
            new AddPersonPresenter(this);
        }
     
        private void SavePersonButton_Click(object sender, EventArgs e)
        {
            save(sender, e);
        }

        private EventHandler save;

        #region События.

        public event EventHandler Save
        {
            add { save += value; }
            remove { save -= value; }

        }

        #endregion
    
    }
}
