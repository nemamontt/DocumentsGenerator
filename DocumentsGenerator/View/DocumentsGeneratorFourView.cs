using DocumentsGenerator.StructResours;
using DocumentsGenerator.Model;
using DocumentsGenerator.ViewModel;

namespace DocumentsGenerator.View
{
    internal partial class DocumentsGeneratorFourView : Form
    {
        private DocumentsGeneratorTwoView? _threeView;
        private DocumentsGeneratorModel? _model;
        private DocumentsGeneratorFourViewModel? _vm;
        public DocumentsGeneratorFourView(SubstitutionInDocument subDoc)
        {
            InitializeComponent();

            new ToolTip().SetToolTip(PassportDetailsTextBox, "Введите паспортные данные автора,\nнапример: Паспорт 11 11 111111, 11.11.2011, выдан УФМС по Краснодарскому краю в Прикубанском округе в г. Краснодар");


            GoBackButton.Click += (sender, e) =>
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите покинуть эту форму?\nДанные будут не сохранены", "Информация",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    _threeView = new DocumentsGeneratorTwoView(subDoc);
                    _threeView.Show();
                    Close();
                }                  
            };

            FinishButton.Click += (sender, e) =>
            {
                if(PassportDetailsTextBox.Text != string.Empty)
                {
                    _vm = new DocumentsGeneratorFourViewModel(ref subDoc, PassportDetailsTextBox);
                    _model = new DocumentsGeneratorModel(ref subDoc);
                    _model.CreateDocuments();
                    _model.CreatJsonFile();
                    MessageBox.Show("Пакет документов готов,\nон находиться на рабочем столе!", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                    MessageBox.Show("Пожалуйста заполните поле", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            SeparatorButton.Click += (sender, e) =>
            {
                PassportDetailsTextBox.Text += "|";
            };
        }
    }
}
