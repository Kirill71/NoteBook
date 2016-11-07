// Presenters - класс, базовый почти для всех классов в пространстве имен NoteBook.Presenters,
// содержит основные методы необходимые для взаимодействия между формами и коллецией.

using System;
using System.Windows.Forms;
using NoteBook.Views;
using NoteBook.Model;

namespace NoteBook.Presenters
{
    class Presenter
    {
        protected static NoteBookList noteBook;
        protected static MainWindow window;
        protected bool flag;

        public Presenter() { }

        // Метод, обновляющие все списки(DataGridView) в программе.
        protected void Refresh()
        {
            window.MainPersonListDataGridView.Rows.Clear();
            LoadMainList(noteBook, window.MainPersonListDataGridView);
        }

        // Открытие любой формы.
        protected void OpenForm(Form form)
        {
            if (flag)
            {
                form.Show();
                flag = false;
            }
            form.FormClosing += FormClosing;
        }

        // Проверяет что бы создавался только 1 экземпляр открытой формы.
        private void FormClosing(object sender, FormClosingEventArgs e)
        {
            flag = true;
        }

        // Метод, загружающий данные из коллекции во все списки(DataGridView) в программе.
        protected void LoadMainList(NoteBookList list, DataGridView dataGridView)
        {
            Person temp;
            if (list.Count <= 0) return;
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView.Rows.Add();
                temp = list[i] as Person;
                if (temp != null)
                {
                    dataGridView[0, i].Value = temp.Data.Surname;
                    dataGridView[1, i].Value = temp.Data.Name;
                    dataGridView[2, i].Value = temp.Data.SecondName;
                    dataGridView[3, i].Value = temp.Numbers.MobilePhone;
                }

            }
        }

        // Заполнение полей ввода по умолчанию.
        protected string ArgumentScan(string arg)
        {
            if (arg.Length == 0)
            {
                return arg = "Информация не добавлена";
            }
            else
            {
                return arg;
            }
        }

        // Заполнение полей ввода даты по умолчанию.
        protected void DateArgumentScan(AbstractWindow form)
        {
            if (form.BirthDayNumberComboBox.SelectedItem == null) form.BirthDayNumberComboBox.SelectedItem = "1";
            if (form.BirthDayMonthComboBox.SelectedIndex == -1) form.BirthDayMonthComboBox.SelectedIndex = 0;
            if (form.BirsthDayYearComboBox.SelectedItem == null) form.BirsthDayYearComboBox.SelectedItem = "2000";

        }

        //  Добавления в коллекцию  нового контакта или изменения.
        protected Person NewPerson(AbstractWindow form)
        {
            PersonalData newPerson = NewPersonalData(ref form);
            Phone newPhone = NewPhone(ref form);
            Study newStudyPlace = NewStudyPlace(ref form);
            Work newWorkPlace = NewWorkPlace(ref form);
            Other newOtherData = NewOtherData(ref form);

            return Person.CreatePerson(newPerson, newPhone, newStudyPlace, newWorkPlace, newOtherData);
        }

        // Считывание персональных данных с формы добавления или изменения.
        private PersonalData NewPersonalData(ref  AbstractWindow form)
        {
            DateArgumentScan(form);
            return PersonalData.InputPersonalData(
               ArgumentScan(form.SurnameTextBox.Text),
               ArgumentScan(form.NameTextBox.Text),
               ArgumentScan(form.SecondNameTextBox.Text),
               ArgumentScan(form.AdressTextBox.Text),
            form.BirthDayNumberComboBox.SelectedItem.ToString(),
              form.BirthDayMonthComboBox.SelectedIndex,
            form.BirsthDayYearComboBox.SelectedItem.ToString()
              );
        }
        // Считывание телефонных данных с формы добавления или измененения.
        private Phone NewPhone(ref AbstractWindow form)
        {
            return Phone.InputPhoneData(ArgumentScan(form.MobilePhoneTextBox.Text), ArgumentScan(form.AltPhoneTextBox.Text));
        }

        // Считывание данных  о образовании с формы добавления или изменения.
        private Study NewStudyPlace(ref AbstractWindow form)
        {
            return Study.InputStudyData(ArgumentScan(form.CollegeNameTextBox.Text), ArgumentScan(form.CollageFinishYearComboBox.Text));
        }

        // Считывание данных  о трудоустройстве с формы добавления или изменения.
        private Work NewWorkPlace(ref AbstractWindow form)
        {
            return Work.InputWorkData(ArgumentScan(form.WorkPlaceNametextBox.Text), ArgumentScan(form.WorkPlaceFunctionTextBox.Text));
        }

        // Считывание данных о типе знакомства с формы добавления или изменения.
        private string RelationsTypeToString(ref AbstractWindow form)
        {
            string relationsType = "";
            foreach (var item in form.RelationsTypeCheckedListBox.CheckedItems)
                relationsType += " " + item.ToString() + ";";
            return relationsType;
        }
        //  Считывание дополнительных данных.
        private Other NewOtherData(ref AbstractWindow form)
        {
            return Other.InputOtherData(ArgumentScan(RelationsTypeToString(ref form)), ArgumentScan(form.BusinessQualitiesTextBox.Text));
        }

        //  Вывод  информации о конкретной персоне в форму просмотра.
        protected void PersonToDataGridView(NoteBookList list, Form form, DataGridView dataGridView)
        {
            ViewPersonWindow viewform = form as ViewPersonWindow;
            viewform.ViewPersonDataRichTextBox.Text = list[dataGridView.CurrentRow.Index].ToString();
        }
    }
}