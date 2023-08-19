using DocumentsGenerator.StructResours;
using System.Text.Json;
using Word = Microsoft.Office.Interop.Word;

namespace DocumentsGenerator.Model
{
    internal class DocumentsGeneratorModel
    {
        private SubstitutionInDocument _subDoc;
        private readonly string pathJsonDirectory = Path.Combine(AppContext.BaseDirectory + "JsonObjects");
        private readonly string pathReferenceDocuments = Path.Combine(AppContext.BaseDirectory + "ReferenceDocuments");
        private readonly string pathReadyMadeDocuments = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MadeDocuments");
        private Dictionary<string, string> _replacementTable;
        private Word.Application wordapp;

        public DocumentsGeneratorModel(ref SubstitutionInDocument subDoc)
        {
            _subDoc = subDoc;
        }

        public void CreatJsonFile()
        {
            if (!Directory.Exists(pathJsonDirectory))
                Directory.CreateDirectory(pathJsonDirectory);

            string daneName = DateTime.Now.ToString();
            daneName = daneName.Replace(":", "-");

            var options = new JsonSerializerOptions { WriteIndented = true };
            var pathJson = Path.Combine(pathJsonDirectory, daneName + " JsonObject.json");
            var json = JsonSerializer.Serialize(_subDoc, options);
            File.WriteAllText(pathJson, json);
        }
        public void CreateDocuments()
        { 
            _replacementTable = new Dictionary<string, string>()
            {
                {"</CountAuthor>", _subDoc.CountAuthor},
                {"</FIOAuthor>", _subDoc.FIOAuthor},
                {"</POName>", _subDoc.POName},
                {"</ContributionDescription>", _subDoc.ContributionDescription},
                {"</DateOfDisk>", _subDoc.DateOfDisk},
                {"</Location>", _subDoc.Location},
                {"</Addres>", _subDoc.Addres},
                {"</DateOfBirth>", _subDoc.DateOfBirth},
                {"</FIOApplicant>", _subDoc.FIOApplicant},
                {"</DateOfSigning>", _subDoc.DateOfSigning},
                {"</YearСreationProgram>",_subDoc.YearСreationProgram},
                {"</DateOfBirthYear>", _subDoc.DateOfBirthYear},
                {"</DateOfBirtMonth>", _subDoc.DateOfBirtMonth},
                {"</DateOfBirtNumber>", _subDoc.DateOfBirtNumber},
                {"</ProgramAnnotation>", _subDoc.ProgramAnnotation},
                {"</TypeOfСomputer>",_subDoc.TypeOfСomputer},
                {"</ProgramLanguage>",_subDoc.ProgramLanguage},
                {"</ProgramSize>",_subDoc.ProgramSize },
                {"</OperatingSystem>",_subDoc.OperatingSystem }
            };

            string daneName = DateTime.Now.ToString();
            daneName = daneName.Replace(":", "-");

            DirectoryInfo dirReference = new DirectoryInfo(pathReferenceDocuments);
            DirectoryInfo dirReady = new DirectoryInfo(pathReadyMadeDocuments + " " + daneName);
            Directory.CreateDirectory(dirReady.ToString());

            foreach (FileInfo file in dirReference.GetFiles())
                file.CopyTo(Path.Combine(dirReady.FullName, file.Name));

            object wrap = Word.WdFindWrap.wdFindContinue;
            object replace = Word.WdReplace.wdReplaceAll;

            foreach (var fileName in Directory.GetFiles(dirReady.FullName))
            {
                wordapp = new Word.Application();
                wordapp.Documents.Open(fileName);

                foreach (var item in _replacementTable)
                {
                    Word.Find find = wordapp.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    find.Execute(
                        FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: Type.Missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: Type.Missing,
                        Replace: replace);                   
                }
                wordapp.ActiveDocument.SaveAs2();
                wordapp.ActiveDocument.Close();
                wordapp.Quit();
            }          
        }
    }
}
