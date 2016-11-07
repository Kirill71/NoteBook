namespace NoteBook.Views
{
    partial class ViewPersonWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPersonWindow));
            this.ViewPersonDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ViewPersonDataRichTextBox
            // 
            this.ViewPersonDataRichTextBox.Location = new System.Drawing.Point(3, 12);
            this.ViewPersonDataRichTextBox.Name = "ViewPersonDataRichTextBox";
            this.ViewPersonDataRichTextBox.Size = new System.Drawing.Size(423, 325);
            this.ViewPersonDataRichTextBox.TabIndex = 1;
            this.ViewPersonDataRichTextBox.Text = "";
            // 
            // ViewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(438, 349);
            this.Controls.Add(this.ViewPersonDataRichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewPerson";
            this.Text = "Просмотр данных";
            this.Load += new System.EventHandler(this.ViewPerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox ViewPersonDataRichTextBox;
    }
}