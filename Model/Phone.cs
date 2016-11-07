// Класс, описывающий телефоны каждого контакта(персоны) в записной книжке.

using System;

namespace NoteBook.Model
{
  [Serializable]
    class Phone
    {
        private string mobilePhone;
        private string altPhone;

       private Phone(string _mobilePhone, string _altPhone)
        {
            this.mobilePhone = _mobilePhone;
            this.altPhone = _altPhone;
        }

        #region Свойста - геттеры.

        public string MobilePhone
        {
            get { return mobilePhone; }
        }

        public string AltPhone
        {
            get { return altPhone; }
        }

        #endregion

        public override string ToString()
        {
            return string.Format(" \n\n Мобильный телефон: {0}. \n Домашний телефон: {1}.\n\n", this.mobilePhone, this.altPhone);
        }
      // Создание экземпляра класа отвечающего за хранение телефонов контакта.
        public static Phone InputPhoneData(string mobile, string alt)
        {
            return new Phone(mobile, alt);
        }
    }
}
