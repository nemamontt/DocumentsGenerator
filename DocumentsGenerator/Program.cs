using DocumentsGenerator.View;

namespace DocumentsGenerator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new DocumentsGeneratorMainView());
        }
    }
}