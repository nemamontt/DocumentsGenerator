using DocumentsGenerator.StructResours;
using DocumentsGenerator.ViewModel;

namespace DocumentsGenerator.View
{
    internal partial class DocumentsGeneratorThreeView : Form
    {
        private DocumentsGeneratorTwoView? _twoView;
        private DocumentsGeneratorFourView? _fourView;
        private DocumentsGeneratorThreeViewModel? _vm;
        private bool _flagActivate;
        private List<TextBox>? _textBoxes;
        public DocumentsGeneratorThreeView(SubstitutionInDocument subDoc)
        {
            InitializeComponent();

            new ToolTip().SetToolTip(ProgramAnnotationTextBox, "Образец заполения этого поля находиться в инструкции");
            new ToolTip().SetToolTip(TypeOfСomputerTextBox, "Пример: IBM на базе процессора Intel Pentium IV и выше");
            new ToolTip().SetToolTip(ProgramLanguageTextBox, "Пример: C#");
            new ToolTip().SetToolTip(ProgramSizeTextBox, "Введите объем вашей программы,\nнапример: 14,2 МБ");
            new ToolTip().SetToolTip(OperatingSystemTextBox, "Пример: Windows ХР и выше");

            ReadeButton.Click += (sender, e) =>
            {
                _textBoxes = new List<TextBox>()
                {
                  ProgramAnnotationTextBox,
                  ProgramLanguageTextBox, 
                  ProgramSizeTextBox,
                  OperatingSystemTextBox
                };

                _flagActivate = false;

                foreach (var item in _textBoxes)
                    if (item is TextBox && item.Text == string.Empty)
                        _flagActivate = true;

                if(!_flagActivate)
                {
                    _vm = new DocumentsGeneratorThreeViewModel(ref subDoc, ProgramAnnotationTextBox,
                  TypeOfСomputerTextBox, ProgramLanguageTextBox, ProgramSizeTextBox, OperatingSystemTextBox);

                    _fourView = new DocumentsGeneratorFourView(subDoc);
                    _fourView.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Пожалуйста заполните все поля", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            GoBackButton.Click += (sender, e) =>
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите покинуть эту форму?\nДанные будут не сохранены", "Информация",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    _twoView = new DocumentsGeneratorTwoView(subDoc);
                    _twoView.Show();
                    Close();
                }              
            };
        }
    }
}
