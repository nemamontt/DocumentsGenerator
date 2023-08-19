using DocumentsGenerator.StructResours;

namespace DocumentsGenerator.ViewModel
{
    internal class DocumentsGeneratorFourViewModel
    {
        public DocumentsGeneratorFourViewModel(ref SubstitutionInDocument subDoc, TextBox passportDetailsTextBox)
        {           
            string[] splitString = passportDetailsTextBox.Text.Split(new char[] { '|' });
            subDoc.PassportDataAuthor = new List<string>();
            subDoc.PassportDataAuthor.AddRange(splitString);
        }
    }
}
