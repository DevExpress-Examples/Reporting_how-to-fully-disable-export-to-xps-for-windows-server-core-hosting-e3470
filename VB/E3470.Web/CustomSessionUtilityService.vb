Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.Service.Native.Services

Namespace E3470.Web
	Public Class CustomSessionUtilityService
		Inherits XRSessionUtilityService
		Protected Overrides Sub EnableXpsExport(ByVal printingSystem As PrintingSystemBase)
		End Sub
	End Class
End Namespace