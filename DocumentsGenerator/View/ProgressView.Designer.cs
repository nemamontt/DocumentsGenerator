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
            ResultProgressBar = new ProgressBar();
            TextLabel = new Label();
            GeneratingPointsTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ResultProgressBar
            // 
            ResultProgressBar.Location = new Point(12, 33);
            ResultProgressBar.Name = "ResultProgressBar";
            ResultProgressBar.Size = new Size(331, 46);
            ResultProgressBar.Style = ProgressBarStyle.Continuous;
            ResultProgressBar.TabIndex = 0;
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.BackColor = Color.Transparent;
            TextLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextLabel.Location = new Point(102, 9);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(145, 21);
            TextLabel.TabIndex = 1;
            TextLabel.Text = "Создание пакета";
            // 
            // GeneratingPointsTimer
            // 
            GeneratingPointsTimer.Enabled = true;
            // 
            // ProgressView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 91);
            Controls.Add(TextLabel);
            Controls.Add(ResultProgressBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(376, 130);
            MinimumSize = new Size(376, 130);
            Name = "ProgressView";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TextLabel;
        public ProgressBar ResultProgressBar;
        private System.Windows.Forms.Timer GeneratingPointsTimer;
    }
}