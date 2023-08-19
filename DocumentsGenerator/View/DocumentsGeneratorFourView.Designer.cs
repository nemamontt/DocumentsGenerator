namespace DocumentsGenerator.View
{
    partial class DocumentsGeneratorFourView
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
            TableLayoutPanel TableLayoutPanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentsGeneratorFourView));
            PassportDetailsTextBox = new TextBox();
            PassportDetailsLabel = new Label();
            SeparatorButton = new Button();
            GoBackButton = new Button();
            FinishButton = new Button();
            TableLayoutPanel = new TableLayoutPanel();
            TableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 2;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            TableLayoutPanel.Controls.Add(PassportDetailsTextBox, 1, 0);
            TableLayoutPanel.Controls.Add(PassportDetailsLabel, 0, 0);
            TableLayoutPanel.Controls.Add(SeparatorButton, 1, 1);
            TableLayoutPanel.Controls.Add(GoBackButton, 0, 2);
            TableLayoutPanel.Controls.Add(FinishButton, 1, 2);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 3;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            TableLayoutPanel.Size = new Size(807, 515);
            TableLayoutPanel.TabIndex = 0;
            // 
            // PassportDetailsTextBox
            // 
            PassportDetailsTextBox.Dock = DockStyle.Fill;
            PassportDetailsTextBox.Location = new Point(245, 3);
            PassportDetailsTextBox.Multiline = true;
            PassportDetailsTextBox.Name = "PassportDetailsTextBox";
            PassportDetailsTextBox.Size = new Size(559, 431);
            PassportDetailsTextBox.TabIndex = 4;
            PassportDetailsTextBox.Tag = "1";
            // 
            // PassportDetailsLabel
            // 
            PassportDetailsLabel.AutoSize = true;
            PassportDetailsLabel.Location = new Point(3, 0);
            PassportDetailsLabel.Name = "PassportDetailsLabel";
            PassportDetailsLabel.Size = new Size(220, 15);
            PassportDetailsLabel.TabIndex = 12;
            PassportDetailsLabel.Text = "Паспортные данные других авторов:";
            // 
            // SeparatorButton
            // 
            SeparatorButton.Cursor = Cursors.Hand;
            SeparatorButton.Dock = DockStyle.Fill;
            SeparatorButton.Location = new Point(245, 440);
            SeparatorButton.Name = "SeparatorButton";
            SeparatorButton.Size = new Size(559, 32);
            SeparatorButton.TabIndex = 15;
            SeparatorButton.Tag = "4";
            SeparatorButton.Text = "Добавить разделитель '|'";
            SeparatorButton.UseVisualStyleBackColor = true;
            // 
            // GoBackButton
            // 
            GoBackButton.Cursor = Cursors.Hand;
            GoBackButton.Dock = DockStyle.Fill;
            GoBackButton.Location = new Point(3, 478);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(236, 34);
            GoBackButton.TabIndex = 16;
            GoBackButton.Tag = "2";
            GoBackButton.Text = "Назад";
            GoBackButton.UseVisualStyleBackColor = true;
            // 
            // FinishButton
            // 
            FinishButton.Cursor = Cursors.Hand;
            FinishButton.Dock = DockStyle.Fill;
            FinishButton.Location = new Point(245, 478);
            FinishButton.Name = "FinishButton";
            FinishButton.Size = new Size(559, 34);
            FinishButton.TabIndex = 17;
            FinishButton.Text = "Завершить";
            FinishButton.UseVisualStyleBackColor = true;
            // 
            // DocumentsGeneratorFourView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 515);
            Controls.Add(TableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(823, 554);
            MinimumSize = new Size(823, 554);
            Name = "DocumentsGeneratorFourView";
            StartPosition = FormStartPosition.CenterScreen;
            TableLayoutPanel.ResumeLayout(false);
            TableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private TextBox PassportDetailsTextBox;
        private Label PassportDetailsLabel;
        private Button SeparatorButton;
        private Button GoBackButton;
        private Button FinishButton;
    }
}