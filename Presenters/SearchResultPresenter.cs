// SearchResultPresenter - класс, отвечающий за взаимодействие между формой поиска и коллекцией. 

using System;
using System.Windows.Forms;
using System.Collections;
using NoteBook.Model;
using NoteBook.Views;

namespace NoteBook.Presenters
{
    class SearchResultPresenter : Presenter
    {
        private NoteBookList searchResultList;
        private SearchResultWindow searchForm;

        public SearchResultPresenter(SearchResultWindow _window)
            : base()
        {
            flag = true;
            this.searchForm = _window;
            searchResultList = new NoteBookList();
            this.searchForm.LoadSearchResult += LoadSearchList;
            this.searchForm.ViewSearchResult += ViewSearchPerson;
        }

        // Просмотр информации о найденном контакте.
        void ViewSearchPerson(object sender, EventArgs e)
        {
            ViewPersonWindow viewSearchPerson = new ViewPersonWindow();
            try
            {
                OpenForm(viewSearchPerson);

                PersonToDataGridView(searchResultList, viewSearchPerson, searchForm.SearchResaltListDataGridView);
            }
            catch (Exception)
            {
                return;
            }
        }

        // Загрузка найденых контактов в список.
        void LoadSearchList(object sender, EventArgs e)
        {
            string searchString = window.SearchTextBox.Text;
            if (searchString.Contains("0"))
            {
                foreach (Person item in noteBook)
                {
                    if (item.Numbers.MobilePhone.Substring(0).Contains(searchString))
                    {
                        searchResultList.AddPerson(item);
                    }
                }
            }
            else
            {
                foreach (Person item in noteBook)
                {
                    if (Convert.ToBoolean(item.Data.Surname.Contains(searchString[0].ToString().ToUpper())))
                    {
                        searchResultList.AddPerson(item);
                    }
                }
            }
            LoadMainList(searchResultList, searchForm.SearchResaltListDataGridView);
        }
    }
}