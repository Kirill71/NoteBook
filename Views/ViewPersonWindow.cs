// ViewPersonWindow  - класс, представляющий форму просмотра контакта.

using System;
using System.Drawing;
using System.Windows.Forms;

using NoteBook.Presenters;
namespace NoteBook.Views
{
    public partial class ViewPersonWindow : Form
    {
        public ViewPersonWindow()
        {
            viewData = null;
            InitializeComponent();
            new ViewPersonPresenter(this);
        }

        private void ViewPerson_Load(object sender, EventArgs e)
        {
            viewData(sender, e);
        }

        private EventHandler viewData;

        public event EventHandler ViewData
        {
            add { viewData += value; }
            remove { viewData -= value; }
        }
    }
}
