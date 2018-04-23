Imports DevExpress.Pdf

Namespace ExtractDocumentPages
    Friend Class Program
        Shared Sub Main(ByVal args() As String)

            Using source As New PdfDocumentProcessor()
                source.LoadDocument("..\..\Document.pdf")
                For i As Integer = 0 To source.Document.Pages.Count - 1
                    Using target As New PdfDocumentProcessor()
                        target.CreateEmptyDocument("..\..\ExtractedPage" & (i + 1).ToString() & ".pdf")
                        target.Document.Pages.Add(source.Document.Pages(i))
                    End Using
                Next i
            End Using
        End Sub
    End Class
End Namespace
