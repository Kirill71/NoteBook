// ChangePersonPresenter - класс, отвечающий за взаимодействие между формой изменения контакта и коллекцией. 

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoteBook.Model;
using NoteBook.Views;

namespace NoteBook.Presenters
{
    class ChangePersonPresenter : Presenter
    {
        private ChangePerson changeForm;

        public ChangePersonPresenter(ChangePerson _window)
            : base()
        {
            this.changeForm = _window;
            this.changeForm.PersonLoad += LoadChangePerson;
            this.changeForm.Change += SaveChangePerson;
        }

        // Загрузка данных о выбранном контакте из коллекции на форму изменения.
        private void LoadChangePerson(object sender, EventArgs e)
        {
            Person temp = noteBook[window.MainPersonListDataGridView.CurrentRow.Index] as Person;
            OutputPersonInfoOnForm(temp);
        }

        // Сохранение измененных данных в коллекцию.
        private void SaveChangePerson(object sender, EventArgs e)
        {
            noteBook[window.MainPersonListDataGridView.CurrentRow.Index] = NewPerson(changeForm);
            MessageBox.Show("Запись изменена.");
            Refresh();
            changeForm.Close();
        }

        // Метод, обеспечивающий правильное отображения данных о выбранном контакте на форме.
        private void OutputPersonInfoOnForm(Person obj)
        {
            List<string> selectedRelations = new List<string>();
            LoadPersonalData(obj);
            LoadPhoneNumbersData(obj);
            LoadStudyData(obj);
            LoadWorkData(obj);
            LoadOtherData(obj, ref selectedRelations);
        }

        // Заполнение массива отношений данными о отношениях с данным контактом.
        private void GetRelationsType(Person obj, ref List<string> selectedRelations)
        {
            selectedRelations.AddRange(obj.OtherData.RelationsType.Split(';'));
        }

        // Получение индекса  типа знакомства для списка "Характер знакомств".
        private int GetRelationsIndexer(string arg)
        {
            switch (arg)
            {
                case " Друзья": { return 0; }
                case " Коллеги": { return 1; }
                case " Родственники": { return 2; }
                case " Другое": { return 3; }
                default: return -1;
            }
        }

        // Загрузка на форму персональных данных выбранного контакта из коллекции.
        private void LoadPersonalData(Person obj)
        {
            changeForm.SurnameTextBox.Text = obj.Data.Surname;
            changeForm.NameTextBox.Text = obj.Data.Name;
            changeForm.SecondNameTextBox.Text = obj.Data.SecondName;
            changeForm.AdressTextBox.Text = obj.Data.Adress;
            changeForm.BirthDayNumberComboBox.Text = obj.Data.DateBirth.Day.ToString();
            changeForm.BirthDayMonthComboBox.SelectedIndex = obj.Data.DateBirth.Month - 1;
            changeForm.BirsthDayYearComboBox.Text = obj.Data.DateBirth.Year.ToString();
        }

        // Загрузка на форму телефонных данных выбранного контакта из коллекции.
        private void LoadPhoneNumbersData(Person obj)
        {
            changeForm.MobilePhoneTextBox.Text = obj.Numbers.MobilePhone;
            changeForm.AltPhoneTextBox.Text = obj.Numbers.AltPhone;
        }

        // Загрузка на форму телефонных данных о образовании выбранного контакта из коллекции.
        private void LoadStudyData(Person obj)
        {
            changeForm.CollegeNameTextBox.Text = obj.StudyData.StudyPlace;
            changeForm.CollageFinishYearComboBox.Text = obj.StudyData.FinishYear;
        }

        // Загрузка на форму данных о трудоустройстве выбранного контакта из коллекции.
        private void LoadWorkData(Person obj)
        {
            changeForm.WorkPlaceNametextBox.Text = obj.WorkData.WorkPlace;
            changeForm.WorkPlaceFunctionTextBox.Text = obj.WorkData.WorkFunction;
        }

        // Загрузка дополнительных данных выбранного контакта из коллекции.
        private void LoadOtherData(Person obj, ref List<string> selectedRelations)
        {
            GetRelationsType(obj, ref selectedRelations);
            for (int i = 0; i < selectedRelations.Count - 1; i++)
            {
                changeForm.RelationsTypeCheckedListBox.SetItemChecked(GetRelationsIndexer(selectedRelations[i].ToString()), true);
            }
            changeForm.BusinessQualitiesTextBox.Text = obj.OtherData.BusinessQualities;
        }
    }
}
