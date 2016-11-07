// AbstractWindow - класс, от которого наследуются формы добавления и изменения контакта.

using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NoteBook.Presenters;
namespace NoteBook.Views
{
    public   partial  class AbstractWindow : Form
    {
        public AbstractWindow()
        {
            mobilePhone = null;
            altPhone = null;
            InitializeComponent();
            new RegExPresenter(this);
        }
     
        private void MobilePhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            mobilePhone(sender, e);
        }

        private void AltPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            altPhone(sender, e);
        }

        #region Делегаты.

        private EventHandler mobilePhone;
        private EventHandler altPhone;

        #endregion

        #region События.
        public event EventHandler MobilePhone
        {
            add { mobilePhone += value; }
            remove { mobilePhone -= value; }
        }

        public event EventHandler AltPhone
        {
            add { altPhone += value; }
            remove { altPhone -= value; }
        }
        #endregion 

        }

    }

