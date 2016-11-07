// Класс, предоставляющий  сортировку по алфавиту в обратном порядке.

using System;
using System.Collections;

namespace NoteBook.Model
{
    class DescendingComparer : AscendingComparer
    {
        public DescendingComparer() : base() { }

        public override int Compare(object y, object x)
        {
            return base.Compare(x, y);
        }
    }
}
