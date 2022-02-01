using DevExpress.Pdf;

namespace ExtractFirstPage {
    class Program {
        static void Main(string[] args) {

            using (PdfDocumentProcessor source = new PdfDocumentProcessor()) {
                source.LoadDocument("..\\..\\Document.pdf");
                using (PdfDocumentProcessor target = new PdfDocumentProcessor()) {
                    target.CreateEmptyDocument("..\\..\\ExtractedFirstPage.pdf");
                    target.Document.Pages.Add(source.Document.Pages[0]);
                }
            }
        }
    }
}