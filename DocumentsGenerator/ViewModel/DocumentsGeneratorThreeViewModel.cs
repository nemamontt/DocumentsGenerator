using DocumentsGenerator.StructResours;

namespace DocumentsGenerator.ViewModel
{
    internal class DocumentsGeneratorThreeViewModel
    {
        public DocumentsGeneratorThreeViewModel(ref SubstitutionInDocument subDoc, TextBox programAnnotation, TextBox typeOfСomputer, 
            TextBox programLanguage, TextBox programSize, TextBox operatingSystem)
        {
            subDoc.ProgramAnnotation = programAnnotation.Text;
            subDoc.TypeOfСomputer = typeOfСomputer.Text;
            subDoc.ProgramLanguage = programLanguage.Text;
            subDoc.ProgramSize = programSize.Text;
            subDoc.OperatingSystem = operatingSystem.Text;
        }
    }
}
