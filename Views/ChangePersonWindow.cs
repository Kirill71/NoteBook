// ChangePersonWindow  - класс, представляющий форму изменения контакта.

using System;
using System.Drawing;
using System.Windows.Forms;
using NoteBook.Presenters;

namespace NoteBook.Views
{
    public partial class ChangePerson : AbstractWindow
    {

        public ChangePerson()
        {
            load = null;
            change = null;
            InitializeComponent();
            new ChangePersonPresenter(this);
        }

        private void ChangePerson_Load(object sender, EventArgs e)
        {
            load(sender, e);
        }

        private void ChangePersonButton_Click(object sender, EventArgs e)
        {
            change(sender, e);
        }

        #region Делегаты.

        private EventHandler load;
        private EventHandler change;

        #endregion

        #region События

        public event EventHandler PersonLoad
        {
            add { load += value; }
            remove { load -= value; }
        }
        public event EventHandler Change
        {
            add { change += value; }
            remove { change -= value; }
        }

        #endregion

    }
}