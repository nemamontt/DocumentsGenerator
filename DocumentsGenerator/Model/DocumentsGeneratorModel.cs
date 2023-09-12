using DocumentsGenerator.StructResours;
using DocumentsGenerator.View;
using Microsoft.Office.Interop.Word;
using System.Text.Encodings.Web;
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
        private readonly string _fileNameSNOshort = "_04-1_Согласие на обработку пользовательских данных";
        private readonly string _fileNameSNOlong = "_04-1_Согласие на обработку пользовательских данных.doc";
        private readonly string _fileNameSOAshort = "_05-1_Сведения об авторе";
        private readonly string _fileNameSOAlong = "_05-1_Сведения об авторе.doc";
        private readonly string _fileNameDKZlong = "_02-1_Дополнение к заявлению (1 оборотный, 1 простой).doc";
        private Dictionary<string, string> _replacementTable;
        private List<string> _replacementTableSNO;
        private List<string> _replacementTableSOA;
        private List<string> _replacementTableDKZ;
        private Word.Application _wordapp;
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

            _replacementTableDKZ = new List<string>
            {
                "</FioAuthors>",
                "</DateOfBirthAuthors>",
                "</ContributionDescriptionAuthors>",
                "</LocationAuthor>"
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
            string daneName = DateTime.Now.ToString();
            daneName = daneName.Replace(":", "-");

            DirectoryInfo dirReference = new DirectoryInfo(pathReferenceDocuments);
            DirectoryInfo dirReady = new DirectoryInfo(pathReadyMadeDocuments + " " + daneName);
            Directory.CreateDirectory(dirReady.ToString());

            foreach (FileInfo file in dirReference.GetFiles())
                file.CopyTo(Path.Combine(dirReady.FullName, file.Name));

            File.Delete(Path.Combine(dirReady.FullName, _fileNameSNOlong));
            File.Delete(Path.Combine(dirReady.FullName, _fileNameSOAlong));

            if(Convert.ToInt32(_subDoc.CountAuthor) is 1)
                File.Delete(Path.Combine(dirReady.FullName, _fileNameDKZlong));
            else
                CreatDKZDocument(dirReady);

            //CreatIndividualDocument(dirReference, dirReady, _fileNameSNOlong, _fileNameSNOshort, _replacementTableSNO);
            //CreatIndividualDocument(dirReference, dirReady, _fileNameSOAlong, _fileNameSOAshort, _replacementTableSOA);


            //foreach (var fileName in Directory.GetFiles(dirReady.FullName))
            //{

            //    if (fileName == Path.Combine(dirReady.FullName, "Лицензия.pdf") || fileName == Path.Combine(dirReady.FullName, "Выписка из реестра.pdf"))
            //        continue;

            //    wordapp = new Word.Application();
            //    wordapp.Documents.Open(Path.Combine(dirReady.FullName, fileName));

            //    foreach (var item in _replacementTable)
            //    {
            //        Find find = wordapp.Selection.Find;
            //        find.Text = item.Key;
            //        find.Replacement.Text = item.Value;

            //        find.Execute(
            //            FindText: Type.Missing,
            //            MatchCase: false,
            //            MatchWholeWord: false,
            //            MatchWildcards: false,
            //            MatchSoundsLike: Type.Missing,
            //            MatchAllWordForms: false,
            //            Forward: true,
            //            Wrap: wrap,
            //            Format: false,
            //            ReplaceWith: Type.Missing,
            //            Replace: replace);
            //    }
            //    wordapp.ActiveDocument.SaveAs2();
            //    wordapp.ActiveDocument.Close();
            //    wordapp.Quit();
            //    _progressView.UploadingProgress();
            //}
            //_progressView.Close();
        }
        private void CreatIndividualDocument(DirectoryInfo dirReference, DirectoryInfo dirReady,
             string documentFullName, string documentShortName, List<string> replacementTable)
        {
            foreach (FileInfo file in dirReference.GetFiles())
                if (file.Name == documentFullName)
                    for (int i = 0; i < int.Parse(_subDoc.CountAuthor); i++)
                    {
                        if (i != int.Parse(_subDoc.CountAuthor))
                            file.CopyTo(Path.Combine(dirReady.FullName, $"{documentShortName} ({_subDoc.ShortFioAuthors[i]}).doc"));

                        _wordapp = new Word.Application();
                        _wordapp.Documents.Open(Path.Combine(dirReady.FullName, $"{documentShortName} ({_subDoc.ShortFioAuthors[i]}).doc"));

                        foreach (var item in replacementTable)
                        {
                            Find find = _wordapp.Selection.Find;
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
                                Wrap: WdFindWrap.wdFindContinue,
                                Format: false,
                                ReplaceWith: Type.Missing,
                                Replace: WdReplace.wdReplaceAll);
                        }
                        _wordapp.ActiveDocument.SaveAs2();
                        _wordapp.ActiveDocument.Close();
                        _wordapp.Quit();
                        _progressView.UploadingProgress();
                    }
        }
        private void CreatDKZDocument(DirectoryInfo dirReady)
        {
            _wordapp = new Word.Application();
            Document worddocument = _wordapp.Documents.Open(Path.Combine(dirReady.FullName, _fileNameDKZlong), ReadOnly: false);
            Table tableOne = worddocument.Tables[1];

            for (int i = 0; i < (int.Parse(_subDoc.CountAuthor) - 1) * 4; i++)
                tableOne.Rows.Add();

            int counter = 0;
            int prefics = 0;
            for (int i = 0; i < (int.Parse(_subDoc.CountAuthor) - 1) * 4; i++)
            {
                Word.Range range = tableOne.Cell(6 + counter, 1).Range;
                range.Copy();
                tableOne.Rows[6 + counter].Select();
                range = _wordapp.ActiveDocument.Tables[1].Cell(10 + counter, 1).Range;
                tableOne.Rows[10 + counter].Range.Paste();
                counter++;

                if (counter % 4 is 0)
                    prefics++;

                foreach (var item in _replacementTableDKZ)
                {
                    Find find = range.Find;
                    find.Text = item + (prefics + 2).ToString();
                    find.Replacement.Text = item + (prefics + 3).ToString();

                    find.Execute(
                        FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: Type.Missing,
                        MatchAllWordForms: false,
                        Forward: false,
                        Wrap: WdFindWrap.wdFindStop,
                        Format: false,
                        ReplaceWith: Type.Missing,
                        Replace: WdReplace.wdReplaceAll);
                } 
            }

            worddocument.Tables[1].Rows.HeightRule = WdRowHeightRule.wdRowHeightAuto;
            worddocument.Paragraphs[1].Format.LineSpacingRule = (WdLineSpacing)0.5;

            _wordapp.ActiveDocument.SaveAs2();
            _wordapp.ActiveDocument.Close();
            _wordapp.Quit();
            _progressView.UploadingProgress();
        }
    }
}