﻿namespace DocumentsGenerator
{
    partial class DocumentsGeneratorOneView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentsGeneratorOneView));
            MainTableLayoutPanel = new TableLayoutPanel();
            BackButton = new Button();
            label1 = new Label();
            PONameTextBox = new TextBox();
            label7 = new Label();
            DateOfSigningDateTimePicker = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            ReadyButton = new Button();
            label2 = new Label();
            label3 = new Label();
            CountAuthorNumericUpDown = new NumericUpDown();
            PositionOfSignatoryComboBox = new ComboBox();
            FIOApplicantComboBox = new ComboBox();
            PostSigningSeparatelyLabel = new Label();
            FIOSigningSeparatelyLabel = new Label();
            FIOAddresseeLabel = new Label();
            NumberPhoneAddresseeLabel = new Label();
            FIOAddresseeComboBox = new ComboBox();
            NumberPhoneAddresseeComboBox = new ComboBox();
            NotMainTableLayoutPanel = new TableLayoutPanel();
            DateOfDiskTextBox = new TextBox();
            DateOfDiskComboBox = new ComboBox();
            PostSigningSeparatelyComboBox = new ComboBox();
            FIOSigningSeparatelyComboBox = new ComboBox();
            MainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CountAuthorNumericUpDown).BeginInit();
            NotMainTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 2;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.26891F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.7310944F));
            MainTableLayoutPanel.Controls.Add(BackButton, 0, 10);
            MainTableLayoutPanel.Controls.Add(label1, 0, 0);
            MainTableLayoutPanel.Controls.Add(PONameTextBox, 1, 0);
            MainTableLayoutPanel.Controls.Add(label7, 0, 7);
            MainTableLayoutPanel.Controls.Add(DateOfSigningDateTimePicker, 1, 9);
            MainTableLayoutPanel.Controls.Add(label9, 0, 4);
            MainTableLayoutPanel.Controls.Add(label8, 0, 9);
            MainTableLayoutPanel.Controls.Add(ReadyButton, 1, 10);
            MainTableLayoutPanel.Controls.Add(label2, 0, 8);
            MainTableLayoutPanel.Controls.Add(label3, 0, 3);
            MainTableLayoutPanel.Controls.Add(CountAuthorNumericUpDown, 1, 8);
            MainTableLayoutPanel.Controls.Add(PositionOfSignatoryComboBox, 1, 3);
            MainTableLayoutPanel.Controls.Add(FIOApplicantComboBox, 1, 4);
            MainTableLayoutPanel.Controls.Add(PostSigningSeparatelyLabel, 0, 5);
            MainTableLayoutPanel.Controls.Add(FIOSigningSeparatelyLabel, 0, 6);
            MainTableLayoutPanel.Controls.Add(FIOAddresseeLabel, 0, 1);
            MainTableLayoutPanel.Controls.Add(NumberPhoneAddresseeLabel, 0, 2);
            MainTableLayoutPanel.Controls.Add(FIOAddresseeComboBox, 1, 1);
            MainTableLayoutPanel.Controls.Add(NumberPhoneAddresseeComboBox, 1, 2);
            MainTableLayoutPanel.Controls.Add(NotMainTableLayoutPanel, 1, 7);
            MainTableLayoutPanel.Controls.Add(PostSigningSeparatelyComboBox, 1, 5);
            MainTableLayoutPanel.Controls.Add(FIOSigningSeparatelyComboBox, 1, 6);
            MainTableLayoutPanel.Dock = DockStyle.Fill;
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 11;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle());
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle());
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714264F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714264F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 42.8571434F));
            MainTableLayoutPanel.Size = new Size(691, 436);
            MainTableLayoutPanel.TabIndex = 0;
            // 
            // BackButton
            // 
            BackButton.Cursor = Cursors.Hand;
            BackButton.Dock = DockStyle.Fill;
            BackButton.Location = new Point(3, 390);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(216, 43);
            BackButton.TabIndex = 12;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 0;
            label1.Text = "Название программы:";
            // 
            // PONameTextBox
            // 
            PONameTextBox.AccessibleDescription = "Название программы";
            PONameTextBox.Cursor = Cursors.IBeam;
            PONameTextBox.Dock = DockStyle.Fill;
            PONameTextBox.Location = new Point(225, 3);
            PONameTextBox.MaxLength = 200;
            PONameTextBox.Multiline = true;
            PONameTextBox.Name = "PONameTextBox";
            PONameTextBox.PlaceholderText = "Например: Программа визуализации результатов анализа";
            PONameTextBox.Size = new Size(463, 54);
            PONameTextBox.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 289);
            label7.Name = "label7";
            label7.Size = new Size(174, 15);
            label7.TabIndex = 6;
            label7.Text = "Занимаемое место на диске:";
            // 
            // DateOfSigningDateTimePicker
            // 
            DateOfSigningDateTimePicker.Cursor = Cursors.Hand;
            DateOfSigningDateTimePicker.Location = new Point(225, 359);
            DateOfSigningDateTimePicker.Name = "DateOfSigningDateTimePicker";
            DateOfSigningDateTimePicker.Size = new Size(152, 23);
            DateOfSigningDateTimePicker.TabIndex = 10;
            DateOfSigningDateTimePicker.Value = new DateTime(2023, 8, 15, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 180);
            label9.Name = "label9";
            label9.Size = new Size(215, 15);
            label9.TabIndex = 8;
            label9.Text = "ФИО подписывающего документы:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 356);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 7;
            label8.Text = "Дата подписания:";
            // 
            // ReadyButton
            // 
            ReadyButton.Cursor = Cursors.Hand;
            ReadyButton.Dock = DockStyle.Fill;
            ReadyButton.Location = new Point(225, 390);
            ReadyButton.Name = "ReadyButton";
            ReadyButton.Size = new Size(463, 43);
            ReadyButton.TabIndex = 11;
            ReadyButton.Text = "Готово";
            ReadyButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 325);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 1;
            label2.Text = "Колличество авторов:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 140);
            label3.Name = "label3";
            label3.Size = new Size(184, 30);
            label3.TabIndex = 9;
            label3.Text = "Должность подписывающего документы:";
            // 
            // CountAuthorNumericUpDown
            // 
            CountAuthorNumericUpDown.Cursor = Cursors.Hand;
            CountAuthorNumericUpDown.Location = new Point(225, 328);
            CountAuthorNumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            CountAuthorNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CountAuthorNumericUpDown.Name = "CountAuthorNumericUpDown";
            CountAuthorNumericUpDown.ReadOnly = true;
            CountAuthorNumericUpDown.Size = new Size(152, 23);
            CountAuthorNumericUpDown.TabIndex = 9;
            CountAuthorNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // PositionOfSignatoryComboBox
            // 
            PositionOfSignatoryComboBox.AccessibleDescription = "Должность подписывающего документы:";
            PositionOfSignatoryComboBox.Cursor = Cursors.Hand;
            PositionOfSignatoryComboBox.FormattingEnabled = true;
            PositionOfSignatoryComboBox.Items.AddRange(new object[] { "Начальник Краснодарского Высшего Военного Училища", "Врио Начальник Краснодарского Высшего Военного Училища" });
            PositionOfSignatoryComboBox.Location = new Point(225, 143);
            PositionOfSignatoryComboBox.Name = "PositionOfSignatoryComboBox";
            PositionOfSignatoryComboBox.Size = new Size(463, 23);
            PositionOfSignatoryComboBox.TabIndex = 4;
            // 
            // FIOApplicantComboBox
            // 
            FIOApplicantComboBox.AccessibleDescription = "ФИО подписывающего документы:";
            FIOApplicantComboBox.Cursor = Cursors.IBeam;
            FIOApplicantComboBox.FormattingEnabled = true;
            FIOApplicantComboBox.ImeMode = ImeMode.Hiragana;
            FIOApplicantComboBox.Items.AddRange(new object[] { "Шпырня И.В.", "Киреев П.Н." });
            FIOApplicantComboBox.Location = new Point(225, 183);
            FIOApplicantComboBox.Name = "FIOApplicantComboBox";
            FIOApplicantComboBox.Size = new Size(152, 23);
            FIOApplicantComboBox.TabIndex = 5;
            // 
            // PostSigningSeparatelyLabel
            // 
            PostSigningSeparatelyLabel.AutoSize = true;
            PostSigningSeparatelyLabel.Location = new Point(3, 209);
            PostSigningSeparatelyLabel.Name = "PostSigningSeparatelyLabel";
            PostSigningSeparatelyLabel.Size = new Size(184, 30);
            PostSigningSeparatelyLabel.TabIndex = 10;
            PostSigningSeparatelyLabel.Text = "Должность подписывающего отдельные документы:";
            // 
            // FIOSigningSeparatelyLabel
            // 
            FIOSigningSeparatelyLabel.AutoSize = true;
            FIOSigningSeparatelyLabel.Location = new Point(3, 249);
            FIOSigningSeparatelyLabel.Name = "FIOSigningSeparatelyLabel";
            FIOSigningSeparatelyLabel.Size = new Size(214, 30);
            FIOSigningSeparatelyLabel.TabIndex = 11;
            FIOSigningSeparatelyLabel.Text = "ФИО подписывающего отдельные документы:";
            // 
            // FIOAddresseeLabel
            // 
            FIOAddresseeLabel.AutoSize = true;
            FIOAddresseeLabel.Location = new Point(3, 60);
            FIOAddresseeLabel.Name = "FIOAddresseeLabel";
            FIOAddresseeLabel.Size = new Size(182, 15);
            FIOAddresseeLabel.TabIndex = 14;
            FIOAddresseeLabel.Text = "ФИО адресата для переписки:";
            // 
            // NumberPhoneAddresseeLabel
            // 
            NumberPhoneAddresseeLabel.AutoSize = true;
            NumberPhoneAddresseeLabel.Location = new Point(3, 100);
            NumberPhoneAddresseeLabel.Name = "NumberPhoneAddresseeLabel";
            NumberPhoneAddresseeLabel.Size = new Size(183, 15);
            NumberPhoneAddresseeLabel.TabIndex = 15;
            NumberPhoneAddresseeLabel.Text = "Номер телефона отправителя:";
            // 
            // FIOAddresseeComboBox
            // 
            FIOAddresseeComboBox.AccessibleDescription = "ФИО адресата для переписки";
            FIOAddresseeComboBox.Cursor = Cursors.IBeam;
            FIOAddresseeComboBox.FormattingEnabled = true;
            FIOAddresseeComboBox.Items.AddRange(new object[] { "Комиссарова Т.П." });
            FIOAddresseeComboBox.Location = new Point(225, 63);
            FIOAddresseeComboBox.Name = "FIOAddresseeComboBox";
            FIOAddresseeComboBox.Size = new Size(152, 23);
            FIOAddresseeComboBox.TabIndex = 2;
            // 
            // NumberPhoneAddresseeComboBox
            // 
            NumberPhoneAddresseeComboBox.AccessibleDescription = "Номер телефона отправителя";
            NumberPhoneAddresseeComboBox.Cursor = Cursors.IBeam;
            NumberPhoneAddresseeComboBox.FormattingEnabled = true;
            NumberPhoneAddresseeComboBox.Items.AddRange(new object[] { "89615152985" });
            NumberPhoneAddresseeComboBox.Location = new Point(225, 103);
            NumberPhoneAddresseeComboBox.MaxLength = 11;
            NumberPhoneAddresseeComboBox.Name = "NumberPhoneAddresseeComboBox";
            NumberPhoneAddresseeComboBox.Size = new Size(152, 23);
            NumberPhoneAddresseeComboBox.TabIndex = 3;
            // 
            // NotMainTableLayoutPanel
            // 
            NotMainTableLayoutPanel.ColumnCount = 2;
            NotMainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            NotMainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            NotMainTableLayoutPanel.Controls.Add(DateOfDiskTextBox, 0, 0);
            NotMainTableLayoutPanel.Controls.Add(DateOfDiskComboBox, 1, 0);
            NotMainTableLayoutPanel.Location = new Point(225, 292);
            NotMainTableLayoutPanel.Name = "NotMainTableLayoutPanel";
            NotMainTableLayoutPanel.RowCount = 1;
            NotMainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            NotMainTableLayoutPanel.Size = new Size(152, 30);
            NotMainTableLayoutPanel.TabIndex = 8;
            // 
            // DateOfDiskTextBox
            // 
            DateOfDiskTextBox.Cursor = Cursors.IBeam;
            DateOfDiskTextBox.Location = new Point(3, 3);
            DateOfDiskTextBox.MaxLength = 4;
            DateOfDiskTextBox.Name = "DateOfDiskTextBox";
            DateOfDiskTextBox.PlaceholderText = "Например: 120";
            DateOfDiskTextBox.Size = new Size(93, 23);
            DateOfDiskTextBox.TabIndex = 4;
            // 
            // DateOfDiskComboBox
            // 
            DateOfDiskComboBox.Cursor = Cursors.Hand;
            DateOfDiskComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DateOfDiskComboBox.FormattingEnabled = true;
            DateOfDiskComboBox.Items.AddRange(new object[] { "КБ", "МБ", "ГБ" });
            DateOfDiskComboBox.Location = new Point(102, 3);
            DateOfDiskComboBox.Name = "DateOfDiskComboBox";
            DateOfDiskComboBox.Size = new Size(50, 23);
            DateOfDiskComboBox.TabIndex = 5;
            // 
            // PostSigningSeparatelyComboBox
            // 
            PostSigningSeparatelyComboBox.Cursor = Cursors.IBeam;
            PostSigningSeparatelyComboBox.FormattingEnabled = true;
            PostSigningSeparatelyComboBox.Items.AddRange(new object[] { "Врио начальника отдела (организации научной работы и подготовки научно-педагогических кадров)", "Начальника отдела (организации научной работы и подготовки научно-педагогических кадров)" });
            PostSigningSeparatelyComboBox.Location = new Point(225, 212);
            PostSigningSeparatelyComboBox.Name = "PostSigningSeparatelyComboBox";
            PostSigningSeparatelyComboBox.Size = new Size(463, 23);
            PostSigningSeparatelyComboBox.TabIndex = 6;
            // 
            // FIOSigningSeparatelyComboBox
            // 
            FIOSigningSeparatelyComboBox.Cursor = Cursors.IBeam;
            FIOSigningSeparatelyComboBox.FormattingEnabled = true;
            FIOSigningSeparatelyComboBox.Items.AddRange(new object[] { "К.Баданин" });
            FIOSigningSeparatelyComboBox.Location = new Point(225, 252);
            FIOSigningSeparatelyComboBox.Name = "FIOSigningSeparatelyComboBox";
            FIOSigningSeparatelyComboBox.Size = new Size(152, 23);
            FIOSigningSeparatelyComboBox.TabIndex = 7;
            // 
            // DocumentsGeneratorOneView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 436);
            Controls.Add(MainTableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(700, 290);
            Name = "DocumentsGeneratorOneView";
            StartPosition = FormStartPosition.CenterScreen;
            MainTableLayoutPanel.ResumeLayout(false);
            MainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CountAuthorNumericUpDown).EndInit();
            NotMainTableLayoutPanel.ResumeLayout(false);
            NotMainTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainTableLayoutPanel;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox PONameTextBox;
        private DateTimePicker DateOfSigningDateTimePicker;
        private Button BackButton;
        private Button ReadyButton;
        private NumericUpDown CountAuthorNumericUpDown;
        private Label label3;
        private ComboBox PositionOfSignatoryComboBox;
        private ComboBox FIOApplicantComboBox;
        private TableLayoutPanel NotMainTableLayoutPanel;
        private TextBox DateOfDiskTextBox;
        private ComboBox DateOfDiskComboBox;
        private Label PostSigningSeparatelyLabel;
        private Label FIOSigningSeparatelyLabel;
        private ComboBox PostSigningSeparatelyComboBox;
        private ComboBox FIOSigningSeparatelyComboBox;
        private Label FIOAddresseeLabel;
        private Label NumberPhoneAddresseeLabel;
        private ComboBox FIOAddresseeComboBox;
        private ComboBox NumberPhoneAddresseeComboBox;
    }
}