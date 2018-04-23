Imports DevExpress.Pdf

Namespace ExtractFirstPage
    Friend Class Program
        Shared Sub Main(ByVal args() As String)

            Using source As New PdfDocumentProcessor()
                source.LoadDocument("..\..\Document.pdf")
                Using target As New PdfDocumentProcessor()
                    target.CreateEmptyDocument("..\..\ExtractedFirstPage.pdf")
                    target.Document.Pages.Add(source.Document.Pages(0))
                End Using
            End Using
        End Sub
    End Class
End Namespace