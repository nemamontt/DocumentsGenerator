using DocumentsGenerator.StructResours;
using Microsoft.Office.Interop.Word;
using System.Text.Encodings.Web;
using System.Text.Json;
using Word = Microsoft.Office.Interop.Word;
using DocumentsGenerator.View;

namespace DocumentsGenerator.Model
{
    internal class DocumentsGeneratorModel
    {
        private SubstitutionInDocument _subDoc;
        private readonly string pathJsonDirectory = Path.Combine(AppContext.BaseDirectory + "JsonObjects");
        private readonly string pathReferenceDocuments = Path.Combine(AppContext.BaseDirectory + "ReferenceDocuments");
        private readonly string pathReadyMadeDocuments = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MadeDocuments");
        private readonly string _fileNameSNOshort = "_04-1_Согласие на обработку пользовательских данных";
        private readonly string _fileNameSNOlong = "_04-1_Согласие на обработку пользовательских данных.doc";
        private readonly string _fileNameSOAshort = "_05-1_Сведения об авторе";
        private readonly string _fileNameSOAlong = "_05-1_Сведения об авторе.doc";
        private Dictionary<string, string> _replacementTable;
        private List<string> _replacementTableSNO;
        private List<string> _replacementTableSOA;
        private Word.Application? wordapp = null;
        private ProgressView _progressView;

        public DocumentsGeneratorModel(ref SubstitutionInDocument subDoc, ProgressView progressView)
        {
          
            _subDoc = subDoc;
            _progressView = progressView;
            _progressView.Show();

            _replacementTable = new Dictionary<string, string>()
            {
                {"</CountAuthor>", _subDoc.CountAuthor},
                {"</POName>", _subDoc.POName},
                {"</DateOfDisk>", _subDoc.DateOfDisk},
                {"</FIOApplicant>", _subDoc.FIOApplicant},
                {"</DateOfSigning>", _subDoc.DateOfSigning},
                {"</YearСreationProgram>",_subDoc.YearCreationProgram},
                {"</DateOfBirthYear>", _subDoc.DateOfBirthYear},
                {"</DateOfBirtMonth>", _subDoc.DateOfBirtMonth},
                {"</DateOfBirtNumber>", _subDoc.DateOfBirtNumber},
                {"</ProgramAnnotation>", _subDoc.ProgramAnnotation},
                {"</TypeOfСomputer>",_subDoc.TypeOfComputer},
                {"</ProgramLanguage>",_subDoc.ProgramLanguage},
                {"</ProgramSize>",_subDoc.ProgramSize},
                {"</OperatingSystem>",_subDoc.OperatingSystem},
                {"</PositionOfSignatory>", _subDoc.PositionOfSignatory},
                {"</DateForDisk>",_subDoc.DateForDisk},
                {"</FullStringFioAuthors>",_subDoc.FullStringFioAuthors},
                {"</FIOAddressee>",_subDoc.FIOAddressee},
                {"</NumberPhone>",_subDoc.NumberPhoneAddressee},
                {"</PostSeparately>",_subDoc.PostSigningSeparately},
                {"</FIOSeparately>",_subDoc.FIOSigningSeparately},
                {"</FullNameTransfer>",_subDoc.FullNameTransfer},
                {"</FullStringShort>",_subDoc.FullStringShortFioAuthors}
            };

            for (int i = 0; i < int.Parse(_subDoc.CountAuthor); i++)
            {
                _replacementTable.Add($"</DateOfBirthAuthors>{i + 1}", _subDoc.DateOfBirthAuthors[i]);
                _replacementTable.Add($"</FioAuthors>{i + 1}", _subDoc.FioAuthors[i]);
                _replacementTable.Add($"</ContributionDescriptionAuthors>{i + 1}", _subDoc.ContributionDescriptionAuthors[i]);
                _replacementTable.Add($"</LocationAuthor>{i + 1}", _subDoc.LocationAuthor[i]);
                _replacementTable.Add($"</PassportDataAuthor>{i + 1}", _subDoc.PassportDataAuthor[i]);
                _replacementTable.Add($"</ShortFioAuthors>{i + 1}", _subDoc.ShortFioAuthors[i]);
            }

            _replacementTableSNO = new List<string>
            {
                "</FioAuthors>",                
                "</LocationAuthor>",
                "</PassportDataAuthor>",
                "</ShortFioAuthors>"
            };

            _replacementTableSOA = new List<string>
            {                             
                "</FioAuthors>",
                "</ShortFioAuthors>",
                "</ContributionDescriptionAuthors>",
                "</DateOfBirthAuthors>",
                "</LocationAuthor>"
            };
        }
        public void CreatJsonFile()
        {
            if (!Directory.Exists(pathJsonDirectory))
                Directory.CreateDirectory(pathJsonDirectory);

            string daneName = DateTime.Now.ToString();
            daneName = daneName.Replace(":", "-");

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            var pathJson = Path.Combine(pathJsonDirectory, daneName + " JsonObject.json");
            var json = JsonSerializer.Serialize(_subDoc, options);
            File.WriteAllText(pathJson, json);
        }
        public void CreateAllDocuments()
        {
            object wrap = WdFindWrap.wdFindContinue;
            object replace = WdReplace.wdReplaceAll;

            string daneName = DateTime.Now.ToString();
            daneName = daneName.Replace(":", "-");

            DirectoryInfo dirReference = new DirectoryInfo(pathReferenceDocuments);
            DirectoryInfo dirReady = new DirectoryInfo(pathReadyMadeDocuments + " " + daneName);
            Directory.CreateDirectory(dirReady.ToString());

            foreach (FileInfo file in dirReference.GetFiles())
                file.CopyTo(Path.Combine(dirReady.FullName, file.Name));

            File.Delete(Path.Combine(dirReady.FullName, _fileNameSNOlong));
            File.Delete(Path.Combine(dirReady.FullName, _fileNameSOAlong));

            CreatIndividualDocument(dirReference, dirReady, wrap, replace, _fileNameSNOlong, _fileNameSNOshort, _replacementTableSNO);
            CreatIndividualDocument(dirReference, dirReady, wrap, replace, _fileNameSOAlong, _fileNameSOAshort, _replacementTableSOA);
          
            foreach (var fileName in Directory.GetFiles(dirReady.FullName))
            {

                if (fileName == Path.Combine(dirReady.FullName, "Лицензия.pdf") || fileName == Path.Combine(dirReady.FullName, "Выписка из реестра.pdf"))
                    continue;

                wordapp = new Word.Application();
                wordapp.Documents.Open(fileName);
                
                foreach (var item in _replacementTable)
                {
                    Find find = wordapp.Selection.Find;
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
                _progressView.UploadingProgress();
            }
            _progressView.Close();
        }
        private void CreatIndividualDocument(DirectoryInfo dirReference, DirectoryInfo dirReady, object wrap, 
            object replace, string documentFullName, string documentShortName, List<string> replacementTable)
        {
            foreach (FileInfo file in dirReference.GetFiles())
                if (file.Name == documentFullName)
                    for (int i = 0; i < int.Parse(_subDoc.CountAuthor); i++)
                    {
                        if (i != int.Parse(_subDoc.CountAuthor))
                            file.CopyTo(Path.Combine(dirReady.FullName, $"{documentShortName} ({_subDoc.ShortFioAuthors[i]}).doc"));
                            
                        wordapp = new Word.Application();
                        wordapp.Documents.Open(Path.Combine(dirReady.FullName, $"{documentShortName} ({_subDoc.ShortFioAuthors[i]}).doc"));

                        foreach (var item in replacementTable)
                        {
                            Find find = wordapp.Selection.Find;
                            find.Text = item;
                            find.Replacement.Text = item + (i + 1).ToString();

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
                        _progressView.UploadingProgress();
                    }
        }
        public static string RemovingSpaces(string originalString)
        {
            if(string.IsNullOrEmpty(originalString)) 
                return originalString;

            string resultString = originalString;
            for (int i = 0; i < resultString.Length; i++)
            {
                if (resultString[0] == ' ')
                {
                    for (int j = 0; j < resultString.Length; j++)
                    {
                        if (resultString[j] != ' ')
                        {
                            resultString = resultString.Remove(0, j);
                            i = 0;
                            break;
                        }
                    }
                }
                if (resultString[i] == ' ')
                {
                    for (int j = i + 1; j < resultString.Length; j++)
                    {
                        if (resultString[j] != ' ')
                        {
                            resultString = resultString.Remove(i, j - i - 1);
                            break;
                        }
                    }
                    break;
                }
            }
            while (resultString[resultString.Length - 1] == ' ')
            {
                resultString = resultString.Remove(resultString.Length - 1, 1);
            }
            return resultString;
        }
        public static void CheckingEmptyElement(Control.ControlCollection controlCollectionFORM)
        {
            for (int i = 0; i < controlCollectionFORM.Count; i++)
            {
                if (controlCollectionFORM[i] is TextBox && controlCollectionFORM[i].Text == string.Empty)
                    throw new Exception($"Заполните поле \"{controlCollectionFORM[i].AccessibleDescription}\"");              
            }
            for (int i = 0; i < controlCollectionFORM.Count; i++)
            {
                if (controlCollectionFORM[i] is ComboBox && controlCollectionFORM[i].Text == string.Empty)
                    throw new Exception($"Заполните поле \"{controlCollectionFORM[i].AccessibleDescription}\"");
            }
        }
    }
}