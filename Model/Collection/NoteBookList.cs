// Класс - коллекция, содержащая все записи записной книги.

using System.Data;
using System;
using System.Collections;

namespace NoteBook.Model
{
    [Serializable]
    class NoteBookList : IEnumerable
    {
        private ArrayList contactList;
        private int position; // Указатель текущей позиции элемента в коллекции.

        public NoteBookList()
        {
            position = -1;
            contactList = new ArrayList();
        }

        public int Count
        {
            get { return contactList.Count; }
        }

        public object this[int index]
        {
            get { return contactList[index]; }
            set { contactList[index] = value; }
        }

        public void AddPerson(Person newPerson)
        {

            contactList.Add(newPerson);
        }

        public void DeletePerson(int index)
        {
            try
            {
                contactList.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        public void Sort(Comparer obj)
        {
            contactList.Sort(obj);
        }

        // Реализация интерфейса - IEnumerable.

        public void Reset() // Установить указатель (position) перед началом набора.
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                if (position < contactList.Count - 1)
                {
                    position++;
                    yield return contactList[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }
    }
}
