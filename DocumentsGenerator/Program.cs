using DocumentsGenerator.StructResours;
using DocumentsGenerator.View;

namespace DocumentsGenerator
{
    internal static class Program
    {
        [STAThread]       
        static void Main()
        {           
            ApplicationConfiguration.Initialize();
            SubstitutionInDocument subDoc = new SubstitutionInDocument();
            Application.Run(new DocumentsGeneratorMainView(subDoc, false, false, false));
        }
    }
}