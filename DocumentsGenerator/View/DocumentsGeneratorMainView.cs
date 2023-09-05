using DocumentsGenerator.StructResours;
using System.Security;
using System.Text.Json;

namespace DocumentsGenerator.View
{
    public partial class DocumentsGeneratorMainView : Form
    {
        private DocumentsGeneratorOneView? _docOne;
        private OpenFileDialog _openFileDialog;
        private SubstitutionInDocument _subDoc;
        public DocumentsGeneratorMainView(SubstitutionInDocument subDoc, bool selectJson, bool saveThisFile, bool saveOtherFile)
        {
            InitializeComponent();

            ActiveControl = MainPanel;
            _subDoc = new SubstitutionInDocument();
            _subDoc = subDoc;

            FormClosed += (sender, e) => { Application.Exit(); };

            _openFileDialog = new OpenFileDialog()
            {
                Filter = "JsonObject (*.json)|*.json",
                Title = "Open text file",
                InitialDirectory = Path.Combine(AppContext.BaseDirectory + "JsonObjects"),
                Multiselect = false
            };

            CreatDocumentButton.Click += (sender, e) =>
            {
                _docOne = new DocumentsGeneratorOneView(_subDoc, selectJson, saveOtherFile, saveThisFile);
                _docOne.Show();
            };

            DownloadPackageButton.Click += (sender, e) =>
            {
                if (Directory.EnumerateFileSystemEntries(Path.Combine(AppContext.BaseDirectory + "JsonObjects")).Any())
                {
                    try
                    {
                        if (_openFileDialog.ShowDialog() is DialogResult.OK)
                        {
                            var filePath = _openFileDialog.FileName;
                            string jsonString = File.ReadAllText(filePath);
                            _subDoc = JsonSerializer.Deserialize<SubstitutionInDocument>(jsonString);
                            selectJson = true;
                        }
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show($"Произошла ошибка:\n{ex.Message}\nДетали:\n{ex.StackTrace}");
                    }
                }
                else
                    MessageBox.Show("У Вас пока что нет пакетов", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
        }
    }
}