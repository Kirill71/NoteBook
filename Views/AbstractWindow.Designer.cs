namespace NoteBook.Views
{
    partial class AbstractWindow
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
            this.BusinessQualitiesTextBox = new System.Windows.Forms.TextBox();
            this.RelationsTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.RelationsTypeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.WorkFunctionLabel = new System.Windows.Forms.Label();
            this.WorkPlaceFunctionTextBox = new System.Windows.Forms.TextBox();
            this.WorkPlaceNametextBox = new System.Windows.Forms.TextBox();
            this.WorkPlaceNameLabel = new System.Windows.Forms.Label();
            this.WorkPlaceGroupBox = new System.Windows.Forms.GroupBox();
            this.CollageFinishYearComboBox = new System.Windows.Forms.ComboBox();
            this.CollegeNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BusinessQualitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.StudyPlaceGroupBox = new System.Windows.Forms.GroupBox();
            this.MobilePhoneTextBox = new System.Windows.Forms.TextBox();
            this.MobilePhoneLabel = new System.Windows.Forms.Label();
            this.AltPhoneLabel = new System.Windows.Forms.Label();
            this.AltPhoneTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BirthDayNumberComboBox = new System.Windows.Forms.ComboBox();
            this.BirsthDayYearComboBox = new System.Windows.Forms.ComboBox();
            this.BirthDayGroupBox = new System.Windows.Forms.GroupBox();
            this.BirthDayMonthComboBox = new System.Windows.Forms.ComboBox();
            this.PhoneGroupBox = new System.Windows.Forms.GroupBox();
            this.PersonalDataGroupBox = new System.Windows.Forms.GroupBox();
            this.AdresGroupBox = new System.Windows.Forms.GroupBox();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.RelationsTypeGroupBox.SuspendLayout();
            this.WorkPlaceGroupBox.SuspendLayout();
            this.BusinessQualitiesGroupBox.SuspendLayout();
            this.StudyPlaceGroupBox.SuspendLayout();
            this.BirthDayGroupBox.SuspendLayout();
            this.PhoneGroupBox.SuspendLayout();
            this.PersonalDataGroupBox.SuspendLayout();
            this.AdresGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BusinessQualitiesTextBox
            // 
            this.BusinessQualitiesTextBox.Location = new System.Drawing.Point(6, 16);
            this.BusinessQualitiesTextBox.Multiline = true;
            this.BusinessQualitiesTextBox.Name = "BusinessQualitiesTextBox";
            this.BusinessQualitiesTextBox.Size = new System.Drawing.Size(225, 82);
            this.BusinessQualitiesTextBox.TabIndex = 6;
            // 
            // RelationsTypeGroupBox
            // 
            this.RelationsTypeGroupBox.Controls.Add(this.RelationsTypeCheckedListBox);
            this.RelationsTypeGroupBox.Location = new System.Drawing.Point(552, 0);
            this.RelationsTypeGroupBox.Name = "RelationsTypeGroupBox";
            this.RelationsTypeGroupBox.Size = new System.Drawing.Size(142, 109);
            this.RelationsTypeGroupBox.TabIndex = 17;
            this.RelationsTypeGroupBox.TabStop = false;
            this.RelationsTypeGroupBox.Text = "Характер знакомства";
            // 
            // RelationsTypeCheckedListBox
            // 
            this.RelationsTypeCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RelationsTypeCheckedListBox.FormattingEnabled = true;
            this.RelationsTypeCheckedListBox.Items.AddRange(new object[] {
            "Друзья",
            "Коллеги",
            "Родственники",
            "Другое"});
            this.RelationsTypeCheckedListBox.Location = new System.Drawing.Point(0, 28);
            this.RelationsTypeCheckedListBox.Name = "RelationsTypeCheckedListBox";
            this.RelationsTypeCheckedListBox.Size = new System.Drawing.Size(142, 64);
            this.RelationsTypeCheckedListBox.TabIndex = 12;
            // 
            // WorkFunctionLabel
            // 
            this.WorkFunctionLabel.AutoSize = true;
            this.WorkFunctionLabel.Location = new System.Drawing.Point(6, 55);
            this.WorkFunctionLabel.Name = "WorkFunctionLabel";
            this.WorkFunctionLabel.Size = new System.Drawing.Size(68, 13);
            this.WorkFunctionLabel.TabIndex = 5;
            this.WorkFunctionLabel.Text = " Должность";
            // 
            // WorkPlaceFunctionTextBox
            // 
            this.WorkPlaceFunctionTextBox.Location = new System.Drawing.Point(7, 71);
            this.WorkPlaceFunctionTextBox.Name = "WorkPlaceFunctionTextBox";
            this.WorkPlaceFunctionTextBox.Size = new System.Drawing.Size(208, 20);
            this.WorkPlaceFunctionTextBox.TabIndex = 4;
            // 
            // WorkPlaceNametextBox
            // 
            this.WorkPlaceNametextBox.Location = new System.Drawing.Point(6, 32);
            this.WorkPlaceNametextBox.Name = "WorkPlaceNametextBox";
            this.WorkPlaceNametextBox.Size = new System.Drawing.Size(209, 20);
            this.WorkPlaceNametextBox.TabIndex = 3;
            // 
            // WorkPlaceNameLabel
            // 
            this.WorkPlaceNameLabel.AutoSize = true;
            this.WorkPlaceNameLabel.Location = new System.Drawing.Point(6, 16);
            this.WorkPlaceNameLabel.Name = "WorkPlaceNameLabel";
            this.WorkPlaceNameLabel.Size = new System.Drawing.Size(131, 13);
            this.WorkPlaceNameLabel.TabIndex = 2;
            this.WorkPlaceNameLabel.Text = "Название места работы";
            // 
            // WorkPlaceGroupBox
            // 
            this.WorkPlaceGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WorkPlaceGroupBox.Controls.Add(this.WorkFunctionLabel);
            this.WorkPlaceGroupBox.Controls.Add(this.WorkPlaceNametextBox);
            this.WorkPlaceGroupBox.Controls.Add(this.WorkPlaceNameLabel);
            this.WorkPlaceGroupBox.Controls.Add(this.WorkPlaceFunctionTextBox);
            this.WorkPlaceGroupBox.Location = new System.Drawing.Point(331, 0);
            this.WorkPlaceGroupBox.Name = "WorkPlaceGroupBox";
            this.WorkPlaceGroupBox.Size = new System.Drawing.Size(222, 106);
            this.WorkPlaceGroupBox.TabIndex = 16;
            this.WorkPlaceGroupBox.TabStop = false;
            this.WorkPlaceGroupBox.Text = "Место работы";
            // 
            // CollageFinishYearComboBox
            // 
            this.CollageFinishYearComboBox.FormattingEnabled = true;
            this.CollageFinishYearComboBox.Items.AddRange(new object[] {
            "2040",
            "2039",
            "2038",
            "2037",
            "2036",
            "2035",
            "2034",
            "2033",
            "2032",
            "2031",
            "2030",
            "2029",
            "2028",
            "2027",
            "2026",
            "2025",
            "2024",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940"});
            this.CollageFinishYearComboBox.Location = new System.Drawing.Point(6, 59);
            this.CollageFinishYearComboBox.Name = "CollageFinishYearComboBox";
            this.CollageFinishYearComboBox.Size = new System.Drawing.Size(100, 21);
            this.CollageFinishYearComboBox.TabIndex = 1;
            this.CollageFinishYearComboBox.Text = "Год окончания";
            // 
            // CollegeNameTextBox
            // 
            this.CollegeNameTextBox.Location = new System.Drawing.Point(6, 32);
            this.CollegeNameTextBox.Name = "CollegeNameTextBox";
            this.CollegeNameTextBox.Size = new System.Drawing.Size(209, 20);
            this.CollegeNameTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Название учебного заведения";
            // 
            // BusinessQualitiesGroupBox
            // 
            this.BusinessQualitiesGroupBox.Controls.Add(this.BusinessQualitiesTextBox);
            this.BusinessQualitiesGroupBox.Location = new System.Drawing.Point(227, 98);
            this.BusinessQualitiesGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.BusinessQualitiesGroupBox.Name = "BusinessQualitiesGroupBox";
            this.BusinessQualitiesGroupBox.Size = new System.Drawing.Size(242, 109);
            this.BusinessQualitiesGroupBox.TabIndex = 18;
            this.BusinessQualitiesGroupBox.TabStop = false;
            this.BusinessQualitiesGroupBox.Text = "Деловые качества";
            // 
            // StudyPlaceGroupBox
            // 
            this.StudyPlaceGroupBox.Controls.Add(this.CollageFinishYearComboBox);
            this.StudyPlaceGroupBox.Controls.Add(this.CollegeNameTextBox);
            this.StudyPlaceGroupBox.Controls.Add(this.label5);
            this.StudyPlaceGroupBox.Location = new System.Drawing.Point(0, 160);
            this.StudyPlaceGroupBox.Name = "StudyPlaceGroupBox";
            this.StudyPlaceGroupBox.Size = new System.Drawing.Size(228, 94);
            this.StudyPlaceGroupBox.TabIndex = 15;
            this.StudyPlaceGroupBox.TabStop = false;
            this.StudyPlaceGroupBox.Text = "Место учёбы";
            // 
            // MobilePhoneTextBox
            // 
            this.MobilePhoneTextBox.Location = new System.Drawing.Point(6, 32);
            this.MobilePhoneTextBox.Name = "MobilePhoneTextBox";
            this.MobilePhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.MobilePhoneTextBox.TabIndex = 0;
            this.MobilePhoneTextBox.TextChanged += new System.EventHandler(this.MobilePhoneTextBox_TextChanged);
            // 
            // MobilePhoneLabel
            // 
            this.MobilePhoneLabel.AutoSize = true;
            this.MobilePhoneLabel.Location = new System.Drawing.Point(6, 16);
            this.MobilePhoneLabel.Name = "MobilePhoneLabel";
            this.MobilePhoneLabel.Size = new System.Drawing.Size(66, 13);
            this.MobilePhoneLabel.TabIndex = 2;
            this.MobilePhoneLabel.Text = "Мобильный";
            // 
            // AltPhoneLabel
            // 
            this.AltPhoneLabel.AutoSize = true;
            this.AltPhoneLabel.Location = new System.Drawing.Point(112, 16);
            this.AltPhoneLabel.Name = "AltPhoneLabel";
            this.AltPhoneLabel.Size = new System.Drawing.Size(62, 13);
            this.AltPhoneLabel.TabIndex = 1;
            this.AltPhoneLabel.Text = "Домашний";
            // 
            // AltPhoneTextBox
            // 
            this.AltPhoneTextBox.Location = new System.Drawing.Point(112, 32);
            this.AltPhoneTextBox.Name = "AltPhoneTextBox";
            this.AltPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.AltPhoneTextBox.TabIndex = 1;
            this.AltPhoneTextBox.TextChanged += new System.EventHandler(this.AltPhoneTextBox_TextChanged);
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(221, 32);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondNameTextBox.TabIndex = 2;
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Location = new System.Drawing.Point(218, 16);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(54, 13);
            this.SecondNameLabel.TabIndex = 4;
            this.SecondNameLabel.Text = "Отчество";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(6, 32);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameTextBox.TabIndex = 0;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(6, 16);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(112, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Имя";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(115, 32);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // BirthDayNumberComboBox
            // 
            this.BirthDayNumberComboBox.FormattingEnabled = true;
            this.BirthDayNumberComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.BirthDayNumberComboBox.Location = new System.Drawing.Point(6, 15);
            this.BirthDayNumberComboBox.Name = "BirthDayNumberComboBox";
            this.BirthDayNumberComboBox.Size = new System.Drawing.Size(100, 21);
            this.BirthDayNumberComboBox.TabIndex = 0;
            this.BirthDayNumberComboBox.Text = "Число";
            // 
            // BirsthDayYearComboBox
            // 
            this.BirsthDayYearComboBox.FormattingEnabled = true;
            this.BirsthDayYearComboBox.Items.AddRange(new object[] {
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915"});
            this.BirsthDayYearComboBox.Location = new System.Drawing.Point(221, 16);
            this.BirsthDayYearComboBox.Name = "BirsthDayYearComboBox";
            this.BirsthDayYearComboBox.Size = new System.Drawing.Size(100, 21);
            this.BirsthDayYearComboBox.TabIndex = 2;
            this.BirsthDayYearComboBox.Text = "Год";
            // 
            // BirthDayGroupBox
            // 
            this.BirthDayGroupBox.Controls.Add(this.BirsthDayYearComboBox);
            this.BirthDayGroupBox.Controls.Add(this.BirthDayMonthComboBox);
            this.BirthDayGroupBox.Controls.Add(this.BirthDayNumberComboBox);
            this.BirthDayGroupBox.Location = new System.Drawing.Point(0, 55);
            this.BirthDayGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.BirthDayGroupBox.Name = "BirthDayGroupBox";
            this.BirthDayGroupBox.Size = new System.Drawing.Size(326, 54);
            this.BirthDayGroupBox.TabIndex = 8;
            this.BirthDayGroupBox.TabStop = false;
            this.BirthDayGroupBox.Text = "Дата рождения";
            // 
            // BirthDayMonthComboBox
            // 
            this.BirthDayMonthComboBox.FormattingEnabled = true;
            this.BirthDayMonthComboBox.Items.AddRange(new object[] {
            "Января",
            "Февраля",
            "Марта",
            "Апреля",
            "Мая",
            "Июня",
            "Июля",
            "Августа",
            "Сентября",
            "Октября",
            "Ноября",
            "Декабря"});
            this.BirthDayMonthComboBox.Location = new System.Drawing.Point(112, 16);
            this.BirthDayMonthComboBox.Name = "BirthDayMonthComboBox";
            this.BirthDayMonthComboBox.Size = new System.Drawing.Size(100, 21);
            this.BirthDayMonthComboBox.TabIndex = 1;
            this.BirthDayMonthComboBox.Text = "Месяц";
            // 
            // PhoneGroupBox
            // 
            this.PhoneGroupBox.Controls.Add(this.MobilePhoneTextBox);
            this.PhoneGroupBox.Controls.Add(this.MobilePhoneLabel);
            this.PhoneGroupBox.Controls.Add(this.AltPhoneLabel);
            this.PhoneGroupBox.Controls.Add(this.AltPhoneTextBox);
            this.PhoneGroupBox.Location = new System.Drawing.Point(6, 98);
            this.PhoneGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.PhoneGroupBox.Name = "PhoneGroupBox";
            this.PhoneGroupBox.Size = new System.Drawing.Size(222, 69);
            this.PhoneGroupBox.TabIndex = 14;
            this.PhoneGroupBox.TabStop = false;
            this.PhoneGroupBox.Text = "Телефоны";
            // 
            // PersonalDataGroupBox
            // 
            this.PersonalDataGroupBox.Controls.Add(this.BirthDayGroupBox);
            this.PersonalDataGroupBox.Controls.Add(this.SecondNameTextBox);
            this.PersonalDataGroupBox.Controls.Add(this.SecondNameLabel);
            this.PersonalDataGroupBox.Controls.Add(this.SurnameTextBox);
            this.PersonalDataGroupBox.Controls.Add(this.SurnameLabel);
            this.PersonalDataGroupBox.Controls.Add(this.NameLabel);
            this.PersonalDataGroupBox.Controls.Add(this.NameTextBox);
            this.PersonalDataGroupBox.Location = new System.Drawing.Point(6, 0);
            this.PersonalDataGroupBox.Name = "PersonalDataGroupBox";
            this.PersonalDataGroupBox.Size = new System.Drawing.Size(326, 109);
            this.PersonalDataGroupBox.TabIndex = 13;
            this.PersonalDataGroupBox.TabStop = false;
            this.PersonalDataGroupBox.Text = "Персональные данные";
            // 
            // AdresGroupBox
            // 
            this.AdresGroupBox.Controls.Add(this.AdressTextBox);
            this.AdresGroupBox.Location = new System.Drawing.Point(465, 98);
            this.AdresGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.AdresGroupBox.Name = "AdresGroupBox";
            this.AdresGroupBox.Size = new System.Drawing.Size(229, 109);
            this.AdresGroupBox.TabIndex = 20;
            this.AdresGroupBox.TabStop = false;
            this.AdresGroupBox.Text = "Адресс";
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(6, 19);
            this.AdressTextBox.Multiline = true;
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(218, 79);
            this.AdressTextBox.TabIndex = 7;
            // 
            // AbstractWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(694, 255);
            this.Controls.Add(this.AdresGroupBox);
            this.Controls.Add(this.BusinessQualitiesGroupBox);
            this.Controls.Add(this.RelationsTypeGroupBox);
            this.Controls.Add(this.StudyPlaceGroupBox);
            this.Controls.Add(this.PhoneGroupBox);
            this.Controls.Add(this.PersonalDataGroupBox);
            this.Controls.Add(this.WorkPlaceGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AbstractWindow";
            this.Text = "AbstractForm";
            this.RelationsTypeGroupBox.ResumeLayout(false);
            this.WorkPlaceGroupBox.ResumeLayout(false);
            this.WorkPlaceGroupBox.PerformLayout();
            this.BusinessQualitiesGroupBox.ResumeLayout(false);
            this.BusinessQualitiesGroupBox.PerformLayout();
            this.StudyPlaceGroupBox.ResumeLayout(false);
            this.StudyPlaceGroupBox.PerformLayout();
            this.BirthDayGroupBox.ResumeLayout(false);
            this.PhoneGroupBox.ResumeLayout(false);
            this.PhoneGroupBox.PerformLayout();
            this.PersonalDataGroupBox.ResumeLayout(false);
            this.PersonalDataGroupBox.PerformLayout();
            this.AdresGroupBox.ResumeLayout(false);
            this.AdresGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox BusinessQualitiesTextBox;
        public System.Windows.Forms.GroupBox RelationsTypeGroupBox;
        public System.Windows.Forms.CheckedListBox RelationsTypeCheckedListBox;
        private System.Windows.Forms.Label WorkFunctionLabel;
        public System.Windows.Forms.TextBox WorkPlaceFunctionTextBox;
        public System.Windows.Forms.TextBox WorkPlaceNametextBox;
        private System.Windows.Forms.Label WorkPlaceNameLabel;
        public System.Windows.Forms.GroupBox WorkPlaceGroupBox;
        public System.Windows.Forms.ComboBox CollageFinishYearComboBox;
        public System.Windows.Forms.TextBox CollegeNameTextBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.GroupBox BusinessQualitiesGroupBox;
        public System.Windows.Forms.GroupBox StudyPlaceGroupBox;
        public System.Windows.Forms.TextBox MobilePhoneTextBox;
        private System.Windows.Forms.Label MobilePhoneLabel;
        private System.Windows.Forms.Label AltPhoneLabel;
        public System.Windows.Forms.TextBox AltPhoneTextBox;
        public System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.Label SecondNameLabel;
        public System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.ComboBox BirthDayNumberComboBox;
        public System.Windows.Forms.ComboBox BirsthDayYearComboBox;
        private System.Windows.Forms.GroupBox BirthDayGroupBox;
        public System.Windows.Forms.ComboBox BirthDayMonthComboBox;
        public System.Windows.Forms.GroupBox PhoneGroupBox;
        public System.Windows.Forms.GroupBox PersonalDataGroupBox;
        public System.Windows.Forms.GroupBox AdresGroupBox;
        public System.Windows.Forms.TextBox AdressTextBox;

    }
}