<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595517/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T374804)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/ExtractFirstPage/Program.cs) (VB: [Program.vb](./VB/ExtractFirstPage/Program.vb))
<!-- default file list end -->
# How to extract pages from a document


This example shows how to extract pages from a document into a separate PDF document.


<h3>Description</h3>

To extract&nbsp;a first page from a document into a separate PDF document:<br><br>- create a target document with no pages using&nbsp;one of the<a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_CreateEmptyDocumenttopic"> PdfDocumentProcessor.CreateEmptyDocument</a> overloaded methods; <br>- add a first page to the target document using the<strong> PdfTargetDocument.Pages.Add</strong> method. To access a first source page in the <strong>PdfSourceDocument.Pages</strong> collection, use the zero page index.

<br/>


