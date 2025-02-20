using DevExpress.Pdf;
using System.Diagnostics;

namespace ExtractDocumentPages
{
    class Program
    {
        static void Main(string[] args)
        {

            using (PdfDocumentProcessor source = new PdfDocumentProcessor())
            {
                source.LoadDocument("..\\..\\..\\Document.pdf");
                for (int i = 0; i < source.Document.Pages.Count; i++)
                {
                    using (PdfDocumentProcessor target = new PdfDocumentProcessor())
                    {
                        target.CreateEmptyDocument("..\\..\\ExtractedPage" + (i + 1).ToString() + ".pdf");
                        target.Document.Pages.Add(source.Document.Pages[i]);
                    }
                    using (PdfDocumentProcessor target1 = new PdfDocumentProcessor())
                    {
                        target1.CreateEmptyDocument("..\\..\\ExtractedFirstPage.pdf");
                        target1.Document.Pages.Add(source.Document.Pages[0]);
                    }

                }
                Process.Start(new ProcessStartInfo("explorer.exe", $"/select,\"{"..\\..\\ExtractedFirstPage.pdf"}\"") { UseShellExecute = true });
            }
        }
    }
}
