// Абстрактный класс, наследующий интерфейс IComparer и являющийся базовым для всех классов - компараторов.

using System;
using System.Collections;

namespace NoteBook.Model
{
    abstract class Comparer : IComparer
    {
        protected CaseInsensitiveComparer comparer; // Проверяет равенство двух объектов без учета регистра строк.
        abstract public int Compare(object x, object y);
    }
}
