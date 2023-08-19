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
            tableLayoutPanel = new TableLayoutPanel();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            GoBackButton = new Button();
            ReadeButton = new Button();
            ProgramAnnotationTextBox = new TextBox();
            TypeOfСomputerTextBox = new TextBox();
            ProgramLanguageTextBox = new TextBox();
            ProgramSizeTextBox = new TextBox();
            OperatingSystemTextBox = new TextBox();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel.Controls.Add(label1, 0, 0);
            tableLayoutPanel.Controls.Add(label5, 0, 4);
            tableLayoutPanel.Controls.Add(label4, 0, 3);
            tableLayoutPanel.Controls.Add(label3, 0, 2);
            tableLayoutPanel.Controls.Add(label2, 0, 1);
            tableLayoutPanel.Controls.Add(GoBackButton, 0, 5);
            tableLayoutPanel.Controls.Add(ReadeButton, 1, 5);
            tableLayoutPanel.Controls.Add(ProgramAnnotationTextBox, 1, 0);
            tableLayoutPanel.Controls.Add(TypeOfСomputerTextBox, 1, 1);
            tableLayoutPanel.Controls.Add(ProgramLanguageTextBox, 1, 2);
            tableLayoutPanel.Controls.Add(ProgramSizeTextBox, 1, 3);
            tableLayoutPanel.Controls.Add(OperatingSystemTextBox, 1, 4);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.Size = new Size(800, 461);
            tableLayoutPanel.TabIndex = 0;
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
            label5.Location = new Point(3, 368);
            label5.Name = "label5";
            label5.Size = new Size(230, 15);
            label5.TabIndex = 4;
            label5.Text = "ОС для которой написанна программа:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 322);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 3;
            label4.Text = "Объем программы:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 276);
            label3.Name = "label3";
            label3.Size = new Size(226, 30);
            label3.TabIndex = 2;
            label3.Text = "Язык программирования на котором написанна программа:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 230);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Тип ЭВМ:";
            // 
            // GoBackButton
            // 
            GoBackButton.Cursor = Cursors.Hand;
            GoBackButton.Dock = DockStyle.Fill;
            GoBackButton.Location = new Point(3, 417);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(234, 41);
            GoBackButton.TabIndex = 7;
            GoBackButton.Text = "Назад";
            GoBackButton.UseVisualStyleBackColor = true;
            // 
            // ReadeButton
            // 
            ReadeButton.Cursor = Cursors.Hand;
            ReadeButton.Dock = DockStyle.Fill;
            ReadeButton.Location = new Point(243, 417);
            ReadeButton.Name = "ReadeButton";
            ReadeButton.Size = new Size(554, 41);
            ReadeButton.TabIndex = 6;
            ReadeButton.Text = "Готово";
            ReadeButton.UseVisualStyleBackColor = true;
            // 
            // ProgramAnnotationTextBox
            // 
            ProgramAnnotationTextBox.Cursor = Cursors.IBeam;
            ProgramAnnotationTextBox.Dock = DockStyle.Fill;
            ProgramAnnotationTextBox.Location = new Point(243, 3);
            ProgramAnnotationTextBox.Multiline = true;
            ProgramAnnotationTextBox.Name = "ProgramAnnotationTextBox";
            ProgramAnnotationTextBox.Size = new Size(554, 224);
            ProgramAnnotationTextBox.TabIndex = 1;
            ProgramAnnotationTextBox.Tag = "1";
            // 
            // TypeOfСomputerTextBox
            // 
            TypeOfСomputerTextBox.Cursor = Cursors.IBeam;
            TypeOfСomputerTextBox.Dock = DockStyle.Fill;
            TypeOfСomputerTextBox.Location = new Point(243, 233);
            TypeOfСomputerTextBox.Multiline = true;
            TypeOfСomputerTextBox.Name = "TypeOfСomputerTextBox";
            TypeOfСomputerTextBox.Size = new Size(554, 40);
            TypeOfСomputerTextBox.TabIndex = 2;
            // 
            // ProgramLanguageTextBox
            // 
            ProgramLanguageTextBox.Cursor = Cursors.IBeam;
            ProgramLanguageTextBox.Dock = DockStyle.Fill;
            ProgramLanguageTextBox.Location = new Point(243, 279);
            ProgramLanguageTextBox.Multiline = true;
            ProgramLanguageTextBox.Name = "ProgramLanguageTextBox";
            ProgramLanguageTextBox.Size = new Size(554, 40);
            ProgramLanguageTextBox.TabIndex = 3;
            // 
            // ProgramSizeTextBox
            // 
            ProgramSizeTextBox.Cursor = Cursors.IBeam;
            ProgramSizeTextBox.Dock = DockStyle.Fill;
            ProgramSizeTextBox.Location = new Point(243, 325);
            ProgramSizeTextBox.Multiline = true;
            ProgramSizeTextBox.Name = "ProgramSizeTextBox";
            ProgramSizeTextBox.Size = new Size(554, 40);
            ProgramSizeTextBox.TabIndex = 4;
            // 
            // OperatingSystemTextBox
            // 
            OperatingSystemTextBox.Cursor = Cursors.IBeam;
            OperatingSystemTextBox.Dock = DockStyle.Fill;
            OperatingSystemTextBox.Location = new Point(243, 371);
            OperatingSystemTextBox.Multiline = true;
            OperatingSystemTextBox.Name = "OperatingSystemTextBox";
            OperatingSystemTextBox.Size = new Size(554, 40);
            OperatingSystemTextBox.TabIndex = 5;
            // 
            // DocumentsGeneratorThreeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(tableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DocumentsGeneratorThreeView";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button GoBackButton;
        private Button ReadeButton;
        private TextBox ProgramAnnotationTextBox;
        private TextBox TypeOfСomputerTextBox;
        private TextBox ProgramLanguageTextBox;
        private TextBox ProgramSizeTextBox;
        private TextBox OperatingSystemTextBox;
    }
}