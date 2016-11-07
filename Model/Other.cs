// Класс, описывающий дополнительные данные( характер знакомства, деловые качества) персоны.  

using System;

namespace NoteBook.Model
{
    [Serializable]
    class Other
    {
        private string relationsType;
        private string businessQualities;

        private Other(string _relationsType, string _businessQualities)
        {
            this.relationsType = _relationsType;
            this.businessQualities = _businessQualities;
        }

        #region Свойства - геттеры.

        public string RelationsType
        {
            get { return relationsType; }
        }

        public string BusinessQualities
        {
            get { return businessQualities; }
        }

        #endregion

        // Создание экземпляра, который хранит дополнительные данные экземпляра.
        public static Other InputOtherData(string type, string qualities)
        {
            return new Other(type, qualities);
        }

        public override string ToString()
        {
            return string.Format("\n\n Характер знакомства:{0}\n Деловые качества: {1}.\n\n", this.relationsType, this.businessQualities);
        }
    }
}
