using DocumentsGenerator.Model;
using DocumentsGenerator.StructResours;
using DocumentsGenerator.ViewModel;

namespace DocumentsGenerator.View
{
    internal partial class DocumentsGeneratorThreeView : Form
    {
        private DocumentsGeneratorModel? _model;
        private DocumentsGeneratorTwoView? _twoView;
        private DocumentsGeneratorThreeViewModel? _vm;
        private ProgressView _progressView;

        public DocumentsGeneratorThreeView(SubstitutionInDocument subDoc, bool selectedJsonFile, bool saveThisFile)
        {
            InitializeComponent();

            ActiveControl = MainTableLayoutPanel;

            _progressView = new ProgressView(9 + Convert.ToInt32(subDoc.CountAuthor) * 2);

            if (selectedJsonFile || saveThisFile)
            {
                for (int i = 0; i < subDoc.ProgramSize.Length; i++)
                    if (subDoc.ProgramSize[i] is ' ')
                        subDoc.ProgramSize = subDoc.ProgramSize.Remove(i, 3);

                ProgramAnnotationTextBox.Text = subDoc.ProgramAnnotation;
                TypeOfСomputerComboBox.Text = subDoc.TypeOfComputer;
                ProgramLanguageComboBox.Text = subDoc.ProgramLanguage;
                ProgramSizeTextBox.Text = subDoc.ProgramSize;
                OperatingSystemComboBox.Text = subDoc.OperatingSystem;
                ProgramSizeComboBox.SelectedIndex = 1;
            }
            else
            {
                ProgramLanguageComboBox.SelectedIndex = 0;
                OperatingSystemComboBox.SelectedIndex = 0;
                TypeOfСomputerComboBox.SelectedIndex = 0;
                ProgramSizeComboBox.SelectedIndex = 1;
            }

            new ToolTip().SetToolTip(ProgramAnnotationTextBox, "Образец заполения этого поля находиться в инструкции");
            new ToolTip().SetToolTip(TypeOfСomputerComboBox, "Введите в этом поле тип ЭВМ для которого написана программа,\nнаример: IBM на базе процессора Intel Pentium IV и выше");
            new ToolTip().SetToolTip(ProgramLanguageComboBox, "Введите или выберите в этом поле язык программирования на котором написана программа, например: C#");
            new ToolTip().SetToolTip(ProgramSizeTextBox, "Введите объем вашей программы,\nнапример: 14,2 МБ");
            new ToolTip().SetToolTip(OperatingSystemComboBox, "Введите или выберите в этом поле ОС для которой написанна программа,\nнаример: Windows ХР и выше");
            ProgramAnnotationTextBox.PlaceholderText = "Образец заполнения этого поля находиться в инструкции,\nОБЯЗАТЕЛЬНО ознакомьтесь";

            ReadeButton.Click += (s, e) =>
            {
                try
                {
                    DocumentsGeneratorModel.CheckingEmptyElement(MainTableLayoutPanel.Controls);

                    if (ProgramSizeTextBox.Text == string.Empty || ProgramSizeComboBox.Text == string.Empty)
                        throw new Exception("Заполните поле \"Объем программы\"");

                    DialogResult dialogResult = MessageBox.Show("Вы уверены, что указали все корректно?\nCейчас начнется процесс создания документов", "Информация",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {

                        _vm = new DocumentsGeneratorThreeViewModel(ref subDoc, ProgramAnnotationTextBox,
                            TypeOfСomputerComboBox, ProgramLanguageComboBox, ProgramSizeTextBox, OperatingSystemComboBox, ProgramSizeComboBox);

                        _model = new DocumentsGeneratorModel(ref subDoc, _progressView);

                        Hide();
                        _model.CreatJsonFile();
                        _model.CreateAllDocuments();
                        Close();

                        MessageBox.Show("Пакет документов готов,\nон находится на рабочем столе!", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            GoBackButton.Click += (s, e) =>
            {
                DialogResult dialogResult = MessageBox.Show("Вы хотите сохранить введенные данные?", "Информация",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        DocumentsGeneratorModel.CheckingEmptyElement(NotMainTableLayoutPanel.Controls);

                        _vm = new DocumentsGeneratorThreeViewModel(ref subDoc, ProgramAnnotationTextBox,
                                TypeOfСomputerComboBox, ProgramLanguageComboBox, ProgramSizeTextBox, OperatingSystemComboBox, ProgramSizeComboBox);

                        _twoView = new DocumentsGeneratorTwoView(subDoc, selectedJsonFile, true, true);
                        _twoView.Show();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        DialogResult dialogResult2 = MessageBox.Show(ex.Message + "\nВы точно хотите покинуть форму? Данные будут не сохранены", "Информация",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult2 == DialogResult.Yes)
                        {
                            _twoView = new DocumentsGeneratorTwoView(subDoc, selectedJsonFile, false, true);
                            _twoView.Show();
                            Close();
                        }
                    }
                }
                else
                {
                    _twoView = new DocumentsGeneratorTwoView(subDoc, selectedJsonFile, false, true);
                    _twoView.Show();
                    Close();
                }
            };

            ProgramAnnotationTextBox.Validated += (s, e) =>
            {
                errorProvider1.Clear();

                for (int i = 0; i < ProgramAnnotationTextBox.Text.Length; i++)
                    if (!char.IsNumber(ProgramAnnotationTextBox.Text[i]))
                        errorProvider1.SetError(ProgramAnnotationTextBox, "Введен недопустимый символ");

                if (string.IsNullOrEmpty(ProgramAnnotationTextBox.Text))
                    errorProvider1.SetError(ProgramAnnotationTextBox, "Заполните поле");
            };

            TypeOfСomputerComboBox.Validated += (s, e) =>
            {
                errorProvider2.Clear();

                if (string.IsNullOrEmpty(TypeOfСomputerComboBox.Text))
                    errorProvider2.SetError(TypeOfСomputerComboBox, "Заполните поле");
            };

            ProgramLanguageComboBox.Validated += (s, e) =>
            {
                errorProvider3.Clear();

                if (string.IsNullOrEmpty(ProgramLanguageComboBox.Text))
                    errorProvider3.SetError(ProgramLanguageComboBox, "Заполните поле");
            };

            ProgramSizeComboBox.Validated += (s, e) =>
            {
                errorProvider4.Clear();

                for (int i = 0; i < ProgramAnnotationTextBox.Text.Length; i++)
                {
                    if (ProgramAnnotationTextBox.Text[i] is ',')
                        continue;
                    if (!char.IsNumber(ProgramAnnotationTextBox.Text[i]) || ProgramAnnotationTextBox.Text[i] is ' ')
                        errorProvider4.SetError(ProgramAnnotationTextBox, "Введен недопустимый символ, используйте запятую для разделения");
                }

                if (string.IsNullOrEmpty(ProgramSizeComboBox.Text))
                    errorProvider4.SetError(ProgramSizeComboBox, "Заполните поле");
            };

            OperatingSystemComboBox.Validated += (s, e) =>
            {
                errorProvider5.Clear();

                if (string.IsNullOrEmpty(OperatingSystemComboBox.Text))
                    errorProvider5.SetError(OperatingSystemComboBox, "Заполните поле");
            };

            MainTableLayoutPanel.CellPaint += (s, e) =>
            {
                var rectangle = e.CellBounds;
                ControlPaint.DrawBorder(e.Graphics, rectangle, Color.DarkSlateGray, ButtonBorderStyle.Solid);
            };
        }
    }
}