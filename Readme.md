# How to extract pages from a document


This example shows how to extract pages from a document into a separate PDF document.


<h3>Description</h3>

To accomplish this task:<br>- create a target document&nbsp;with no pages for each source document page using the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_CreateEmptyDocumenttopic">PdfDocumentProcessor.CreateEmptyDocument&nbsp;</a> method,<br>- add a source document page to each target document using the <strong>PdfTargetDocument.Pages.Add</strong> method.&nbsp;To access an individual source page in the <strong>PdfSourceDocument.Pages&nbsp;</strong> collection, use the page index.

<br/>


