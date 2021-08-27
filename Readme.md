<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595920/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3470)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


