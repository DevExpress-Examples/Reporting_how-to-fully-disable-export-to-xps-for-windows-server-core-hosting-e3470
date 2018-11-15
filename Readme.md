<!-- default file list -->
*Files to look at*:

* [CustomSessionUtilityService.cs](./CS/Q338316.Web/CustomSessionUtilityService.cs)
* [Global.asax.cs](./CS/Q338316.Web/Global.asax.cs) (VB: [Global.asax.vb](./VB/Q338316.Web/Global.asax.vb))
* [CustomReportPreviewModel.cs](./CS/Q338316/CustomReportPreviewModel.cs) (VB: [CustomReportPreviewModel.vb](./VB/Q338316/CustomReportPreviewModel.vb))
* [MainPage.xaml](./CS/Q338316/MainPage.xaml) (VB: [MainPage.xaml](./VB/Q338316/MainPage.xaml))
<!-- default file list end -->
# How to fully disable export to XPS (for Windows Server Core hosting)


<p>This example shows how you can disable the capability to export to the XPS format.</p><p>To disable this menu item on the client, substitute the <strong>ReportPreviewModel</strong> with a custom model. And on the server-side, override the <strong>SessionUtilityService</strong> for it to disable export to XPS (it will not be loaded in the WPF assembly).</p>

<br/>


