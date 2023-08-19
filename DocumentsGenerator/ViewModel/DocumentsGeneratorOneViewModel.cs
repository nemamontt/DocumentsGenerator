using DocumentsGenerator.StructResours;

namespace DocumentsGenerator.ViewModel
{
    internal class DocumentsGeneratorOneViewModel
    {
        public SubstitutionInDocument SubDoc;
        public DocumentsGeneratorOneViewModel(TextBox tbOne, TextBox tbTwo, TextBox tbThree,
            TextBox tbFour, TextBox tbFive, TextBox tbSix, TextBox tbSeven, TextBox tbEight,
            DateTimePicker dtpOne, DateTimePicker dtpTwo)
        {
            SubDoc = new SubstitutionInDocument();

            var dateOne = dtpOne.Value.ToString("dd/MM/yyyy");
            var dateTwo = dtpTwo.Value.ToString("MMMM/yyyy");
            dateTwo = dateTwo.Replace(".", " ");

            SubDoc.POName = tbOne.Text;
            SubDoc.CountAuthor = tbTwo.Text;
            SubDoc.FIOAuthor = tbThree.Text;
            SubDoc.FIOApplicant = tbFour.Text;
            SubDoc.Location = tbFive.Text;
            SubDoc.ContributionDescription = tbSix.Text;
            SubDoc.DateOfDisk = tbSeven.Text;
            SubDoc.Addres = tbEight.Text;
            SubDoc.DateOfBirth = dateOne;
            SubDoc.DateOfSigning = dateTwo;
            SubDoc.YearСreationProgram = dtpTwo.Value.Year.ToString();
            SubDoc.DateOfBirthYear = dtpOne.Value.Year.ToString();
            SubDoc.DateOfBirtNumber = dtpOne.Value.Day.ToString();
            SubDoc.DateOfBirtMonth = dtpOne.Value.Month.ToString();
        }
    }
}
