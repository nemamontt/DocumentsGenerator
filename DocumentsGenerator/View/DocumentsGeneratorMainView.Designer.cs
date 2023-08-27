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
            Panel = new Panel();
            CreatDocumentButton = new Button();
            button3 = new Button();
            DownloadPackageButton = new Button();
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Controls.Add(CreatDocumentButton);
            Panel.Controls.Add(button3);
            Panel.Controls.Add(DownloadPackageButton);
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(234, 181);
            Panel.TabIndex = 0;
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
            // DownloadPackageButton
            // 
            DownloadPackageButton.Cursor = Cursors.Hand;
            DownloadPackageButton.Dock = DockStyle.Fill;
            DownloadPackageButton.FlatStyle = FlatStyle.System;
            DownloadPackageButton.Location = new Point(0, 0);
            DownloadPackageButton.Name = "DownloadPackageButton";
            DownloadPackageButton.Size = new Size(234, 181);
            DownloadPackageButton.TabIndex = 2;
            DownloadPackageButton.Text = "Загрузить пакет";
            DownloadPackageButton.UseVisualStyleBackColor = true;
            // 
            // DocumentsGeneratorMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 181);
            Controls.Add(Panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(250, 220);
            Name = "DocumentsGeneratorMainView";
            StartPosition = FormStartPosition.CenterScreen;
            Panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Button CreatDocumentButton;
        private Button DownloadPackageButton;
        private Button button3;
    }
}