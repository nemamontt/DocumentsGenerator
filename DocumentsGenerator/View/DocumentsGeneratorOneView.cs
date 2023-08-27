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

            new ToolTip().SetToolTip(CountAuthorNumericUpDown, "Выберите колличество авторов,\nнапример: 4");
            new ToolTip().SetToolTip(FIOApplicantComboBox, "Введите или выберите ФИО того, кто будет подписывать документы,\nнапример: Шпырня И.В.");
            new ToolTip().SetToolTip(DateOfSigningDateTimePicker, "Выберите в этом поле дату, когда будет предоставлен на подпись этот пакет документов");
            new ToolTip().SetToolTip(PositionOfSignatoryComboBox, "Выберите в этом поле должность лица, который будет подписывать документы");
            new ToolTip().SetToolTip(FIOAddresseeComboBox, "Укажите в этом поле ФИО адресата в формате: Иванов И.И.");
            new ToolTip().SetToolTip(NumberPhoneAddresseeComboBox, "Укажите в этом поле номер телефона адресата");

            ReadyButton.Click += (sender, e) =>
            {
                try
                {
                    DocumentsGeneratorModel.CheckingEmptyElement(MainTableLayoutPanel.Controls);
                    if (DateOfDiskTextBox.Text == string.Empty || DateOfDiskComboBox.Text == string.Empty)
                        throw new Exception("Заполните поле \"Занимаемое место на диске\"");

                    _vm = new DocumentsGeneratorOneViewModel(PONameTextBox,
                        CountAuthorNumericUpDown, FIOApplicantComboBox,
                        DateOfDiskTextBox, PositionOfSignatoryComboBox, DateOfSigningDateTimePicker,
                        DateOfDiskComboBox, FIOAddresseeComboBox, NumberPhoneAddresseeComboBox,
                        PostSigningSeparatelyComboBox, FIOSigningSeparatelyComboBox, ref _subDoc);

                    DialogResult dialogResult = MessageBox.Show("Вы увереныы, что указали все корректно?\nБудет осуществлен переход на следующую форму", "Информация",
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
                    MessageBox.Show(ex.Message, "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            BackButton.Click += (sender, e) =>
            {
                DialogResult dialogResult = MessageBox.Show("Сохранить введенные данные?", "Информация",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        DocumentsGeneratorModel.CheckingEmptyElement(MainTableLayoutPanel.Controls);
                        if (DateOfDiskTextBox.Text == string.Empty)
                            throw new Exception("Заполните поле \"Занимаемое место на диске\"");

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
                        DialogResult dialogResult2 = MessageBox.Show(ex.Message + "\nВы точно хотите покинуть форму? Данные будут не сохранены", "Информация",
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