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
            components = new System.ComponentModel.Container();
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
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            MainTableLayoutPanel.SuspendLayout();
            NotMainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
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
            MainTableLayoutPanel.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 17);
            label1.TabIndex = 0;
            label1.Text = "Аннотация к программе:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 363);
            label5.Name = "label5";
            label5.Size = new Size(208, 34);
            label5.TabIndex = 4;
            label5.Text = "ОС для которой написанна программа:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 326);
            label4.Name = "label4";
            label4.Size = new Size(136, 17);
            label4.TabIndex = 3;
            label4.Text = "Объем программы:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 292);
            label3.Name = "label3";
            label3.Size = new Size(232, 34);
            label3.TabIndex = 2;
            label3.Text = "Язык программирования на котором написанна программа:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 263);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 1;
            label2.Text = "Тип ЭВМ:";
            // 
            // GoBackButton
            // 
            GoBackButton.Cursor = Cursors.Hand;
            GoBackButton.Dock = DockStyle.Fill;
            GoBackButton.FlatStyle = FlatStyle.System;
            GoBackButton.Location = new Point(3, 400);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(234, 47);
            GoBackButton.TabIndex = 7;
            GoBackButton.Text = "Назад";
            GoBackButton.UseVisualStyleBackColor = true;
            // 
            // ReadeButton
            // 
            ReadeButton.Cursor = Cursors.Hand;
            ReadeButton.Dock = DockStyle.Fill;
            ReadeButton.FlatStyle = FlatStyle.System;
            ReadeButton.Location = new Point(243, 400);
            ReadeButton.Name = "ReadeButton";
            ReadeButton.Size = new Size(554, 47);
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
            ProgramAnnotationTextBox.Size = new Size(554, 257);
            ProgramAnnotationTextBox.TabIndex = 1;
            ProgramAnnotationTextBox.Tag = "1";
            // 
            // ProgramLanguageComboBox
            // 
            ProgramLanguageComboBox.AccessibleDescription = "Язык программиования на котором написанна программа";
            ProgramLanguageComboBox.Cursor = Cursors.IBeam;
            ProgramLanguageComboBox.FormattingEnabled = true;
            ProgramLanguageComboBox.Items.AddRange(new object[] { "C#", "C++", "Python", "Java", "C", "JavaScript", "Pascal", "Go", "Swift", "Matlab", "Arduino" });
            ProgramLanguageComboBox.Location = new Point(243, 295);
            ProgramLanguageComboBox.Name = "ProgramLanguageComboBox";
            ProgramLanguageComboBox.Size = new Size(306, 25);
            ProgramLanguageComboBox.TabIndex = 3;
            // 
            // OperatingSystemComboBox
            // 
            OperatingSystemComboBox.AccessibleDescription = "ОС для которой написанна программа";
            OperatingSystemComboBox.Cursor = Cursors.IBeam;
            OperatingSystemComboBox.FormattingEnabled = true;
            OperatingSystemComboBox.Items.AddRange(new object[] { "Windows ХР и выше", "Windows 7 и выше", "Windows 8 и выше", "Windows 10 и выше", "macOS 11 и выше", "macOS 12 и выше", "macOS 13 и выше", "macOS 14 и выше", "Astra Linux Special Edition 1.6 и выше", "Astra Linux Common Edition 2.12 и выше" });
            OperatingSystemComboBox.Location = new Point(243, 366);
            OperatingSystemComboBox.Name = "OperatingSystemComboBox";
            OperatingSystemComboBox.Size = new Size(306, 25);
            OperatingSystemComboBox.TabIndex = 5;
            // 
            // TypeOfСomputerComboBox
            // 
            TypeOfСomputerComboBox.AccessibleDescription = "Тип ЭВМ";
            TypeOfСomputerComboBox.Cursor = Cursors.IBeam;
            TypeOfСomputerComboBox.FormattingEnabled = true;
            TypeOfСomputerComboBox.Items.AddRange(new object[] { "IBM PC-совмест. ПК", "IBM PC - совмест. ПК на базе процессора Intel Pentium", "IBM на базе процессора Intel Pentium IV и выше", "IBM РС-совмест. ПК на базе процессора Intel Pentium III и выше", "IBM РС - совмест. ПК или сервер на базе процессора с архитектурой х86-64" });
            TypeOfСomputerComboBox.Location = new Point(243, 266);
            TypeOfСomputerComboBox.Name = "TypeOfСomputerComboBox";
            TypeOfСomputerComboBox.Size = new Size(306, 25);
            TypeOfСomputerComboBox.TabIndex = 2;
            // 
            // NotMainTableLayoutPanel
            // 
            NotMainTableLayoutPanel.ColumnCount = 2;
            NotMainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            NotMainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            NotMainTableLayoutPanel.Controls.Add(ProgramSizeTextBox, 0, 0);
            NotMainTableLayoutPanel.Controls.Add(ProgramSizeComboBox, 1, 0);
            NotMainTableLayoutPanel.Location = new Point(243, 329);
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
            ProgramSizeTextBox.MaxLength = 6;
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
            ProgramSizeComboBox.Size = new Size(54, 25);
            ProgramSizeComboBox.TabIndex = 2;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider5.ContainerControl = this;
            // 
            // DocumentsGeneratorThreeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainTableLayoutPanel);
            Cursor = Cursors.Help;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DocumentsGeneratorThreeView";
            StartPosition = FormStartPosition.CenterScreen;
            MainTableLayoutPanel.ResumeLayout(false);
            MainTableLayoutPanel.PerformLayout();
            NotMainTableLayoutPanel.ResumeLayout(false);
            NotMainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
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
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
    }
}