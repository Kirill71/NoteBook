// MainWindow  - класс, представляющий главную форму программы.

using System;
using System.Drawing;
using System.Windows.Forms;
using NoteBook.Presenters;

namespace NoteBook.Views
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            #region Инициализация делегатов.
            loadMainWindow = null;
            add = null;
            change = null;
            delete = null;
            ascSort = null;
            descSort = null;
            dateSort = null;
            view = null;
            search = null;
            birthDayCelebration = null;
            helpRequest = null;
            #endregion

            InitializeComponent();
            new MainWindowPresenter(this);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            loadMainWindow(sender, e);
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            add(sender, e);
        }

        private void ChangePerson_Click(object sender, EventArgs e)
        {
            change(sender, e);
        }

        private void DelPersonButton_Click(object sender, EventArgs e)
        {
            delete(sender, e);
        }

        private void AscendingSortButton_Click(object sender, EventArgs e)
        {
            ascSort(sender, e);
        }

        private void DescendingSortButton_Click(object sender, EventArgs e)
        {
            descSort(sender, e);
        }

        private void LastCorrectionDateButton_Click(object sender, EventArgs e)
        {
            dateSort(sender, e);
        }

        private void ViewPersonButton_Click(object sender, EventArgs e)
        {
            view(sender, e);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            search(sender, e);
        }

        private void MainWindow_HelpRequested(object sender, EventArgs e)
        {
            helpRequest(sender, e);
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            birthDayCelebration(sender, e);
        }

        #region Делегаты.

        private EventHandler add;
        private EventHandler change;
        private EventHandler delete;
        private EventHandler ascSort;
        private EventHandler descSort;
        private EventHandler dateSort;
        private EventHandler loadMainWindow;
        private EventHandler view;
        private EventHandler search;
        private EventHandler birthDayCelebration;
        private EventHandler helpRequest;

        #endregion

        #region События.

        public event EventHandler LoadMainWindow
        {
            add { loadMainWindow += value; }
            remove { loadMainWindow -= value; }
        }

        public event EventHandler Add
        {
            add { add += value; }
            remove { add -= value; }
        }

        public event EventHandler Change
        {
            add { change += value; }
            remove { change -= value; }
        }

        public event EventHandler Delete
        {
            add { delete += value; }
            remove { delete -= value; }
        }

        public event EventHandler View
        {
            add { view += value; }
            remove { view -= value; }
        }

        public event EventHandler AscSort
        {
            add { ascSort += value; }
            remove { ascSort -= value; }
        }

        public event EventHandler DescSort
        {
            add { descSort += value; }
            remove { descSort -= value; }
        }
        public event EventHandler DateSort
        {
            add { dateSort += value; }
            remove { dateSort -= value; }
        }
        public event EventHandler Search
        {
            add { search += value; }
            remove { dateSort -= value; }
        }

        public event EventHandler CelebrateBirthDay
        {
            add { birthDayCelebration += value; }
            remove { birthDayCelebration -= value; }
        }

        public event EventHandler HelpRequest
        {
            add { helpRequest += value; }
            remove { helpRequest -= value; }
        }
        #endregion

    }
}
