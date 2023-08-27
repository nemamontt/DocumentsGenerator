using DocumentsGenerator.Model;
using DocumentsGenerator.StructResours;

namespace DocumentsGenerator.ViewModel
{
    internal class DocumentsGeneratorThreeViewModel
    {
        public DocumentsGeneratorThreeViewModel(ref SubstitutionInDocument subDoc, TextBox programAnnotation, ComboBox typeOfСomputer,
            ComboBox programLanguage, TextBox programSize, ComboBox operatingSystem, ComboBox programSizeComboBox)
        {
            for (int i = 0; i < programSize.Text.Length; i++)
                if (programSize.Text[i] is ' ')
                    throw new Exception("Неверно указан объем программы");

            subDoc.ProgramSize = programSize.Text + " " + programSizeComboBox.Text;
            subDoc.ProgramAnnotation = DocumentsGeneratorModel.RemovingSpaces(programAnnotation.Text);
            subDoc.TypeOfComputer = DocumentsGeneratorModel.RemovingSpaces(typeOfСomputer.Text);
            subDoc.ProgramLanguage = DocumentsGeneratorModel.RemovingSpaces(programLanguage.Text);           
            subDoc.OperatingSystem = DocumentsGeneratorModel.RemovingSpaces(operatingSystem.Text);
        }
    }
}
