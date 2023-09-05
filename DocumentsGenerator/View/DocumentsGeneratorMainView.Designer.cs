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
            MainPanel = new Panel();
            CreatDocumentButton = new Button();
            GetReferenceButton = new Button();
            DownloadPackageButton = new Button();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(CreatDocumentButton);
            MainPanel.Controls.Add(GetReferenceButton);
            MainPanel.Controls.Add(DownloadPackageButton);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(234, 181);
            MainPanel.TabIndex = 0;
            // 
            // CreatDocumentButton
            // 
            CreatDocumentButton.Cursor = Cursors.Hand;
            CreatDocumentButton.Dock = DockStyle.Top;
            CreatDocumentButton.FlatStyle = FlatStyle.System;
            CreatDocumentButton.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreatDocumentButton.Location = new Point(0, 0);
            CreatDocumentButton.Name = "CreatDocumentButton";
            CreatDocumentButton.Size = new Size(234, 63);
            CreatDocumentButton.TabIndex = 1;
            CreatDocumentButton.Text = "Создать пакет документов";
            CreatDocumentButton.UseVisualStyleBackColor = true;
            // 
            // GetReferenceButton
            // 
            GetReferenceButton.Cursor = Cursors.Hand;
            GetReferenceButton.Dock = DockStyle.Bottom;
            GetReferenceButton.FlatStyle = FlatStyle.System;
            GetReferenceButton.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GetReferenceButton.Location = new Point(0, 122);
            GetReferenceButton.Name = "GetReferenceButton";
            GetReferenceButton.Size = new Size(234, 59);
            GetReferenceButton.TabIndex = 3;
            GetReferenceButton.Text = "О программе";
            GetReferenceButton.UseVisualStyleBackColor = true;
            // 
            // DownloadPackageButton
            // 
            DownloadPackageButton.Cursor = Cursors.Hand;
            DownloadPackageButton.Dock = DockStyle.Fill;
            DownloadPackageButton.FlatStyle = FlatStyle.System;
            DownloadPackageButton.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
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
            Controls.Add(MainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(250, 220);
            Name = "DocumentsGeneratorMainView";
            StartPosition = FormStartPosition.CenterScreen;
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Button CreatDocumentButton;
        private Button DownloadPackageButton;
        private Button GetReferenceButton;
    }
}