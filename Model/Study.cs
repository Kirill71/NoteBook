// Класс, описывающий  годе завершения и месте учебы персон в записной книжке.

using System;

namespace NoteBook.Model
{
    [Serializable]
    class Study
    {
        private string studyPlace;
        private string finishYear;

        private Study(string _studyPlace, string _finishYear)
        {
            this.studyPlace = _studyPlace;
            this.finishYear = _finishYear;
        }

        #region  Свойства - геттеры.

        public string StudyPlace
        {
            get { return studyPlace; }
        }

        public string FinishYear
        {
            get { return finishYear; }
        }

        #endregion

        public override string ToString()
        {
            return string.Format("\n\n Место учёбы: {0}.\n Год окончания: {1}.\n\n", this.studyPlace, this.finishYear);
        }

        // Создание экземпляра класа, хранящего данные о образовании контакта.
        public static Study InputStudyData(string place, string year)
        {
            return new Study(place, year);
        }
    }
}
