using DocumentsGenerator.Model;
using DocumentsGenerator.StructResours;
using System.Globalization;

namespace DocumentsGenerator.ViewModel
{
    internal class DocumentsGeneratorOneViewModel
    {
        public DocumentsGeneratorOneViewModel(TextBox poNameTextBox, NumericUpDown countAuthorTextBox, ComboBox FIOApplicantComboBox,
            TextBox dateOfDiskTextBox, ComboBox positionOfSignatoryComboBox, DateTimePicker dateOfSigningDateTimePicker, ComboBox dateOfDiskComboBox,
            ComboBox fioAddressee, ComboBox numberPhoneAddressee, ComboBox postSigningSeparately, ComboBox fioSigningSeparately, ref SubstitutionInDocument subDoc)
        {
            var cultureRu = CultureInfo.CreateSpecificCulture("ru-RU");
            cultureRu.DateTimeFormat.MonthNames = new string[] {"января","февраля","марта","апреля","мая","июня","июля","августа","сентября","октября","ноября","декабря",""};
            var fullNumberPhone = string.Format("{0:+# (###) ###-##-##}", Convert.ToInt64(numberPhoneAddressee.Text));
            var dateForDisk = dateOfSigningDateTimePicker.Value.ToString("dd/MM/yyyy");
            var dateSigning = dateOfSigningDateTimePicker.Value.ToString("MMMM yyyy", cultureRu);
            var yearCreationProgram = dateOfSigningDateTimePicker.Value.Year.ToString();

            var postSigningSeparately1 = DocumentsGeneratorModel.RemovingSpaces(postSigningSeparately.Text);
            for (int i = postSigningSeparately1.Length / 2; i < postSigningSeparately1.Length; i++)
                if (postSigningSeparately1[i] is ' ')
                {
                    postSigningSeparately1 = postSigningSeparately1.Insert(i, "^p");
                    postSigningSeparately.Text = postSigningSeparately1.Remove(i + 2, 1);
                    break;
                }

            var positionOfSignator = DocumentsGeneratorModel.RemovingSpaces(positionOfSignatoryComboBox.Text);
            for (int i = positionOfSignator.Length / 2; i < positionOfSignator.Length; i++)
                if (positionOfSignator[i] is ' ')
                {                   
                    positionOfSignator = positionOfSignator.Insert(i, "^p");
                    positionOfSignator = positionOfSignator.Remove(i + 2, 1);
                    positionOfSignatoryComboBox.Text = positionOfSignator;
                    break;
                }

            subDoc.DateOfSigning = dateSigning;
            subDoc.CountAuthor = countAuthorTextBox.Text;
            subDoc.NumberPhoneAddressee = fullNumberPhone;
            subDoc.DateForDisk = DocumentsGeneratorModel.RemovingSpaces(dateForDisk);
            subDoc.POName = DocumentsGeneratorModel.RemovingSpaces(poNameTextBox.Text);
            subDoc.FIOApplicant = DocumentsGeneratorModel.RemovingSpaces(FIOApplicantComboBox.Text);
            subDoc.DateOfDisk = DocumentsGeneratorModel.RemovingSpaces(dateOfDiskTextBox.Text + " " + dateOfDiskComboBox.Text);
            subDoc.YearCreationProgram = DocumentsGeneratorModel.RemovingSpaces(yearCreationProgram);
            subDoc.PositionOfSignatory = DocumentsGeneratorModel.RemovingSpaces(positionOfSignatoryComboBox.Text);
            subDoc.FIOAddressee = DocumentsGeneratorModel.RemovingSpaces(fioAddressee.Text);            
            subDoc.PostSigningSeparately = DocumentsGeneratorModel.RemovingSpaces(postSigningSeparately.Text);
            subDoc.FIOSigningSeparately = DocumentsGeneratorModel.RemovingSpaces(fioSigningSeparately.Text);
        }
    }
}