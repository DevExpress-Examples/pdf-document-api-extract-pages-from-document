using DevExpress.Pdf;

namespace ExtractDocumentPages {
    class Program {
        static void Main(string[] args) {

            using(PdfDocumentProcessor source = new PdfDocumentProcessor()) {
                source.LoadDocument("..\\..\\Document.pdf");
                for(int i = 0; i < source.Document.Pages.Count; i++) {
                    using(PdfDocumentProcessor target = new PdfDocumentProcessor()) {
                        target.CreateEmptyDocument("..\\..\\ExtractedPage" + (i + 1).ToString() + ".pdf");
                        target.Document.Pages.Add(source.Document.Pages[i]);                      
                    }
                }
            }
        }
    }
}
