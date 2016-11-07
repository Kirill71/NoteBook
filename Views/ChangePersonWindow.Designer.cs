namespace NoteBook.Views
{
    partial class ChangePerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePerson));
            this.ChangePersonButton = new System.Windows.Forms.Button();
            this.RelationsTypeGroupBox.SuspendLayout();
            this.WorkPlaceGroupBox.SuspendLayout();
            this.BusinessQualitiesGroupBox.SuspendLayout();
            this.StudyPlaceGroupBox.SuspendLayout();
            this.PhoneGroupBox.SuspendLayout();
            this.PersonalDataGroupBox.SuspendLayout();
            this.AdresGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangePersonButton
            // 
            this.ChangePersonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangePersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePersonButton.Location = new System.Drawing.Point(606, 210);
            this.ChangePersonButton.Name = "ChangePersonButton";
            this.ChangePersonButton.Size = new System.Drawing.Size(88, 44);
            this.ChangePersonButton.TabIndex = 8;
            this.ChangePersonButton.Text = "Изменить";
            this.ChangePersonButton.UseVisualStyleBackColor = true;
            this.ChangePersonButton.Click += new System.EventHandler(this.ChangePersonButton_Click);
            // 
            // ChangePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(694, 255);
            this.Controls.Add(this.ChangePersonButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePerson";
            this.Text = "Изменение данных";
            this.Load += new System.EventHandler(this.ChangePerson_Load);
            this.Controls.SetChildIndex(this.RelationsTypeGroupBox, 0);
            this.Controls.SetChildIndex(this.WorkPlaceGroupBox, 0);
            this.Controls.SetChildIndex(this.AdresGroupBox, 0);
            this.Controls.SetChildIndex(this.PersonalDataGroupBox, 0);
            this.Controls.SetChildIndex(this.PhoneGroupBox, 0);
            this.Controls.SetChildIndex(this.StudyPlaceGroupBox, 0);
            this.Controls.SetChildIndex(this.BusinessQualitiesGroupBox, 0);
            this.Controls.SetChildIndex(this.ChangePersonButton, 0);
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

        private System.Windows.Forms.Button ChangePersonButton;
    }
}
