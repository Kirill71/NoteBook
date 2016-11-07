// Класс, предоставляющий сортировку по алфавиту.

using System;
using System.Collections;

namespace NoteBook.Model
{
    class AscendingComparer : Comparer
    {
        public AscendingComparer()
        {
            comparer = new CaseInsensitiveComparer();
        }

        public override int Compare(object _x, object _y)
        {
            Person x = _x as Person;
            Person y = _y as Person;
            return comparer.Compare(x.Data.Surname, y.Data.Surname);
        }
    }
}
