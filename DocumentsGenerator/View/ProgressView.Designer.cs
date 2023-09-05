namespace DocumentsGenerator.View
{
    partial class ProgressView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressView));
            ResultProgressBar = new ProgressBar();
            GeneratingPointsTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ResultProgressBar
            // 
            ResultProgressBar.Dock = DockStyle.Fill;
            ResultProgressBar.Location = new Point(0, 0);
            ResultProgressBar.Name = "ResultProgressBar";
            ResultProgressBar.Size = new Size(383, 43);
            ResultProgressBar.Style = ProgressBarStyle.Continuous;
            ResultProgressBar.TabIndex = 0;
            // 
            // GeneratingPointsTimer
            // 
            GeneratingPointsTimer.Enabled = true;
            // 
            // ProgressView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 43);
            Controls.Add(ResultProgressBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ProgressView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создание пакета";
            ResumeLayout(false);
        }

        #endregion
        public ProgressBar ResultProgressBar;
        private System.Windows.Forms.Timer GeneratingPointsTimer;
    }
}