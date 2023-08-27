namespace DocumentsGenerator.View
{
    partial class DocumentsGeneratorThreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentsGeneratorThreeView));
            MainTableLayoutPanel = new TableLayoutPanel();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            GoBackButton = new Button();
            ReadeButton = new Button();
            ProgramAnnotationTextBox = new TextBox();
            ProgramLanguageComboBox = new ComboBox();
            OperatingSystemComboBox = new ComboBox();
            TypeOfСomputerComboBox = new ComboBox();
            NotMainTableLayoutPanel = new TableLayoutPanel();
            ProgramSizeTextBox = new TextBox();
            ProgramSizeComboBox = new ComboBox();
            MainTableLayoutPanel.SuspendLayout();
            NotMainTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 2;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            MainTableLayoutPanel.Controls.Add(label1, 0, 0);
            MainTableLayoutPanel.Controls.Add(label5, 0, 4);
            MainTableLayoutPanel.Controls.Add(label4, 0, 3);
            MainTableLayoutPanel.Controls.Add(label3, 0, 2);
            MainTableLayoutPanel.Controls.Add(label2, 0, 1);
            MainTableLayoutPanel.Controls.Add(GoBackButton, 0, 5);
            MainTableLayoutPanel.Controls.Add(ReadeButton, 1, 5);
            MainTableLayoutPanel.Controls.Add(ProgramAnnotationTextBox, 1, 0);
            MainTableLayoutPanel.Controls.Add(ProgramLanguageComboBox, 1, 2);
            MainTableLayoutPanel.Controls.Add(OperatingSystemComboBox, 1, 4);
            MainTableLayoutPanel.Controls.Add(TypeOfСomputerComboBox, 1, 1);
            MainTableLayoutPanel.Controls.Add(NotMainTableLayoutPanel, 1, 3);
            MainTableLayoutPanel.Dock = DockStyle.Fill;
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 6;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 83.33334F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle());
            MainTableLayoutPanel.RowStyles.Add(new RowStyle());
            MainTableLayoutPanel.RowStyles.Add(new RowStyle());
            MainTableLayoutPanel.RowStyles.Add(new RowStyle());
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66666F));
            MainTableLayoutPanel.Size = new Size(800, 450);
            MainTableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "Аннотация к программе:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 366);
            label5.Name = "label5";
            label5.Size = new Size(230, 15);
            label5.TabIndex = 4;
            label5.Text = "ОС для которой написанна программа:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 329);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 3;
            label4.Text = "Объем программы:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 299);
            label3.Name = "label3";
            label3.Size = new Size(226, 30);
            label3.TabIndex = 2;
            label3.Text = "Язык программирования на котором написанна программа:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 270);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Тип ЭВМ:";
            // 
            // GoBackButton
            // 
            GoBackButton.Cursor = Cursors.Hand;
            GoBackButton.Dock = DockStyle.Fill;
            GoBackButton.Location = new Point(3, 398);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(234, 49);
            GoBackButton.TabIndex = 7;
            GoBackButton.Text = "Назад";
            GoBackButton.UseVisualStyleBackColor = true;
            // 
            // ReadeButton
            // 
            ReadeButton.Cursor = Cursors.Hand;
            ReadeButton.Dock = DockStyle.Fill;
            ReadeButton.Location = new Point(243, 398);
            ReadeButton.Name = "ReadeButton";
            ReadeButton.Size = new Size(554, 49);
            ReadeButton.TabIndex = 6;
            ReadeButton.Text = "Завершить";
            ReadeButton.UseVisualStyleBackColor = true;
            // 
            // ProgramAnnotationTextBox
            // 
            ProgramAnnotationTextBox.AccessibleDescription = "Аннотация к программе";
            ProgramAnnotationTextBox.Cursor = Cursors.IBeam;
            ProgramAnnotationTextBox.Dock = DockStyle.Fill;
            ProgramAnnotationTextBox.Location = new Point(243, 3);
            ProgramAnnotationTextBox.Multiline = true;
            ProgramAnnotationTextBox.Name = "ProgramAnnotationTextBox";
            ProgramAnnotationTextBox.PlaceholderText = "Образец заполнения этого поля находиться в инструкции, ОБЯЗАТЕЛЬНО ознакомьтесь";
            ProgramAnnotationTextBox.Size = new Size(554, 264);
            ProgramAnnotationTextBox.TabIndex = 1;
            ProgramAnnotationTextBox.Tag = "1";
            // 
            // ProgramLanguageComboBox
            // 
            ProgramLanguageComboBox.AccessibleDescription = "Язык программиования на котором написанна программа";
            ProgramLanguageComboBox.Cursor = Cursors.IBeam;
            ProgramLanguageComboBox.FormattingEnabled = true;
            ProgramLanguageComboBox.Items.AddRange(new object[] { "C#", "C++", "Python", "Java", "C", "JavaScript", "Pascal", "Go", "Swift", "Matlab", "Arduino" });
            ProgramLanguageComboBox.Location = new Point(243, 302);
            ProgramLanguageComboBox.Name = "ProgramLanguageComboBox";
            ProgramLanguageComboBox.Size = new Size(276, 23);
            ProgramLanguageComboBox.TabIndex = 3;
            // 
            // OperatingSystemComboBox
            // 
            OperatingSystemComboBox.AccessibleDescription = "ОС для которой написанна программа";
            OperatingSystemComboBox.Cursor = Cursors.IBeam;
            OperatingSystemComboBox.FormattingEnabled = true;
            OperatingSystemComboBox.Items.AddRange(new object[] { "Windows ХР и выше", "Windows 7 и выше", "Windows 8 и выше", "Windows 10 и выше", "macOS 11 и выше", "macOS 12 и выше", "macOS 13 и выше", "macOS 14 и выше", "Astra Linux Special Edition 1.6 и выше", "Astra Linux Common Edition 2.12 и выше" });
            OperatingSystemComboBox.Location = new Point(243, 369);
            OperatingSystemComboBox.Name = "OperatingSystemComboBox";
            OperatingSystemComboBox.Size = new Size(276, 23);
            OperatingSystemComboBox.TabIndex = 5;
            // 
            // TypeOfСomputerComboBox
            // 
            TypeOfСomputerComboBox.AccessibleDescription = "Тип ЭВМ";
            TypeOfСomputerComboBox.Cursor = Cursors.IBeam;
            TypeOfСomputerComboBox.FormattingEnabled = true;
            TypeOfСomputerComboBox.Items.AddRange(new object[] { "IBM на базе процессора Intel Pentium IV и выше" });
            TypeOfСomputerComboBox.Location = new Point(243, 273);
            TypeOfСomputerComboBox.Name = "TypeOfСomputerComboBox";
            TypeOfСomputerComboBox.Size = new Size(306, 23);
            TypeOfСomputerComboBox.TabIndex = 2;
            // 
            // NotMainTableLayoutPanel
            // 
            NotMainTableLayoutPanel.ColumnCount = 2;
            NotMainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            NotMainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            NotMainTableLayoutPanel.Controls.Add(ProgramSizeTextBox, 0, 0);
            NotMainTableLayoutPanel.Controls.Add(ProgramSizeComboBox, 1, 0);
            NotMainTableLayoutPanel.Location = new Point(243, 332);
            NotMainTableLayoutPanel.Name = "NotMainTableLayoutPanel";
            NotMainTableLayoutPanel.RowCount = 1;
            NotMainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            NotMainTableLayoutPanel.Size = new Size(167, 31);
            NotMainTableLayoutPanel.TabIndex = 4;
            // 
            // ProgramSizeTextBox
            // 
            ProgramSizeTextBox.AccessibleDescription = "Объем программы";
            ProgramSizeTextBox.Cursor = Cursors.IBeam;
            ProgramSizeTextBox.Location = new Point(3, 3);
            ProgramSizeTextBox.MaxLength = 4;
            ProgramSizeTextBox.Name = "ProgramSizeTextBox";
            ProgramSizeTextBox.PlaceholderText = "15,5";
            ProgramSizeTextBox.Size = new Size(100, 23);
            ProgramSizeTextBox.TabIndex = 1;
            // 
            // ProgramSizeComboBox
            // 
            ProgramSizeComboBox.Cursor = Cursors.Hand;
            ProgramSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ProgramSizeComboBox.FormattingEnabled = true;
            ProgramSizeComboBox.Items.AddRange(new object[] { "КБ", "МБ", "ГБ" });
            ProgramSizeComboBox.Location = new Point(109, 3);
            ProgramSizeComboBox.Name = "ProgramSizeComboBox";
            ProgramSizeComboBox.Size = new Size(54, 23);
            ProgramSizeComboBox.TabIndex = 2;
            // 
            // DocumentsGeneratorThreeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DocumentsGeneratorThreeView";
            StartPosition = FormStartPosition.CenterScreen;
            MainTableLayoutPanel.ResumeLayout(false);
            MainTableLayoutPanel.PerformLayout();
            NotMainTableLayoutPanel.ResumeLayout(false);
            NotMainTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainTableLayoutPanel;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button GoBackButton;
        private Button ReadeButton;
        private TextBox ProgramAnnotationTextBox;
        private ComboBox ProgramLanguageComboBox;
        private ComboBox OperatingSystemComboBox;
        private ComboBox TypeOfСomputerComboBox;
        private TableLayoutPanel NotMainTableLayoutPanel;
        private TextBox ProgramSizeTextBox;
        private ComboBox ProgramSizeComboBox;
    }
}