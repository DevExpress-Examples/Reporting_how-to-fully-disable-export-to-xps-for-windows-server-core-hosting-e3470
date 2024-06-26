<!-- default file list -->
*Files to look at*:

* [CustomPrintingSystemFactory.cs](./CS/E3470.Web/CustomPrintingSystemFactory.cs)
* [Global.asax.cs](./CS/E3470.Web/Global.asax.cs)
* **[CustomReportServicePreviewModel.cs](./CS/E3470/CustomReportServicePreviewModel.cs)**
* [MainPage.xaml](./CS/E3470/MainPage.xaml)
<!-- default file list end -->
# How to fully disable export to XPS (for Windows Server Core hosting)


<p>This example shows how you can disable the capability to export to the XPS format.</p><p>To disable this menu item on the client, substitute the <strong>ReportPreviewModel</strong> with a custom model. And on the server-side, override the <strong>SessionUtilityService</strong> for it to disable export to XPS (it will not be loaded in the WPF assembly).</p>

<br/>


