// RegExPresenter - класс, отвечающий за корректный ввод некоторых данных(номера телефонов)

using System;
using System.Text.RegularExpressions;
using NoteBook.Views;
namespace NoteBook.Presenters
{
    class RegExPresenter
    {
        private Match match;
        private AbstractWindow form;

        public RegExPresenter(AbstractWindow _window)
        {
            match = null;
            form = _window;
            form.MobilePhone += CheckMobileNumber;
            form.AltPhone += CheckAltNumber;
        }

        // Проверка ввода в поле "Мобильный телефон".
        private void CheckMobileNumber(object sender, EventArgs e)
        {
            match = Regex.Match(form.MobilePhoneTextBox.Text, "^([0-9]+)$");
            if (!match.Success)
            {
                form.MobilePhoneTextBox.Clear();
            }
        }

        // Проверка ввода в поле "Домашний телефон".
        private void CheckAltNumber(object sender, EventArgs e)
        {
            match = Regex.Match(form.AltPhoneTextBox.Text, "^([0-9]+)$");
            if (!match.Success)
            {
                form.AltPhoneTextBox.Clear();
            }
        }
    }
}
