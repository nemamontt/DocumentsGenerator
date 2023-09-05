using DocumentsGenerator.Model;
using DocumentsGenerator.StructResours;

namespace DocumentsGenerator.ViewModel
{
    public class DocumentsGeneratorThreeViewModel
    {
        public DocumentsGeneratorThreeViewModel(ref SubstitutionInDocument subDoc, TextBox programAnnotation, ComboBox typeOfСomputer,
            ComboBox programLanguage, TextBox programSize, ComboBox operatingSystem, ComboBox programSizeComboBox)
        {            
            subDoc.ProgramSize = programSize.Text + " " + programSizeComboBox.Text;
            subDoc.ProgramAnnotation = DocumentsGeneratorModel.RemovingSpaces(programAnnotation.Text);
            subDoc.TypeOfComputer = DocumentsGeneratorModel.RemovingSpaces(typeOfСomputer.Text);
            subDoc.ProgramLanguage = DocumentsGeneratorModel.RemovingSpaces(programLanguage.Text);           
            subDoc.OperatingSystem = DocumentsGeneratorModel.RemovingSpaces(operatingSystem.Text);
        }
    }
}