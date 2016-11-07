// Класс,предоставляющий сортировку по дате последнего изменения.

using System;
using System.Collections;

namespace NoteBook.Model
{
    class DateComparer : AscendingComparer
    {
        public DateComparer() : base() { }

        public override int Compare(object _x, object _y)
        {
            Person x = _x as Person;
            Person y = _y as Person;
            return comparer.Compare(y.LastCorrectionDate, x.LastCorrectionDate);
        }
    }
}
