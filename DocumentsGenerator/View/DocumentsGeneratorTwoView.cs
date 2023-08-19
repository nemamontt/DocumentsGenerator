using DocumentsGenerator.StructResours;
using DocumentsGenerator.ViewModel;

namespace DocumentsGenerator.View
{
    internal partial class DocumentsGeneratorTwoView : Form
    {
        DocumentsGeneratorOneView? _oneView;
        DocumentsGeneratorThreeView? _threeView;
        DocumentsGeneratorTwoViewModel? _vm;
        private bool _flagActivate;
        private List<TextBox>? _textBoxes;

        public DocumentsGeneratorTwoView(SubstitutionInDocument subDoc)
        {
            InitializeComponent();

            new ToolTip().SetToolTip(FioOtherAuthorTextBox, "Введите в этом поле ФИО других авторов через разделитель,\nпример: Иванов Иван Иванович|Петров Петр Петрович");
            new ToolTip().SetToolTip(DateOfBirthOtherAuthorsTextBox, "Введите в этом поле день рождения других авторов через разделитель,\nпример: 01.01.2001|02.02.2002");
            new ToolTip().SetToolTip(LocationOtherAuthorTextBox, "Введите в этом поле место жительства других авторов через разделитель,\nпример: г. Краснодар, ул. им. А. Покрышкина, д. 4/9, кв. 205, 350005, Российская Федерация|\nг. Краснодар, ул. Кореновская, д. 71, кв. 21, 350005, Российская Федерация");
            new ToolTip().SetToolTip(CreativeInputOtherAuthorTextBox, "Введите в этом поле творческий вклад других авторов через разделитель,\nпример: Написание программного кода|Откладка программы");

            GoBackButton.Click += (sender, e) =>
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите покинуть эту форму?\nДанные будут не сохранены", "Информация",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    _oneView = new DocumentsGeneratorOneView();
                    _oneView.Show();
                    Hide();
                }             
            };

            ReadeButton.Click += (sender, e) =>
            {
                _textBoxes = new List<TextBox>()
                {
                    FioOtherAuthorTextBox,
                    DateOfBirthOtherAuthorsTextBox,
                    LocationOtherAuthorTextBox,
                    CreativeInputOtherAuthorTextBox
                };

                _flagActivate = false;

                foreach (var item in _textBoxes)
                    if (item is TextBox && item.Text == string.Empty)
                        _flagActivate = true;
               
                if (!_flagActivate)
                {
                    _vm = new DocumentsGeneratorTwoViewModel(ref subDoc, FioOtherAuthorTextBox, DateOfBirthOtherAuthorsTextBox,
                        LocationOtherAuthorTextBox, CreativeInputOtherAuthorTextBox);

                    _threeView = new DocumentsGeneratorThreeView(subDoc);
                    _threeView.Show();
                    Close();
                }
                else
                    MessageBox.Show("Пожалуйста заполните все поля", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
        }
    }
}
