namespace NoteBook.Views
{
    partial class AddPersonWindow
    {
        /// <summary>
        ///Требуется переменная конструктора.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPersonWindow));
            this.SavePersonButton = new System.Windows.Forms.Button();
            this.RelationsTypeGroupBox.SuspendLayout();
            this.WorkPlaceGroupBox.SuspendLayout();
            this.BusinessQualitiesGroupBox.SuspendLayout();
            this.StudyPlaceGroupBox.SuspendLayout();
            this.PhoneGroupBox.SuspendLayout();
            this.PersonalDataGroupBox.SuspendLayout();
            this.AdresGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RelationsTypeCheckedListBox
            // 
            this.RelationsTypeCheckedListBox.TabIndex = 5;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.TabIndex = 6;
            // 
            // SavePersonButton
            // 
            this.SavePersonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SavePersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePersonButton.Location = new System.Drawing.Point(607, 211);
            this.SavePersonButton.Name = "SavePersonButton";
            this.SavePersonButton.Size = new System.Drawing.Size(87, 43);
            this.SavePersonButton.TabIndex = 8;
            this.SavePersonButton.Text = "Cохранить";
            this.SavePersonButton.UseVisualStyleBackColor = true;
            this.SavePersonButton.Click += new System.EventHandler(this.SavePersonButton_Click);
            // 
            // AddPersonWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(694, 255);
            this.Controls.Add(this.SavePersonButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPersonWindow";
            this.Text = "Добавление данных";
            this.Controls.SetChildIndex(this.RelationsTypeGroupBox, 0);
            this.Controls.SetChildIndex(this.WorkPlaceGroupBox, 0);
            this.Controls.SetChildIndex(this.AdresGroupBox, 0);
            this.Controls.SetChildIndex(this.PersonalDataGroupBox, 0);
            this.Controls.SetChildIndex(this.PhoneGroupBox, 0);
            this.Controls.SetChildIndex(this.StudyPlaceGroupBox, 0);
            this.Controls.SetChildIndex(this.BusinessQualitiesGroupBox, 0);
            this.Controls.SetChildIndex(this.SavePersonButton, 0);
            this.RelationsTypeGroupBox.ResumeLayout(false);
            this.WorkPlaceGroupBox.ResumeLayout(false);
            this.WorkPlaceGroupBox.PerformLayout();
            this.BusinessQualitiesGroupBox.ResumeLayout(false);
            this.BusinessQualitiesGroupBox.PerformLayout();
            this.StudyPlaceGroupBox.ResumeLayout(false);
            this.StudyPlaceGroupBox.PerformLayout();
            this.PhoneGroupBox.ResumeLayout(false);
            this.PhoneGroupBox.PerformLayout();
            this.PersonalDataGroupBox.ResumeLayout(false);
            this.PersonalDataGroupBox.PerformLayout();
            this.AdresGroupBox.ResumeLayout(false);
            this.AdresGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SavePersonButton;
    }
}
