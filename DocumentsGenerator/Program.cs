using DocumentsGenerator.StructResours;
using DocumentsGenerator.View;

namespace DocumentsGenerator
{
    internal static class Program
    {
        [STAThread]       
        static void Main()
        {
            SubstitutionInDocument subDoc = new();
            ApplicationConfiguration.Initialize();           
            Application.Run(new DocumentsGeneratorMainView(subDoc, false, false, false));
        }
    }
}