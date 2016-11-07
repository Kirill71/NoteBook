// Класс, описывающий личные данные каждого контакта(персоны) в записной книжке.

using System;

namespace NoteBook.Model
{
    [Serializable]
    class PersonalData
    {
        private string surname;
        private string name;
        private string secondName;
        private string adress;
        private DateTime dateBirth;

        private PersonalData(string _surname, string _name, string _secondName, string _adress, DateTime _dateBirth)
        {
            this.surname = _surname;
            this.name = _name;
            this.secondName = _secondName;
            this.adress=_adress;
            this.dateBirth = _dateBirth;
        }

        #region Свойства - геттеры.

        public string Surname
        {
            get { return surname; }
        }

        public string Name
        {
            get { return name; }
        }

        public string SecondName
        {
            get { return secondName; }
        }

        public string Adress
        {
            get { return adress; }
        }

        public DateTime DateBirth
        {
            get { return dateBirth; }
        }

        #endregion

        public override string ToString()
        {
            string temp = this.dateBirth.ToString();
            temp = temp.Remove(10);
            return string.Format("\n\n Фамилия: {0}.\n Имя: {1}.\n Отчество: {2}.\n Дата Рождения: {3}.\n Адресс: {4}.\n\n", this.surname, this.name, this.secondName, temp, this.adress);
        }

        // Созданание экземпляра класса, который хранит личные данные.
        public static PersonalData InputPersonalData(string surname, string name, string second,string adress, string day, int month, string year)
        {
            return new PersonalData(surname, name, second,adress, new DateTime(Convert.ToInt32(year), month + 1, Convert.ToInt32(day)));
        }


    }
}
