# How to fully disable export to XPS (for Windows Server Core hosting)


<p>This example shows how you can disable the capability to export to the XPS format.</p><p>To disable this menu item on the client, substitute the <strong>ReportPreviewModel</strong> with a custom model. And on the server-side, override the <strong>SessionUtilityService</strong> for it to disable export to XPS (it will not be loaded in the WPF assembly).</p>

<br/>


