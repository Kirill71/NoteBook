// SearchResultWindow  - класс, представляющий форму поиска.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NoteBook.Presenters;

namespace NoteBook.Views
{
    public partial class SearchResultWindow : Form
    {
        public SearchResultWindow()
        {
            loadSearchResult = null;
            viewSearchResult = null;
            InitializeComponent();
            new SearchResultPresenter(this);
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {
            loadSearchResult(sender, e);
        }

        private void ViewSearchResultButton_Click(object sender, EventArgs e)
        {
            viewSearchResult(sender, e);
        }

        #region Делегаты
        private EventHandler loadSearchResult;
        private EventHandler viewSearchResult;
        #endregion

        #region События

        public event EventHandler LoadSearchResult
        {
            add { loadSearchResult += value; }
            remove { loadSearchResult -= value; }
        }

        public event EventHandler ViewSearchResult
        {
            add { viewSearchResult += value; }
            remove { viewSearchResult -= value; }
        }

        #endregion
 
    }
}
