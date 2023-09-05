using Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using Word = Microsoft.Office.Interop.Word;

namespace OfficeProgrammingWalkthruComplete
{
    class Walkthrough
    {
        private Word.Documents worddocuments;
        private Word.Document worddocument;
        private Word.Application? wordapp;
        private Word.Paragraphs wordparagraphs;
        private Word.Paragraph wordparagraph;
        static void Main(string[] args)
        {
            Walkthrough a = new Walkthrough();
            a.CreateIconInWordDoc();
        }
        void CreateIconInWordDoc()
        {
            wordapp = new Word.Application();
            wordapp.Visible = true;
            Object template = Type.Missing;
            Object newTemplate = false;
            Object documentType = Word.WdNewDocumentType.wdNewBlankDocument;
            Object visible = true;
            Object filename = @"C:\МОЕ\1.docx";

            worddocument = wordapp.Documents.Open(ref filename);

            worddocuments = wordapp.Documents;

            wordparagraphs = worddocument.Paragraphs;

            Object start = 0;
            Object end = 0;
            Word.Range wordrange = worddocument.Range(ref start, ref end);
            Object defaultTableBehavior = WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehavior = WdAutoFitBehavior.wdAutoFitWindow;

            Table wordtable = worddocument.Tables.Add(wordrange, 5, 5, ref defaultTableBehavior, ref autoFitBehavior);
            Word.Range wordcellrange = worddocument.Tables[1].Cell(1, 1).Range;
            wordcellrange.Text = "ХУЙ";
        }
    }

}

            