Imports DevExpress.Pdf
Imports System.Diagnostics

Namespace ExtractDocumentPages

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using source As PdfDocumentProcessor = New PdfDocumentProcessor()
                source.LoadDocument("..\..\..\Document.pdf")
                For i As Integer = 0 To source.Document.Pages.Count - 1
                    Using target As PdfDocumentProcessor = New PdfDocumentProcessor()
                        target.CreateEmptyDocument("..\..\ExtractedPage" & (i + 1).ToString() & ".pdf")
                        target.Document.Pages.Add(source.Document.Pages(i))
                    End Using

                    Using target1 As PdfDocumentProcessor = New PdfDocumentProcessor()
                        target1.CreateEmptyDocument("..\..\ExtractedFirstPage.pdf")
                        target1.Document.Pages.Add(source.Document.Pages(0))
                    End Using
                Next

                Process.Start(New ProcessStartInfo("explorer.exe", $"/select,""{"..\..\ExtractedFirstPage.pdf"}""") With {.UseShellExecute = True})
            End Using
        End Sub
    End Class
End Namespace
