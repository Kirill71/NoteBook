namespace NoteBook.Views
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ViewPersonButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.RichTextBox();
            this.LastCorrectionDateButton = new System.Windows.Forms.Button();
            this.DescendingSortButton = new System.Windows.Forms.Button();
            this.AscendingSortButton = new System.Windows.Forms.Button();
            this.ChangePerson = new System.Windows.Forms.Button();
            this.MainPersonListDataGridView = new System.Windows.Forms.DataGridView();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobilePhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelPersonButton = new System.Windows.Forms.Button();
            this.AddPersonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainPersonListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewPersonButton
            // 
            this.ViewPersonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ViewPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewPersonButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewPersonButton.Image")));
            this.ViewPersonButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ViewPersonButton.Location = new System.Drawing.Point(8, 229);
            this.ViewPersonButton.Name = "ViewPersonButton";
            this.ViewPersonButton.Size = new System.Drawing.Size(69, 74);
            this.ViewPersonButton.TabIndex = 4;
            this.ViewPersonButton.Text = "Просмотр записи";
            this.ViewPersonButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ViewPersonButton.UseVisualStyleBackColor = true;
            this.ViewPersonButton.Click += new System.EventHandler(this.ViewPersonButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(213, 267);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(93, 36);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(83, 233);
            this.SearchTextBox.Multiline = false;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(223, 29);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.Text = "";
            // 
            // LastCorrectionDateButton
            // 
            this.LastCorrectionDateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LastCorrectionDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastCorrectionDateButton.Image = global::NoteBook.Properties.Resources._005;
            this.LastCorrectionDateButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LastCorrectionDateButton.Location = new System.Drawing.Point(312, 233);
            this.LastCorrectionDateButton.Name = "LastCorrectionDateButton";
            this.LastCorrectionDateButton.Size = new System.Drawing.Size(97, 71);
            this.LastCorrectionDateButton.TabIndex = 7;
            this.LastCorrectionDateButton.Text = "Дата изменения";
            this.LastCorrectionDateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LastCorrectionDateButton.UseVisualStyleBackColor = true;
            this.LastCorrectionDateButton.Click += new System.EventHandler(this.LastCorrectionDateButton_Click);
            // 
            // DescendingSortButton
            // 
            this.DescendingSortButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DescendingSortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescendingSortButton.Image = ((System.Drawing.Image)(resources.GetObject("DescendingSortButton.Image")));
            this.DescendingSortButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DescendingSortButton.Location = new System.Drawing.Point(514, 232);
            this.DescendingSortButton.Name = "DescendingSortButton";
            this.DescendingSortButton.Size = new System.Drawing.Size(93, 71);
            this.DescendingSortButton.TabIndex = 9;
            this.DescendingSortButton.Text = "Сортировать от Я->А";
            this.DescendingSortButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DescendingSortButton.UseVisualStyleBackColor = true;
            this.DescendingSortButton.Click += new System.EventHandler(this.DescendingSortButton_Click);
            // 
            // AscendingSortButton
            // 
            this.AscendingSortButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AscendingSortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AscendingSortButton.Image = ((System.Drawing.Image)(resources.GetObject("AscendingSortButton.Image")));
            this.AscendingSortButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AscendingSortButton.Location = new System.Drawing.Point(415, 232);
            this.AscendingSortButton.Name = "AscendingSortButton";
            this.AscendingSortButton.Size = new System.Drawing.Size(93, 71);
            this.AscendingSortButton.TabIndex = 8;
            this.AscendingSortButton.Text = "Сортировать от А -> Я";
            this.AscendingSortButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AscendingSortButton.UseVisualStyleBackColor = true;
            this.AscendingSortButton.Click += new System.EventHandler(this.AscendingSortButton_Click);
            // 
            // ChangePerson
            // 
            this.ChangePerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePerson.Image = ((System.Drawing.Image)(resources.GetObject("ChangePerson.Image")));
            this.ChangePerson.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChangePerson.Location = new System.Drawing.Point(8, 82);
            this.ChangePerson.Name = "ChangePerson";
            this.ChangePerson.Size = new System.Drawing.Size(69, 64);
            this.ChangePerson.TabIndex = 2;
            this.ChangePerson.Text = "Изменить запись";
            this.ChangePerson.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChangePerson.UseVisualStyleBackColor = true;
            this.ChangePerson.Click += new System.EventHandler(this.ChangePerson_Click);
            // 
            // MainPersonListDataGridView
            // 
            this.MainPersonListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainPersonListDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainPersonListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MainPersonListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainPersonListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnameColumn,
            this.NameColumn,
            this.SecondName,
            this.MobilePhoneColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainPersonListDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.MainPersonListDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainPersonListDataGridView.Location = new System.Drawing.Point(83, 12);
            this.MainPersonListDataGridView.Name = "MainPersonListDataGridView";
            this.MainPersonListDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainPersonListDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MainPersonListDataGridView.Size = new System.Drawing.Size(524, 204);
            this.MainPersonListDataGridView.TabIndex = 0;
            this.MainPersonListDataGridView.TabStop = false;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Фамилия";
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // SecondName
            // 
            this.SecondName.HeaderText = "Отчество";
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            // 
            // MobilePhoneColumn
            // 
            this.MobilePhoneColumn.HeaderText = "Мобильный телефон";
            this.MobilePhoneColumn.Name = "MobilePhoneColumn";
            this.MobilePhoneColumn.ReadOnly = true;
            // 
            // DelPersonButton
            // 
            this.DelPersonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DelPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelPersonButton.Image = ((System.Drawing.Image)(resources.GetObject("DelPersonButton.Image")));
            this.DelPersonButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DelPersonButton.Location = new System.Drawing.Point(8, 152);
            this.DelPersonButton.Name = "DelPersonButton";
            this.DelPersonButton.Size = new System.Drawing.Size(69, 64);
            this.DelPersonButton.TabIndex = 3;
            this.DelPersonButton.Text = "Удалить запись";
            this.DelPersonButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DelPersonButton.UseVisualStyleBackColor = true;
            this.DelPersonButton.Click += new System.EventHandler(this.DelPersonButton_Click);
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPersonButton.Image = ((System.Drawing.Image)(resources.GetObject("AddPersonButton.Image")));
            this.AddPersonButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddPersonButton.Location = new System.Drawing.Point(8, 12);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(69, 64);
            this.AddPersonButton.TabIndex = 1;
            this.AddPersonButton.Text = "Добавить запись";
            this.AddPersonButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(613, 309);
            this.Controls.Add(this.MainPersonListDataGridView);
            this.Controls.Add(this.DescendingSortButton);
            this.Controls.Add(this.LastCorrectionDateButton);
            this.Controls.Add(this.AscendingSortButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ViewPersonButton);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.ChangePerson);
            this.Controls.Add(this.DelPersonButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Записная книжка";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainWindow_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.MainPersonListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button AddPersonButton;
        public System.Windows.Forms.Button ChangePerson;
        public System.Windows.Forms.Button DelPersonButton;
        public System.Windows.Forms.DataGridView MainPersonListDataGridView;
        public System.Windows.Forms.Button SearchButton;
        public System.Windows.Forms.RichTextBox SearchTextBox;
        public System.Windows.Forms.Button LastCorrectionDateButton;
        public System.Windows.Forms.Button DescendingSortButton;
        public System.Windows.Forms.Button AscendingSortButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobilePhoneColumn;
        public System.Windows.Forms.Button ViewPersonButton;
    }
}

