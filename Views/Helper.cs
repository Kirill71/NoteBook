using System;
using System.Windows.Forms;
using System.IO;

namespace NoteBook.Views
{
    public partial class Helper : Form
    {
        object obj;
        public Helper()
        {
            obj = null;
            InitializeComponent();
        }

        private void Helper_Load(object sender, EventArgs e)
        {
            object obj = NoteBook.Properties.Resources._0;
            ViewReference(obj);
        }

        private void ViewReference(object obj)
        {
            richTextBox_Rtf.Rtf = obj.ToString();
        }

        private void treeView_Reference_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            switch (treeView_Reference.SelectedNode.Text)
            {
                case "Главное окно программы":         { obj = NoteBook.Properties.Resources._0; break; }
                case "Добавление нового контакта":     { obj = NoteBook.Properties.Resources._1; break; }
                case "Изменение  контакта":            { obj = NoteBook.Properties.Resources._2; break; }
                case "Удаление контакта":              { obj = NoteBook.Properties.Resources._3; break; }
                case "Просмотр иформации о контакте":  { obj = NoteBook.Properties.Resources._4; break; }
                case "Поиск":                          { obj = NoteBook.Properties.Resources._5; break; }
                case "По алфавиту":                    { obj = NoteBook.Properties.Resources._6; break; }
                case "Против алфавита":                { obj = NoteBook.Properties.Resources._7; break; }
                case "По дате изменения":              { obj = NoteBook.Properties.Resources._8; break; }
            }
            ViewReference(obj);
        }
    }
}
