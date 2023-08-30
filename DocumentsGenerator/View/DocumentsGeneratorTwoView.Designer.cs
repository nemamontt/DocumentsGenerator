namespace DocumentsGenerator.View
{
    partial class DocumentsGeneratorTwoView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentsGeneratorTwoView));
            MainTableLayoutPanel = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            GoBackButton = new Button();
            ReadeButton = new Button();
            FioAuthorsTextBox = new TextBox();
            DateOfBirthAuthorsTextBox = new TextBox();
            LocationAuthorsTextBox = new TextBox();
            CreativeInputAuthorsTextBox = new TextBox();
            SeparatorButton = new Button();
            PassportDetailsLabel = new Label();
            PassportDetailsTextBox = new TextBox();
            label1 = new Label();
            FocusTimer = new System.Windows.Forms.Timer(components);
            DetectPressTimer = new System.Windows.Forms.Timer(components);
            MainTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 2;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            MainTableLayoutPanel.Controls.Add(label2, 0, 1);
            MainTableLayoutPanel.Controls.Add(label3, 0, 2);
            MainTableLayoutPanel.Controls.Add(label4, 0, 4);
            MainTableLayoutPanel.Controls.Add(GoBackButton, 0, 6);
            MainTableLayoutPanel.Controls.Add(ReadeButton, 1, 6);
            MainTableLayoutPanel.Controls.Add(FioAuthorsTextBox, 1, 0);
            MainTableLayoutPanel.Controls.Add(DateOfBirthAuthorsTextBox, 1, 1);
            MainTableLayoutPanel.Controls.Add(LocationAuthorsTextBox, 1, 2);
            MainTableLayoutPanel.Controls.Add(CreativeInputAuthorsTextBox, 1, 4);
            MainTableLayoutPanel.Controls.Add(SeparatorButton, 1, 5);
            MainTableLayoutPanel.Controls.Add(PassportDetailsLabel, 0, 3);
            MainTableLayoutPanel.Controls.Add(PassportDetailsTextBox, 1, 3);
            MainTableLayoutPanel.Dock = DockStyle.Fill;
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 7;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            MainTableLayoutPanel.Size = new Size(625, 527);
            MainTableLayoutPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Дата рождения:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 178);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 3;
            label3.Text = "Место жительства:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 356);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 4;
            label4.Text = "Творческий вклад:";
            // 
            // GoBackButton
            // 
            GoBackButton.Cursor = Cursors.Hand;
            GoBackButton.Dock = DockStyle.Fill;
            GoBackButton.Location = new Point(3, 488);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(181, 36);
            GoBackButton.TabIndex = 8;
            GoBackButton.Tag = "6";
            GoBackButton.Text = "Назад";
            GoBackButton.UseVisualStyleBackColor = true;
            // 
            // ReadeButton
            // 
            ReadeButton.Cursor = Cursors.Hand;
            ReadeButton.Dock = DockStyle.Fill;
            ReadeButton.Location = new Point(190, 488);
            ReadeButton.Name = "ReadeButton";
            ReadeButton.Size = new Size(432, 36);
            ReadeButton.TabIndex = 7;
            ReadeButton.Tag = "5";
            ReadeButton.Text = "Готово";
            ReadeButton.UseVisualStyleBackColor = true;
            // 
            // FioAuthorsTextBox
            // 
            FioAuthorsTextBox.AccessibleDescription = "ФИО автора(ов)";
            FioAuthorsTextBox.AccessibleName = "";
            FioAuthorsTextBox.Location = new Point(190, 3);
            FioAuthorsTextBox.Multiline = true;
            FioAuthorsTextBox.Name = "FioAuthorsTextBox";
            FioAuthorsTextBox.PlaceholderText = "Иванов Иван Иванович|Петров Петр Петрович";
            FioAuthorsTextBox.Size = new Size(411, 83);
            FioAuthorsTextBox.TabIndex = 1;
            FioAuthorsTextBox.Tag = "1";
            // 
            // DateOfBirthAuthorsTextBox
            // 
            DateOfBirthAuthorsTextBox.AccessibleDescription = "Дата рождения";
            DateOfBirthAuthorsTextBox.AccessibleName = "";
            DateOfBirthAuthorsTextBox.Location = new Point(190, 92);
            DateOfBirthAuthorsTextBox.Multiline = true;
            DateOfBirthAuthorsTextBox.Name = "DateOfBirthAuthorsTextBox";
            DateOfBirthAuthorsTextBox.PlaceholderText = "01.01.2001|02.02.2002";
            DateOfBirthAuthorsTextBox.Size = new Size(411, 83);
            DateOfBirthAuthorsTextBox.TabIndex = 2;
            DateOfBirthAuthorsTextBox.Tag = "2";
            // 
            // LocationAuthorsTextBox
            // 
            LocationAuthorsTextBox.AccessibleDescription = "Место жительства";
            LocationAuthorsTextBox.AccessibleName = "";
            LocationAuthorsTextBox.Location = new Point(190, 181);
            LocationAuthorsTextBox.Multiline = true;
            LocationAuthorsTextBox.Name = "LocationAuthorsTextBox";
            LocationAuthorsTextBox.PlaceholderText = "г. Краснодар, ул. Пушкина, д. 10, кв. 267, 350912, Российская Федерация";
            LocationAuthorsTextBox.Size = new Size(411, 83);
            LocationAuthorsTextBox.TabIndex = 3;
            LocationAuthorsTextBox.Tag = "3";
            // 
            // CreativeInputAuthorsTextBox
            // 
            CreativeInputAuthorsTextBox.AccessibleDescription = "Творческий вклад";
            CreativeInputAuthorsTextBox.AccessibleName = "";
            CreativeInputAuthorsTextBox.Location = new Point(190, 359);
            CreativeInputAuthorsTextBox.Multiline = true;
            CreativeInputAuthorsTextBox.Name = "CreativeInputAuthorsTextBox";
            CreativeInputAuthorsTextBox.PlaceholderText = "Написание программного кода|Откладка программы";
            CreativeInputAuthorsTextBox.Size = new Size(411, 83);
            CreativeInputAuthorsTextBox.TabIndex = 5;
            CreativeInputAuthorsTextBox.Tag = "5";
            // 
            // SeparatorButton
            // 
            SeparatorButton.Cursor = Cursors.Hand;
            SeparatorButton.Dock = DockStyle.Fill;
            SeparatorButton.Location = new Point(190, 448);
            SeparatorButton.Name = "SeparatorButton";
            SeparatorButton.Size = new Size(432, 34);
            SeparatorButton.TabIndex = 6;
            SeparatorButton.Tag = "7";
            SeparatorButton.Text = "Добавить разделитель '|'";
            SeparatorButton.UseVisualStyleBackColor = true;
            // 
            // PassportDetailsLabel
            // 
            PassportDetailsLabel.AutoSize = true;
            PassportDetailsLabel.Location = new Point(3, 267);
            PassportDetailsLabel.Name = "PassportDetailsLabel";
            PassportDetailsLabel.Size = new Size(128, 30);
            PassportDetailsLabel.TabIndex = 8;
            PassportDetailsLabel.Text = "Паспортные данные авторa(ов):";
            // 
            // PassportDetailsTextBox
            // 
            PassportDetailsTextBox.AccessibleDescription = "Паспортные данные автора(ов)";
            PassportDetailsTextBox.Location = new Point(190, 270);
            PassportDetailsTextBox.Multiline = true;
            PassportDetailsTextBox.Name = "PassportDetailsTextBox";
            PassportDetailsTextBox.Size = new Size(411, 83);
            PassportDetailsTextBox.TabIndex = 4;
            PassportDetailsTextBox.Tag = "4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "ФИО автора(ов):";
            // 
            // FocusTimer
            // 
            FocusTimer.Enabled = true;
            FocusTimer.Interval = 1;
            // 
            // DetectPressTimer
            // 
            DetectPressTimer.Enabled = true;
            DetectPressTimer.Interval = 1;
            // 
            // DocumentsGeneratorTwoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 527);
            Controls.Add(label1);
            Controls.Add(MainTableLayoutPanel);
            Cursor = Cursors.IBeam;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(641, 566);
            MinimumSize = new Size(641, 566);
            Name = "DocumentsGeneratorTwoView";
            StartPosition = FormStartPosition.CenterScreen;
            MainTableLayoutPanel.ResumeLayout(false);
            MainTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel MainTableLayoutPanel;
        private Button GoBackButton;
        private Button ReadeButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox DateOfBirthAuthorsTextBox;
        private TextBox LocationAuthorsTextBox;
        private TextBox CreativeInputAuthorsTextBox;
        private Button SeparatorButton;
        private TextBox FioAuthorsTextBox;
        public System.Windows.Forms.Timer FocusTimer;
        private Label PassportDetailsLabel;
        private TextBox PassportDetailsTextBox;
        private System.Windows.Forms.Timer DetectPressTimer;
    }
}