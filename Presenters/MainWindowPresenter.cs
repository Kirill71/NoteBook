// MainWindowPresenter - класс, отвечающий за взаимодействие между главной формой и коллекцией. 

using System;
using System.Windows.Forms;
using System.Data;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using NoteBook.Model;
using NoteBook.Views;

namespace NoteBook.Presenters
{
    class MainWindowPresenter : Presenter
    {
        public MainWindowPresenter(MainWindow _window)
            : base()
        {
            flag = true;
            window = _window;
            noteBook = new NoteBookList();

            #region Привязка методов к событиям.
            window.LoadMainWindow += MainWindowLoad;
            window.Add += AddPersonOpenForm;
            window.Change += ChangePersonOpenForm;
            window.Delete += DeletePerson;
            window.AscSort += AlphabetAscSort;
            window.DescSort += AlphabetDescSort;
            window.DateSort += DateLastCorrectionDescSort;
            window.View += ViewPersonDataOpenForm;
            window.FormClosing += MainWindowClosening;
            window.Search += SearchPerson;
            window.CelebrateBirthDay += CelebrateBirthDay;
            window.HelpRequest += HelpMethod;
            #endregion
        }
        // Проверка действий совершаемых пользователем.
        private void CheckForm(Form form, string str)
        {
            if (СheckErrorType(window.MainPersonListDataGridView.CurrentRow))
            {
                if (noteBook.Count > 0 && noteBook.Count > window.MainPersonListDataGridView.CurrentRow.Index)
                {
                    OpenForm(form);
                }
                else
                {
                    if (form.GetType() == typeof(ViewPersonWindow))
                    {
                        CheckMessage(noteBook.Count, "просмотреть");
                    }
                    else
                        CheckMessage(noteBook.Count, "изменить");
                }
            }
            else
            {
                MessageBox.Show("Запись для " + str + "не выбрана!");
                return;
            }
        }

        // Проверка действий для кнопки "Удалить запись".
        private void CheckForm(string str)
        {
            if (СheckErrorType(window.MainPersonListDataGridView.CurrentRow))
            {
                if (noteBook.Count > 0 && noteBook.Count > window.MainPersonListDataGridView.CurrentRow.Index)
                {

                    DeleteChecking();
                }
                else
                {
                    CheckMessage(noteBook.Count, "удалить");
                }
            }
            else
            {
                MessageBox.Show("Запись для " + str + "не выбрана!");
                return;
            }
        }

        // Позволяет определить, что либо пользователь не выбрал запись для работы.
        private bool СheckErrorType(DataGridViewRow obj)
        {
            if (obj == null) return false;
            else return true;
        }

        // Открытие формы просмотра.
        private void ViewPersonDataOpenForm(object sender, EventArgs e)
        {
            ViewPersonWindow viewForm = new ViewPersonWindow();
            CheckForm(viewForm, "просмотра ");
        }

        // Открытие формы добавления.
        private void AddPersonOpenForm(object sender, EventArgs e)
        {
            AddPersonWindow addForm = new AddPersonWindow();
            OpenForm(addForm);
        }

        // Открытие формы изменения.
        private void ChangePersonOpenForm(object sender, EventArgs e)
        {
            ChangePerson changeForm = new ChangePerson();
            CheckForm(changeForm, "изменения ");
        }

        // Удаление контакта.
        private void DeletePerson(object sender, EventArgs e)
        {
            CheckForm("удаления ");
        }

        // Подтверждение удаления.
        private void DeleteChecking()
        {
            DialogResult result;
            if (flag)
            {
                result = MessageBox.Show("Вы настаиваете на удалении?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    noteBook.DeletePerson(window.MainPersonListDataGridView.CurrentRow.Index);// Удаление строки из коллекции.
                    window.MainPersonListDataGridView.Rows.Remove(window.MainPersonListDataGridView.CurrentCell.OwningRow);// Удаление строки из элемента упраавления.
                }
            }
            else
            {
                return;
            }
        }


        private void AlphabetAscSort(object sender, EventArgs e)
        {
            noteBook.Sort(new AscendingComparer());
            Refresh();
        }

        private void AlphabetDescSort(object sender, EventArgs e)
        {
            noteBook.Sort(new DescendingComparer());
            Refresh();
        }

        private void DateLastCorrectionDescSort(object sender, EventArgs e)
        {
            noteBook.Sort(new DateComparer());
            Refresh();
        }

        // Cоздание нового байтового потока.
        private FileStream CreateFileStream(string path, FileMode mode)
        {
            return new FileStream(path, mode);
        }

        private void Serialize()
        {
            FileStream writeStream = CreateFileStream("NoteBookDataBase.xml", FileMode.Create);
            SoapFormatter serializeFormatter = new SoapFormatter();
            serializeFormatter.Serialize(writeStream, noteBook);
            writeStream.Close();
        }

        private void Deserialize(object sender, EventArgs e)
        {
            FileStream readStream = CreateFileStream("NoteBookDataBase.xml", FileMode.OpenOrCreate);
            if (readStream.Length == 0)
            {
                return;
            }
            else
            {
                SoapFormatter deserializeFormatter = new SoapFormatter();
                noteBook = deserializeFormatter.Deserialize(readStream) as NoteBookList;
                LoadMainList(noteBook, window.MainPersonListDataGridView);
            }
            readStream.Close();
        }

        // Метод - обработчик события, срабатывающий при заакрытии формы.
        private void MainWindowClosening(object sender, EventArgs e)
        {
            Serialize();
        }

        // Метод - обработчик события, срабатывающий при загрузки формы.
        private void MainWindowLoad(object sender, EventArgs e)
        {
            Deserialize(sender, e);
        }

        // Метод, определяющий именинников сегодня.
        private void CelebrateBirthDay(object sender, EventArgs e)
        {
            string celebrateList = null;
            foreach (Person item in noteBook)
            {
                if (item.Data.DateBirth.Day == DateTime.Now.Day && item.Data.DateBirth.Month == DateTime.Now.Month)
                {
                    celebrateList += item.Data.Name + " " + item.Data.Surname + "; \n";
                }
            }
            if (celebrateList != null)
            {
                MessageBox.Show("Дни рождения сегодня :\n " + celebrateList, DateTime.Now.ToString().Remove(10));
            }
        }

        // Метод выполняющийся при нажатии кнопки "Поиск".
        private void SearchPerson(object sender, EventArgs e)
        {
            if (window.SearchTextBox.TextLength == 0)
            {
                MessageBox.Show(" Данные для поиска не введены!");
                return;
            }
            else
            {
                SearchResultWindow searchPerson = new SearchResultWindow();
                OpenForm(searchPerson);
                if (searchPerson.SearchResaltListDataGridView.CurrentRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Ничего не найдено.");
                    searchPerson.Close();
                }
            }
        }

        // Вспомогательный метод для избегания исключений.
        private void CheckMessage(int index, string str)
        {
            if (index <= 0)
            {
                MessageBox.Show("Записная книжка пуста!");
                return;
            }
            else
            {
                MessageBox.Show("Нельзя " + str + " пустую строку!");
                return;
            }
        }

        // Справка(F1).
        private void HelpMethod(object sender, EventArgs e)
        {
            Helper helpForm = new Helper();
            OpenForm(helpForm);
//            ViewPersonWindow helpForm = new ViewPersonWindow();
//            FileStream helpReader = CreateFileStream("Help.txt", FileMode.OpenOrCreate);
//            StreamReader helpText = new StreamReader(helpReader);
//            if (helpReader.Length == 0)
//            {
//                MessageBox.Show(
//                   @"Файл справки отстутсвует в папке с проектом. 
//            Поместите его туда или свяжитесь с разработчиком: zharenkov96@mail.ru");

//                return;
//            }
//            else
//            {
//                helpForm.Text = "Cправка";
//                helpForm.ViewPersonDataRichTextBox.Clear();
//                OpenForm(helpForm);
//                helpForm.ViewPersonDataRichTextBox.Text = helpText.ReadToEnd();
//                helpText.Close();
//                helpReader.Close();
//            }
        }
    }
}