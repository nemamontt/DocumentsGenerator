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

            new ToolTip().SetToolTip(PONameTextBox, "������� ��������� ����� ���������\n��������: ��������� ������������ ����������� �������");
            new ToolTip().SetToolTip(CountAuthorTextBox, "������� ����������� �������,\n��������: 4");
            new ToolTip().SetToolTip(FIOAuthorTextBox, "������� ��� ������, ������� ����� ��������� ������");
            new ToolTip().SetToolTip(FIOApplicantTextBox, "������� ��� ����, ��� ����� ����������� ���������,\n��������: ������ �.�.");
            new ToolTip().SetToolTip(LocationTextBox, "������� ����� ���������� ������, �������� �� ������� ����,\n��������: �. ���������, ��. ��. �. ����������, �. 1/1, ��. 1, 350005, ���������� ���������");
            new ToolTip().SetToolTip(ContributionDescriptionTextBox, "������� ����� ������, �������� �� ������� ����,\n��������: ��������� ������������ ����");
            new ToolTip().SetToolTip(DateOfDiskTextBox, "������� � ��� ���� ���������� ����� ����� \"�� ����\"");
            new ToolTip().SetToolTip(AddresTextBox, "");
            new ToolTip().SetToolTip(DateOfBirthDateTimePicker, ""); //��������
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
                    MessageBox.Show("���������� ��������� ��� ����", "����������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            BackButton.Click += (sender, e) =>
            {
                DialogResult dialogResult = MessageBox.Show("�� �������, ��� ������ �������� ��� �����?\n������ ����� �� ���������", "����������",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                    Hide();
            };
        }
    }
}