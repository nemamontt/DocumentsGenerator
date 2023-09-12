using DocumentsGenerator.StructResours;
using DocumentsGenerator.WordsWorks;

namespace DocumentsGenerator.ViewModel
{
    public class DocumentsGeneratorThreeViewModel
    {
        public DocumentsGeneratorThreeViewModel(ref SubstitutionInDocument subDoc, TextBox programAnnotation, ComboBox typeOfСomputer,
            ComboBox programLanguage, TextBox programSize, ComboBox operatingSystem, ComboBox programSizeComboBox)
        {            
            subDoc.ProgramSize = programSize.Text + " " + programSizeComboBox.Text;
            subDoc.ProgramAnnotation = WordsWork.RemovingSpaces(programAnnotation.Text);
            subDoc.TypeOfComputer = WordsWork.RemovingSpaces(typeOfСomputer.Text);
            subDoc.ProgramLanguage = WordsWork.RemovingSpaces(programLanguage.Text);           
            subDoc.OperatingSystem = WordsWork.RemovingSpaces(operatingSystem.Text);
        }
    }
}