using DocumentsGenerator.WordsWorks;
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

            var postSigningSeparately1 = WordsWork.RemovingSpaces(postSigningSeparately.Text);
            for (int i = postSigningSeparately1.Length / 2; i < postSigningSeparately1.Length; i++)
                if (postSigningSeparately1[i] is ' ')
                {
                    postSigningSeparately1 = postSigningSeparately1.Insert(i, "^p");
                    postSigningSeparately.Text = postSigningSeparately1.Remove(i + 2, 1);
                    break;
                }

            var positionOfSignator = WordsWork.RemovingSpaces(positionOfSignatoryComboBox.Text);
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
            subDoc.DateForDisk = WordsWork.RemovingSpaces(dateForDisk);
            subDoc.POName = WordsWork.RemovingSpaces(poNameTextBox.Text);
            subDoc.FIOApplicant = WordsWork.RemovingSpaces(FIOApplicantComboBox.Text);
            subDoc.DateOfDisk = WordsWork.RemovingSpaces(dateOfDiskTextBox.Text + " " + dateOfDiskComboBox.Text);
            subDoc.YearCreationProgram = WordsWork.RemovingSpaces(yearCreationProgram);
            subDoc.PositionOfSignatory = WordsWork.RemovingSpaces(positionOfSignatoryComboBox.Text);
            subDoc.FIOAddressee = WordsWork.RemovingSpaces(fioAddressee.Text);            
            subDoc.PostSigningSeparately = WordsWork.RemovingSpaces(postSigningSeparately.Text);
            subDoc.FIOSigningSeparately = WordsWork.RemovingSpaces(fioSigningSeparately.Text);
        }
    }
}