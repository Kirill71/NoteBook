// Класс, описывающий место работы и должность некоторых персон в записной книжке.

using System;

namespace NoteBook.Model
{
[Serializable]
    class Work
    {
        private string workPlace;
        private string workFunction;

        private Work(string _workPlace, string _workFunction)
        {
            this.workPlace = _workPlace;
            this.workFunction = _workFunction;
        }

        #region  Свойства - геттеры

        public string WorkPlace
        {
            get { return workPlace; }
        }

        public string WorkFunction
        {
            get { return workFunction; }
        }

        #endregion

        public override string ToString()
        {
            return string.Format("\n\n Место работы: {0}.\n Должность: {1}.\n\n", this.workPlace, this.workFunction);
        }

    // Создание экземпляра класса, хранящего данные о трудоустройстве контакта.
        public static Work InputWorkData( string place, string function)
        {
            return new Work(place,function);
        }
    }
}
