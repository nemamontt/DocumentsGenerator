using DocumentsGenerator.Model;
using DocumentsGenerator.StructResours;
using DocumentsGenerator.ViewModel;

namespace DocumentsGenerator.View
{
    internal partial class DocumentsGeneratorTwoView : Form
    {
        private DocumentsGeneratorOneView? _oneView;
        private DocumentsGeneratorThreeView? _threeView;
        private DocumentsGeneratorTwoViewModel? _vm;
        private int _textBoxActive = default;
        private List<TextBox> _textBoxes;
        public DocumentsGeneratorTwoView(SubstitutionInDocument subDoc, bool selectedJsonFile, bool saveOtherFile, bool saveThisFile)
        {
            InitializeComponent();

            ActiveControl = MainTableLayoutPanel;

            _textBoxes = new List<TextBox>()
            {
                DateOfBirthAuthorsTextBox,
                LocationAuthorsTextBox,
                CreativeInputAuthorsTextBox,
                FioAuthorsTextBox,
                PassportDetailsTextBox
            };

            if (selectedJsonFile || saveThisFile)
            {
                FioAuthorsTextBox.Text = string.Join("|", subDoc.FioAuthors.ToArray());
                DateOfBirthAuthorsTextBox.Text = string.Join("|", subDoc.DateOfBirthAuthors.ToArray());
                LocationAuthorsTextBox.Text = string.Join("|", subDoc.LocationAuthor.ToArray());
                CreativeInputAuthorsTextBox.Text = string.Join("|", subDoc.ContributionDescriptionAuthors.ToArray());
                PassportDetailsTextBox.Text = string.Join("|", subDoc.PassportDataAuthor.ToArray());
            }

            new ToolTip().SetToolTip(FioAuthorsTextBox, "Введите в этом поле ФИО автора(ов) через разделитель,\nпример: Иванов Иван Иванович|Петров Петр Петрович");
            new ToolTip().SetToolTip(DateOfBirthAuthorsTextBox, "Введите в этом поле день рождения автора(ов) через разделитель,\nпример: 01.01.2001|02.02.2002");
            new ToolTip().SetToolTip(LocationAuthorsTextBox, "Введите в этом поле место жительства автора(ов) через разделитель,\nпример: г. Краснодар, ул. им. А. Покрышкина, д. 4/9, кв. 205, 350005, Российская Федерация|\nг. Краснодар, ул. Кореновская, д. 71, кв. 21, 350005, Российская Федерация");
            new ToolTip().SetToolTip(CreativeInputAuthorsTextBox, "Введите в этом поле творческий вклад автора(ов) через разделитель,\nпример: Написание программного кода|Откладка программы");
            new ToolTip().SetToolTip(PassportDetailsTextBox, "Введите паспортные данные автора(ов),\nнапример: Паспорт 11 11 111111, 11.11.2011, " +
                "выдан УФМС по Краснодарскому краю в Прикубанском округе в г. Краснодар");

            PassportDetailsTextBox.PlaceholderText = "Паспорт 11 11 111111, 11.11.2011,\nвыдан УФМС по Краснодарскому краю\nв Прикубанском округе в г. Краснодар";

            GoBackButton.Click += (sender, e) =>
            {
                DialogResult dialogResult = MessageBox.Show("Вы хотите сохранить введенные данные?", "Информация",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        DocumentsGeneratorModel.CheckingEmptyElement(MainTableLayoutPanel.Controls);

                        _vm = new DocumentsGeneratorTwoViewModel(ref subDoc, FioAuthorsTextBox, DateOfBirthAuthorsTextBox,
                                                LocationAuthorsTextBox, CreativeInputAuthorsTextBox, PassportDetailsTextBox);
                        
                        _oneView = new DocumentsGeneratorOneView(subDoc, selectedJsonFile, true, true);
                        _oneView.Show();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        DialogResult dialogResult2 = MessageBox.Show(ex.Message + "\nВы точно хотите покинуть форму? Данные будут не сохранены", "Информация",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult2 == DialogResult.Yes)
                        {
                            _oneView = new DocumentsGeneratorOneView(subDoc, selectedJsonFile, true, false);
                            _oneView.Show();
                            Close();
                        }
                    }
                }
                else
                {
                    _oneView = new DocumentsGeneratorOneView(subDoc, selectedJsonFile, true, false);
                    _oneView.Show();
                    Close();
                }
            };

            ReadeButton.Click += (sender, e) =>
            {
                try
                {
                    DocumentsGeneratorModel.CheckingEmptyElement(MainTableLayoutPanel.Controls);

                    _vm = new DocumentsGeneratorTwoViewModel(ref subDoc, FioAuthorsTextBox, DateOfBirthAuthorsTextBox,
                                            LocationAuthorsTextBox, CreativeInputAuthorsTextBox, PassportDetailsTextBox);

                    DialogResult dialogResult = MessageBox.Show("Вы увереныы, что указали все корректно?\nБудет осуществлен переход на следующую форму", "Информация",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _threeView = new DocumentsGeneratorThreeView(subDoc, selectedJsonFile, saveOtherFile);
                        _threeView.Show();
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            SeparatorButton.Click += (sender, e) =>
            {
                foreach (var item in _textBoxes)
                    if (item.TabIndex == _textBoxActive && item.Text is not "" && item.Text[item.Text.Length - 1] is not '|')
                        item.Text += "|";
            };

            FocusTimer.Tick += (sender, e) =>
            {
                foreach (var item in _textBoxes)
                    if (item.Focused)
                        _textBoxActive = item.TabIndex;
            };

            foreach (var item in _textBoxes)
            {
                item.KeyPress += (sender, e) =>
                {
                    if (item.Text is not "" && item.Text[item.Text.Length - 1] is '|' && e.KeyChar is '|')
                        e.Handled = true;
                    if (item.Text is not "" && item.Text[item.Text.Length - 1] is '.' && e.KeyChar is '.')
                        e.Handled = true;
                    if (item.Text is not "" && item.Text[item.Text.Length - 1] is ',' && e.KeyChar is ',')
                        e.Handled = true;
                };
            }
        }
    }
}
