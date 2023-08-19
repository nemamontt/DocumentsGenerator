using DocumentsGenerator.StructResours;

namespace DocumentsGenerator.ViewModel
{
    internal class DocumentsGeneratorTwoViewModel
    {
        public DocumentsGeneratorTwoViewModel(ref SubstitutionInDocument subDoc, TextBox fioOtherAuthorTextBox, TextBox dateOfBirthOtherAuthorsTextBox, 
            TextBox locationOtherAuthorTextBox, TextBox creativeInputOtherAuthorTextBox)
        {
            string[] splitStringFIO = fioOtherAuthorTextBox.Text.Split(new char[] { '|' });
            string[] splitStringDateOfBirth = dateOfBirthOtherAuthorsTextBox.Text.Split(new char[] { '|' });
            string[] splitStringLocation = locationOtherAuthorTextBox.Text.Split(new char[] { '|' });
            string[] splitStringCreativeInput = creativeInputOtherAuthorTextBox.Text.Split(new char[] { '|' });

            subDoc.FioOtherAuthors = new List<string>();
            subDoc.DateOfBirthOtherAuthors = new List<string>();
            subDoc.LocationOtherAuthor = new List<string>();
            subDoc.ContributionDescriptionOtherAuthors = new List<string>();

            subDoc.FioOtherAuthors.AddRange(splitStringFIO);
            subDoc.DateOfBirthOtherAuthors.AddRange(splitStringDateOfBirth);
            subDoc.LocationOtherAuthor.AddRange(splitStringLocation);
            subDoc.ContributionDescriptionOtherAuthors.AddRange(splitStringCreativeInput);
        }
    }
}
