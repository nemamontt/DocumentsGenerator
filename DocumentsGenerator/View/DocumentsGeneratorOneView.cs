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
        private Dictionary<ErrorProvider, ComboBox> _errorAndField;
        public DocumentsGeneratorOneView(SubstitutionInDocument subDoc, bool selectedJsonFile, bool saveThisFile, bool saveOtherFile)
        {
            InitializeComponent();

            _subDoc = subDoc;

            ActiveControl = MainTableLayoutPanel;

            _errorAndField = new Dictionary<ErrorProvider, ComboBox>()
            {
                {errorProvider2,PositionOfSignatoryComboBox},
                {errorProvider3,FIOApplicantComboBox},
                {errorProvider5,PostSigningSeparatelyComboBox},
                {errorProvider6,FIOSigningSeparatelyComboBox},
                {errorProvider7,FIOAddresseeComboBox},
                {errorProvider8,NumberPhoneAddresseeComboBox}
            };

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
            else if (!selectedJsonFile && !saveThisFile)
            {
                PositionOfSignatoryComboBox.SelectedIndex = 0;
                FIOApplicantComboBox.SelectedIndex = 0;
                DateOfDiskComboBox.SelectedIndex = 0;
                FIOAddresseeComboBox.SelectedIndex = 0;
                NumberPhoneAddresseeComboBox.SelectedIndex = 0;
                PostSigningSeparatelyComboBox.SelectedIndex = 0;
                FIOSigningSeparatelyComboBox.SelectedIndex = 0;
            }

            new ToolTip().SetToolTip(CountAuthorNumericUpDown, "�������� ����������� �������, ������: 4");
            new ToolTip().SetToolTip(FIOApplicantComboBox, "������� ��� �������� ��� ����, ��� ����� ����������� ���������,\n������: ������ �.�.");
            new ToolTip().SetToolTip(DateOfSigningDateTimePicker, "�������� � ���� ���� ����, ����� ����� ������������ �� ������� ���� ����� ����������");
            new ToolTip().SetToolTip(PositionOfSignatoryComboBox, "�������� � ���� ���� ��������� ����, ������� ����� ����������� ���������");
            new ToolTip().SetToolTip(FIOAddresseeComboBox, "������� � ���� ���� ��� �������� � �������: ������ �.�.");
            new ToolTip().SetToolTip(NumberPhoneAddresseeComboBox, "������� � ���� ���� ����� �������� ��������");

            ReadyButton.Click += (s, e) =>
            {
               foreach(var item in _errorAndField)
                    if (item.Key.GetError(item.Value) != string.Empty) return;  
               
               if(errorProvider1.GetError(PONameTextBox) != string.Empty || errorProvider4.GetError(DateOfDiskComboBox) != string.Empty) return;

                try
                {                    
                    DialogResult dialogResult = MessageBox.Show("�� �������, ��� ������� ��� ���������?\n����� ����������� ������� �� ��������� �����", "����������",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _vm = new DocumentsGeneratorOneViewModel(PONameTextBox,
                            CountAuthorNumericUpDown, FIOApplicantComboBox,
                            DateOfDiskTextBox, PositionOfSignatoryComboBox, DateOfSigningDateTimePicker,
                            DateOfDiskComboBox, FIOAddresseeComboBox, NumberPhoneAddresseeComboBox,
                            PostSigningSeparatelyComboBox, FIOSigningSeparatelyComboBox, ref _subDoc);

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

            BackButton.Click += (s, e) =>
            {
                DialogResult dialogResult = MessageBox.Show("��������� ��������� ������?", "����������",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
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

            PONameTextBox.Validating += (s, e) =>
            {
                if (string.IsNullOrEmpty(PONameTextBox.Text))
                {
                    errorProvider1.SetError(PONameTextBox, "��������� ����");
                }                                     
                else
                {
                    errorProvider1.Clear();
                }
                                        
            };

            PositionOfSignatoryComboBox.Validating += (s, e) =>
            {
                if (string.IsNullOrEmpty(PositionOfSignatoryComboBox.Text))
                    errorProvider2.SetError(PositionOfSignatoryComboBox, "��������� ����");
                else
                    errorProvider2.Clear();
            };

            FIOApplicantComboBox.Validating += (s, e) =>
            {
                if (string.IsNullOrEmpty(FIOApplicantComboBox.Text))
                    errorProvider3.SetError(FIOApplicantComboBox, "��������� ����");
                else if (!DocumentsGeneratorModel.NameVerification(FIOApplicantComboBox.Text, 2))
                    errorProvider3.SetError(FIOApplicantComboBox, "�������� ��������� ���� \"��� �������������� ���������\", ������: ������ �.�.");
                else
                    errorProvider3.Clear();
            };

            DateOfDiskTextBox.Validating += (s, e) =>
            {
                for (int i = 0; i < DateOfDiskTextBox.Text.Length; i++)
                    if (!char.IsNumber(DateOfDiskTextBox.Text[i]) || DateOfDiskTextBox.Text[i] is ' ')
                    {
                        errorProvider4.SetError(DateOfDiskTextBox, "������� ������ ����� ���������");
                        return;
                    }
                if (string.IsNullOrEmpty(DateOfDiskTextBox.Text))
                    errorProvider4.SetError(DateOfDiskTextBox, "��������� ����");
                else
                    errorProvider4.Clear();
            };

            PostSigningSeparatelyComboBox.Validating += (s, e) =>
            {
                if (string.IsNullOrEmpty(PostSigningSeparatelyComboBox.Text))
                    errorProvider5.SetError(PostSigningSeparatelyComboBox, "��������� ����");
                else
                    errorProvider5.Clear();
            };

            FIOSigningSeparatelyComboBox.Validating += (s, e) =>
            {
                if (string.IsNullOrEmpty(FIOSigningSeparatelyComboBox.Text))
                    errorProvider6.SetError(FIOSigningSeparatelyComboBox, "��������� ����");
                else if (!DocumentsGeneratorModel.NameVerification(FIOSigningSeparatelyComboBox.Text, 1))
                    errorProvider6.SetError(FIOSigningSeparatelyComboBox, "�������� ��������� ���� \"��� �������������� ��������� ���������\", ������: �.������");
                else
                    errorProvider6.Clear();
            };

            FIOAddresseeComboBox.Validating += (s, e) =>
            {
                if (string.IsNullOrEmpty(FIOAddresseeComboBox.Text))
                    errorProvider7.SetError(FIOAddresseeComboBox, "��������� ����");
                else if (!DocumentsGeneratorModel.NameVerification(FIOAddresseeComboBox.Text, 2))
                    errorProvider7.SetError(FIOAddresseeComboBox, "�������� ��������� ���� \"��� �������� ��� ���������\", ������: ������ �.�.");
                else
                    errorProvider7.Clear();
            };

            NumberPhoneAddresseeComboBox.Validating += (s, e) =>
            {
                for (int i = 0; i < NumberPhoneAddresseeComboBox.Text.Length; i++)
                    if (!char.IsNumber(NumberPhoneAddresseeComboBox.Text[i]) || NumberPhoneAddresseeComboBox.Text[i] is ' ')
                    {
                        errorProvider8.SetError(NumberPhoneAddresseeComboBox, "������� ������ ����� ��������");
                        return;
                    }
                if (string.IsNullOrEmpty(NumberPhoneAddresseeComboBox.Text))
                    errorProvider8.SetError(NumberPhoneAddresseeComboBox, "��������� ����");
                else if (NumberPhoneAddresseeComboBox.Text.Length is not 11)
                    errorProvider8.SetError(NumberPhoneAddresseeComboBox, "������� ������ ����� ��������");
                else
                    errorProvider8.Clear();
            };
        }
    }
}