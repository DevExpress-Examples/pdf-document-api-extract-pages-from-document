# How to extract pages from a document


This example shows how to extract pages from a document into a separate PDF document.


<h3>Description</h3>

To extract&nbsp;a first page from a document into a separate PDF document:<br><br>- create a target document with no pages using&nbsp;one of the<a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_CreateEmptyDocumenttopic"> PdfDocumentProcessor.CreateEmptyDocument</a> overloaded methods; <br>- add a first page to the target document using the<strong> PdfTargetDocument.Pages.Add</strong> method. To access a first source page in the <strong>PdfSourceDocument.Pages</strong> collection, use the zero page index.

<br/>


