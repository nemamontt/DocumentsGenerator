namespace DocumentsGenerator.View
{
    public partial class DocumentsGeneratorMainView : Form
    {
        private DocumentsGeneratorOneView _docOne;
        public DocumentsGeneratorMainView()
        {
            InitializeComponent();

            CreatDocumentButton.Click += (sender, e) =>
            {
                _docOne = new DocumentsGeneratorOneView();
                _docOne.Show();
            };
        }
    }
}
