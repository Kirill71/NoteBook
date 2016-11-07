namespace NoteBook.Views
{
    partial class Helper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Главное окно программы");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Добавление нового контакта");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Изменение  контакта");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Удаление контакта");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Просмотр иформации о контакте");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Поиск");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("По алфавиту");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Против алфавита");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("По дате изменения");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Сортировка", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Helper));
            this.treeView_Reference = new System.Windows.Forms.TreeView();
            this.richTextBox_Rtf = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeView_Reference
            // 
            this.treeView_Reference.Location = new System.Drawing.Point(12, 12);
            this.treeView_Reference.Name = "treeView_Reference";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Главное окно программы";
            treeNode2.Name = "Узел1";
            treeNode2.Text = "Добавление нового контакта";
            treeNode3.Name = "Узел2";
            treeNode3.Text = "Изменение  контакта";
            treeNode4.Name = "Узел3";
            treeNode4.Text = "Удаление контакта";
            treeNode5.Name = "Узел9";
            treeNode5.Text = "Просмотр иформации о контакте";
            treeNode6.Name = "Узел1";
            treeNode6.Text = "Поиск";
            treeNode7.Name = "Узел3";
            treeNode7.Text = "По алфавиту";
            treeNode8.Name = "Узел4";
            treeNode8.Text = "Против алфавита";
            treeNode9.Name = "Узел5";
            treeNode9.Text = "По дате изменения";
            treeNode10.Name = "Узел2";
            treeNode10.Text = "Сортировка";
            this.treeView_Reference.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode10});
            this.treeView_Reference.PathSeparator = "";
            this.treeView_Reference.Size = new System.Drawing.Size(201, 344);
            this.treeView_Reference.TabIndex = 0;
            this.treeView_Reference.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Reference_AfterSelect);
            // 
            // richTextBox_Rtf
            // 
            this.richTextBox_Rtf.BackColor = System.Drawing.Color.White;
            this.richTextBox_Rtf.Location = new System.Drawing.Point(237, 12);
            this.richTextBox_Rtf.Name = "richTextBox_Rtf";
            this.richTextBox_Rtf.ReadOnly = true;
            this.richTextBox_Rtf.Size = new System.Drawing.Size(510, 344);
            this.richTextBox_Rtf.TabIndex = 1;
            this.richTextBox_Rtf.Text = "";
            // 
            // Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(751, 368);
            this.Controls.Add(this.richTextBox_Rtf);
            this.Controls.Add(this.treeView_Reference);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Helper";
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.Helper_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_Reference;
        private System.Windows.Forms.RichTextBox richTextBox_Rtf;
    }
}