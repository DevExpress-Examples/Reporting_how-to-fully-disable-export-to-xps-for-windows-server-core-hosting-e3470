<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595920/11.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3470)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


