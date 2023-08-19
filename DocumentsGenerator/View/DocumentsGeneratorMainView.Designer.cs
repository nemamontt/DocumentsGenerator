namespace DocumentsGenerator.View
{
    partial class DocumentsGeneratorMainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentsGeneratorMainView));
            panel1 = new Panel();
            CreatDocumentButton = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CreatDocumentButton);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 181);
            panel1.TabIndex = 0;
            // 
            // CreatDocumentButton
            // 
            CreatDocumentButton.Cursor = Cursors.Hand;
            CreatDocumentButton.Dock = DockStyle.Top;
            CreatDocumentButton.FlatStyle = FlatStyle.System;
            CreatDocumentButton.Location = new Point(0, 0);
            CreatDocumentButton.Name = "CreatDocumentButton";
            CreatDocumentButton.Size = new Size(234, 63);
            CreatDocumentButton.TabIndex = 1;
            CreatDocumentButton.Text = "Создать пакет документов";
            CreatDocumentButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Bottom;
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(0, 122);
            button3.Name = "button3";
            button3.Size = new Size(234, 59);
            button3.TabIndex = 3;
            button3.Text = "О программе";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(234, 181);
            button2.TabIndex = 2;
            button2.Text = "Загрузить пакет";
            button2.UseVisualStyleBackColor = true;
            // 
            // DocumentsGeneratorMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 181);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(250, 220);
            Name = "DocumentsGeneratorMainView";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CreatDocumentButton;
        private Button button2;
        private Button button3;
    }
}