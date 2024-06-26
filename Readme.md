<!-- default file list -->
*Files to look at*:

* [CustomFactoryService.cs](./CS/E3470.Web/CustomFactoryService.cs) (VB: [CustomFactoryService.vb](./VB/E3470.Web/CustomFactoryService.vb))
* [Global.asax.cs](./CS/E3470.Web/Global.asax.cs) (VB: [Global.asax.vb](./VB/E3470.Web/Global.asax.vb))
* [CustomReportPreviewModel.cs](./CS/E3470/CustomReportPreviewModel.cs) (VB: [CustomReportPreviewModel.vb](./VB/E3470/CustomReportPreviewModel.vb))
* [MainPage.xaml](./CS/E3470/MainPage.xaml) (VB: [MainPage.xaml](./VB/E3470/MainPage.xaml))
<!-- default file list end -->
# How to fully disable export to XPS (for Windows Server Core hosting)


<p>This example shows how you can disable the capability to export to the XPS format.</p><p>To disable this menu item on the client, substitute the <strong>ReportPreviewModel</strong> with a custom model. And on the server-side, override the <strong>SessionUtilityService</strong> for it to disable export to XPS (it will not be loaded in the WPF assembly).</p>

<br/>


