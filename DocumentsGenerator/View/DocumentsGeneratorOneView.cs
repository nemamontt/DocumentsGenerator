using DocumentsGenerator.ViewModel;
using DocumentsGenerator.View;

namespace DocumentsGenerator
{
    public partial class DocumentsGeneratorOneView : Form
    {
        private DocumentsGeneratorOneViewModel? _vm;
        private DocumentsGeneratorTwoView? _docView;
        private List<TextBox>? _textBoxes;
        private bool _flagActivate;
        public DocumentsGeneratorOneView()
        {
            InitializeComponent();

            new ToolTip().SetToolTip(PONameTextBox, "Введите названием своей программы\nнапример: Программа визуализации результатов анализа");
            new ToolTip().SetToolTip(CountAuthorTextBox, "Введите колличество авторов,\nнапример: 4");
            new ToolTip().SetToolTip(FIOAuthorTextBox, "Введите ФИО автора, который будет числиться первым");
            new ToolTip().SetToolTip(FIOApplicantTextBox, "Введите ФИО того, кто будет подписывать документы,\nнапример: Шпырня И.В.");
            new ToolTip().SetToolTip(LocationTextBox, "Введите место жительства автора, которого Вы указали выше,\nнапример: г. Краснодар, ул. им. А. Покрышкина, д. 1/1, кв. 1, 350005, Российская Федерация");
            new ToolTip().SetToolTip(ContributionDescriptionTextBox, "Введите вклад автора, которого Вы указали выше,\nнапример: Написание программного кода");
            new ToolTip().SetToolTip(DateOfDiskTextBox, "Введите в это поле занимаемое место папки \"На диск\"");
            new ToolTip().SetToolTip(AddresTextBox, "");
            new ToolTip().SetToolTip(DateOfBirthDateTimePicker, ""); //ДОПИСАТЬ
            new ToolTip().SetToolTip(DateOfSigningDateTimePicker, "");

            ReadyButton.Click += (sender, e) =>
            {
                _textBoxes = new List<TextBox>()
                {
                    PONameTextBox,
                    CountAuthorTextBox,
                    FIOAuthorTextBox,
                    FIOApplicantTextBox,
                    LocationTextBox,
                    ContributionDescriptionTextBox,
                    DateOfDiskTextBox,
                    AddresTextBox
                };

                _flagActivate = false;

                foreach (var item in _textBoxes)
                    if (item is TextBox && item.Text == string.Empty)
                        _flagActivate = true;

                if (!_flagActivate)
                {
                    _vm = new DocumentsGeneratorOneViewModel(PONameTextBox, CountAuthorTextBox,
                                         FIOAuthorTextBox, FIOApplicantTextBox, LocationTextBox,
                                         ContributionDescriptionTextBox, DateOfDiskTextBox, AddresTextBox,
                                         DateOfBirthDateTimePicker, DateOfSigningDateTimePicker);

                    _docView = new DocumentsGeneratorTwoView(_vm.SubDoc);
                    _docView.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Пожалуйста заполните все поля", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            BackButton.Click += (sender, e) =>
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите покинуть эту форму?\nДанные будут не сохранены", "Информация",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                    Hide();
            };
        }
    }
}