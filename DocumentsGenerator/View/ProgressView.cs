namespace DocumentsGenerator.View
{
    public partial class ProgressView : Form
    {
        public ProgressView(int maximum)
        {
            InitializeComponent();

            ResultProgressBar.Minimum = 0;
            ResultProgressBar.Maximum = maximum;
            ResultProgressBar.Step = 1;
            ResultProgressBar.Value = 0;
        }
        public void UploadingProgress()
        {
            ResultProgressBar.PerformStep();
        }
    }
}
