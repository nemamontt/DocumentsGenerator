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
        private Dictionary<ErrorProvider, TextBox> _errorAndField;
        private int _textBoxActive = default;
        public DocumentsGeneratorTwoView(SubstitutionInDocument subDoc, bool selectedJsonFile, bool saveOtherFile, bool saveThisFile)
        {
            InitializeComponent();

            ActiveControl = MainTableLayoutPanel;

            _errorAndField = new Dictionary<ErrorProvider, TextBox>()
            {
                {errorProvider1, FioAuthorsTextBox},
                {errorProvider2, DateOfBirthAuthorsTextBox},
                {errorProvider3, LocationAuthorsTextBox},
                {errorProvider4, PassportDetailsTextBox},
                {errorProvider5, CreativeInputAuthorsTextBox}
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
            new ToolTip().SetToolTip(PassportDetailsTextBox, "Введите паспортные данные автора(ов),\nнапример: Паспорт 11 11 111111, 11.11.2011, выдан УФМС по Краснодарскому краю в Прикубанском округе в г. Краснодар");

            PassportDetailsTextBox.PlaceholderText = "Паспорт 11 11 111111, 11.11.2011,\nвыдан УФМС по Краснодарскому краю\nв Прикубанском округе в г. Краснодар";

            GoBackButton.Click += (s, e) =>
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

            ReadeButton.Click += (s, e) =>
            {
                try
                {
                    foreach (var item in _errorAndField)
                        if (item.Key.GetError(item.Value) != string.Empty) return;

                    DocumentsGeneratorModel.CheckingEmptyElement(MainTableLayoutPanel.Controls);

                    _vm = new DocumentsGeneratorTwoViewModel(ref subDoc, FioAuthorsTextBox, DateOfBirthAuthorsTextBox,
                                            LocationAuthorsTextBox, CreativeInputAuthorsTextBox, PassportDetailsTextBox);

                    DialogResult dialogResult = MessageBox.Show("Вы уверены, что указали все корректно?\nБудет осуществлен переход на следующую форму", "Информация",
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

            SeparatorButton.Click += (s, e) =>
            {
                foreach (var item in _errorAndField)
                    if (item.Value.TabIndex == _textBoxActive && item.Value.Text is not "" && item.Value.Text[item.Value.Text.Length - 1] is not '|')
                        item.Value.Text += "|";
            };

            FocusTimer.Tick += (s, e) =>
            {
                foreach (var item in _errorAndField)
                    if (item.Value.Focused)
                        _textBoxActive = item.Value.TabIndex;
            };

            FioAuthorsTextBox.Validated += (s, e) =>
            {
                errorProvider1.Clear();

                DetectSeparator(errorProvider1, FioAuthorsTextBox, Convert.ToInt32(subDoc.CountAuthor));
                DetectValidCharacter(errorProvider1, FioAuthorsTextBox);

                if (string.IsNullOrEmpty(FioAuthorsTextBox.Text))
                    errorProvider1.SetError(FioAuthorsTextBox, "Заполните поле");
            };

            DateOfBirthAuthorsTextBox.Validated += (s, e) =>
            {
                errorProvider2.Clear();

                int counterPoints = default;

                DetectSeparator(errorProvider2, DateOfBirthAuthorsTextBox, Convert.ToInt32(subDoc.CountAuthor));

                for (int i = 0; i < DateOfBirthAuthorsTextBox.Text.Length; i++)
                    if (DateOfBirthAuthorsTextBox.Text[i] is '.')
                        counterPoints++;

                for (int i = 0; i < DateOfBirthAuthorsTextBox.Text.Length; i++)
                    if (DateOfBirthAuthorsTextBox.Text[i] is ' ')
                        errorProvider2.SetError(DateOfBirthAuthorsTextBox, "Удалите пробел");

                if (string.IsNullOrEmpty(DateOfBirthAuthorsTextBox.Text))
                    errorProvider2.SetError(DateOfBirthAuthorsTextBox, "Заполните поле");
                else if (counterPoints != Convert.ToInt32(subDoc.CountAuthor) * 2)
                    errorProvider2.SetError(DateOfBirthAuthorsTextBox, "Вы где-то заыбыли точку, формат: дд.мм.гггг");
            };

            LocationAuthorsTextBox.Validated += (s, e) =>
            {
                errorProvider3.Clear();

                DetectSeparator(errorProvider3, LocationAuthorsTextBox, Convert.ToInt32(subDoc.CountAuthor));

                if (string.IsNullOrEmpty(LocationAuthorsTextBox.Text))
                    errorProvider3.SetError(LocationAuthorsTextBox, "Заполните поле");
            };

            PassportDetailsTextBox.Validated += (s, e) =>
            {
                errorProvider4.Clear();

                DetectSeparator(errorProvider4, PassportDetailsTextBox, Convert.ToInt32(subDoc.CountAuthor));

                if (string.IsNullOrEmpty(PassportDetailsTextBox.Text))
                    errorProvider4.SetError(PassportDetailsTextBox, "Заполните поле");
            };

            CreativeInputAuthorsTextBox.Validated += (s, e) =>
            {
                errorProvider5.Clear();
            
                DetectSeparator(errorProvider5, CreativeInputAuthorsTextBox, Convert.ToInt32(subDoc.CountAuthor));

                if (string.IsNullOrEmpty(CreativeInputAuthorsTextBox.Text))
                    errorProvider5.SetError(CreativeInputAuthorsTextBox, "Заполните поле");
            };

            MainTableLayoutPanel.CellPaint += (s, e) =>
            {
                var rectangle = e.CellBounds;
                ControlPaint.DrawBorder(e.Graphics, rectangle, Color.DarkSlateGray, ButtonBorderStyle.Solid);
            };

            foreach (var item in _errorAndField)
            {
                item.Value.KeyPress += (sender, e) =>
                {
                    if (item.Value.Text is not "" && item.Value.Text[item.Value.Text.Length - 1] is '|' && e.KeyChar is '|')
                        e.Handled = true;
                    if (item.Value.Text is not "" && item.Value.Text[item.Value.Text.Length - 1] is '.' && e.KeyChar is '.')
                        e.Handled = true;
                    if (item.Value.Text is not "" && item.Value.Text[item.Value.Text.Length - 1] is ',' && e.KeyChar is ',')
                        e.Handled = true;
                    if (item.Value.Text is not "" && item.Value.Text[item.Value.Text.Length - 1] is '|' && e.KeyChar is ' ')
                        e.Handled = true;
                        
                };
            }

            DateOfBirthAuthorsTextBox.KeyPress += (s, e) =>
            {
                if (e.KeyChar is ' ')
                    e.Handled = true;
                if(e.KeyChar is not (char)Keys.Back && e.KeyChar is not '.' && !char.IsNumber(e.KeyChar))
                    e.Handled = true;
            };

            CreativeInputAuthorsTextBox.KeyPress += (s, e) =>
            {
                if (e.KeyChar is not (char)Keys.Space && e.KeyChar is not (char)Keys.Back && !char.IsLetter(e.KeyChar))
                    e.Handled = true;
            };
        }
        private void DetectValidCharacter(ErrorProvider errorProvider, TextBox textBox)
        {
            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (textBox.Text[i] is '|' || textBox.Text[i] is ' ')
                    continue;
                if (!char.IsLetter(textBox.Text[i]))
                    errorProvider.SetError(textBox, "Введен недопустимый символ");
            }
        }
        private void DetectSeparator(ErrorProvider errorProvider, TextBox textBox, int countAuthor)
        {
            int counter = 0;
            for (int i = 0; i < textBox.Text.Length; i++)
                if (textBox.Text[i] is '|')
                    counter++;

            if (counter + 1 < countAuthor)
                errorProvider.SetError(textBox, "Вы забыли указать разделитель");
            else if (counter + 1 > countAuthor)
                errorProvider.SetError(textBox, "Вы указали больше разделителей чем необходимо");
        }
    }
}