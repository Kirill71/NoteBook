//Класс, описывающий контакт(персону) из записной книжки.

using System;

namespace NoteBook.Model
{
    [Serializable]
    class Person
    {
        private PersonalData data;
        private Phone phoneNumbers;
        private Study studyPlace;
        private Work workPlace;
        private Other otherData;
        private DateTime lastCorrectionDate;

        private Person(PersonalData _newPerson,
            Phone _newPhone,
            Study _newStudyPlace,
            Work _newWorkPlace,
            Other _newOtherData)
        {
            this.data = _newPerson;
            this.phoneNumbers = _newPhone;
            this.studyPlace = _newStudyPlace;
            this.workPlace = _newWorkPlace;
            this.otherData = _newOtherData;
            this.lastCorrectionDate = DateTime.Now;
        }

        #region Свойства - геттеры.

        public PersonalData Data
        {
            get { return data; }
        }

        public Phone Numbers
        {
            get { return phoneNumbers; }
        }

        public Study StudyData
        {
            get { return studyPlace; }
        }

        public Work WorkData
        {
            get { return workPlace; }
        }

        public Other OtherData
        {
            get { return otherData; }
        }

        public DateTime LastCorrectionDate
        {
            get { return lastCorrectionDate; }
        }

        #endregion

        public override string ToString()
        {
            return string.Format("Личные данные:{0} Телефоны:{1} Образование:{2} Работа:{3} Другое:{4} Дата изменения:{5}", this.data, this.phoneNumbers, this.studyPlace, this.workPlace, this.otherData, this.lastCorrectionDate);
        }

        // Создание нового контакта в записной кнажке.
        public static Person CreatePerson(PersonalData newPerson, Phone newPhone, Study newStudyPlace, Work newWorkPlace, Other newOtherData)
        {
            return new Person(newPerson, newPhone, newStudyPlace, newWorkPlace, newOtherData);
        }
    }
}
