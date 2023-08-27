using DocumentsGenerator.ViewModel;
using DocumentsGenerator.View;
using DocumentsGenerator.StructResours;
using DocumentsGenerator.Model;

namespace DocumentsGenerator
{
    public partial class DocumentsGeneratorOneView : Form
    {
        private SubstitutionInDocument _subDoc;
        private DocumentsGeneratorOneViewModel? _vm;
        private DocumentsGeneratorTwoView? _docView;
        private DocumentsGeneratorMainView? _mv;
        public DocumentsGeneratorOneView(SubstitutionInDocument subDoc, bool selectedJsonFile, bool saveThisFile, bool saveOtherFile)
        {
            InitializeComponent();

            _subDoc = subDoc;

            ActiveControl = MainTableLayoutPanel;

            if (selectedJsonFile || saveThisFile)
            {

                for (int i = 0; i < subDoc.DateOfDisk.Length; i++)
                    if (subDoc.DateOfDisk[i] is ' ')
                        subDoc.DateOfDisk = subDoc.DateOfDisk.Remove(i, 3);

                var charsToRemove = new string[] { "-", "+", "(", ")", " " };
                foreach (var item in charsToRemove)
                    subDoc.NumberPhoneAddressee = subDoc.NumberPhoneAddressee.Replace(item, string.Empty);

                PONameTextBox.Text = subDoc.POName;
                CountAuthorNumericUpDown.Value = Convert.ToInt64(subDoc.CountAuthor);
                FIOApplicantComboBox.Text = subDoc.FIOApplicant;
                DateOfDiskTextBox.Text = subDoc.DateOfDisk;
                PositionOfSignatoryComboBox.Text = subDoc.PositionOfSignatory;
                DateOfSigningDateTimePicker.Text = subDoc.DateOfSigning;
                FIOAddresseeComboBox.Text = subDoc.FIOAddressee;
                NumberPhoneAddresseeComboBox.Text = subDoc.NumberPhoneAddressee;
                PostSigningSeparatelyComboBox.Text = subDoc.PostSigningSeparately;
                FIOSigningSeparatelyComboBox.Text = subDoc.FIOSigningSeparately;
                DateOfDiskComboBox.SelectedIndex = 0;
            }
            else if(!selectedJsonFile && !saveThisFile)
            {
                PositionOfSignatoryComboBox.SelectedIndex = 0;
                FIOApplicantComboBox.SelectedIndex = 0;
                DateOfDiskComboBox.SelectedIndex = 0;
                FIOAddresseeComboBox.SelectedIndex = 0;
                NumberPhoneAddresseeComboBox.SelectedIndex = 0;
                PostSigningSeparatelyComboBox.SelectedIndex = 0;
                FIOSigningSeparatelyComboBox.SelectedIndex = 0;
            }

            new ToolTip().SetToolTip(CountAuthorNumericUpDown, "�������� ����������� �������,\n��������: 4");
            new ToolTip().SetToolTip(FIOApplicantComboBox, "������� ��� �������� ��� ����, ��� ����� ����������� ���������,\n��������: ������ �.�.");
            new ToolTip().SetToolTip(DateOfSigningDateTimePicker, "�������� � ���� ���� ����, ����� ����� ������������ �� ������� ���� ����� ����������");
            new ToolTip().SetToolTip(PositionOfSignatoryComboBox, "�������� � ���� ���� ��������� ����, ������� ����� ����������� ���������");
            new ToolTip().SetToolTip(FIOAddresseeComboBox, "������� � ���� ���� ��� �������� � �������: ������ �.�.");
            new ToolTip().SetToolTip(NumberPhoneAddresseeComboBox, "������� � ���� ���� ����� �������� ��������");

            ReadyButton.Click += (sender, e) =>
            {
                try
                {
                    DocumentsGeneratorModel.CheckingEmptyElement(MainTableLayoutPanel.Controls);
                    if (DateOfDiskTextBox.Text == string.Empty || DateOfDiskComboBox.Text == string.Empty)
                        throw new Exception("��������� ���� \"���������� ����� �� �����\"");

                    _vm = new DocumentsGeneratorOneViewModel(PONameTextBox,
                        CountAuthorNumericUpDown, FIOApplicantComboBox,
                        DateOfDiskTextBox, PositionOfSignatoryComboBox, DateOfSigningDateTimePicker,
                        DateOfDiskComboBox, FIOAddresseeComboBox, NumberPhoneAddresseeComboBox,
                        PostSigningSeparatelyComboBox, FIOSigningSeparatelyComboBox, ref _subDoc);

                    DialogResult dialogResult = MessageBox.Show("�� ��������, ��� ������� ��� ���������?\n����� ����������� ������� �� ��������� �����", "����������",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _docView = new DocumentsGeneratorTwoView(_subDoc, selectedJsonFile, saveOtherFile, saveOtherFile);
                        _docView.Show();
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "����������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            BackButton.Click += (sender, e) =>
            {
                DialogResult dialogResult = MessageBox.Show("��������� ��������� ������?", "����������",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        DocumentsGeneratorModel.CheckingEmptyElement(MainTableLayoutPanel.Controls);
                        if (DateOfDiskTextBox.Text == string.Empty)
                            throw new Exception("��������� ���� \"���������� ����� �� �����\"");

                        _vm = new DocumentsGeneratorOneViewModel(PONameTextBox,
                            CountAuthorNumericUpDown, FIOApplicantComboBox,
                            DateOfDiskTextBox, PositionOfSignatoryComboBox, DateOfSigningDateTimePicker,
                            DateOfDiskComboBox, FIOAddresseeComboBox, NumberPhoneAddresseeComboBox,
                            PostSigningSeparatelyComboBox, FIOSigningSeparatelyComboBox, ref _subDoc);

                        _mv = new DocumentsGeneratorMainView(_subDoc, selectedJsonFile, saveOtherFile, true);
                        _mv.Show();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        DialogResult dialogResult2 = MessageBox.Show(ex.Message + "\n�� ����� ������ �������� �����? ������ ����� �� ���������", "����������",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult2 == DialogResult.Yes)
                        {
                            _mv = new DocumentsGeneratorMainView(_subDoc, selectedJsonFile, saveOtherFile, false);
                            _mv.Show();
                            Close();
                        }
                    }
                }
                else
                {
                    _mv = new DocumentsGeneratorMainView(_subDoc, selectedJsonFile, saveOtherFile, false);
                    _mv.Show();
                    Close();
                }
            };
        }
    }
}