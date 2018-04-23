Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.XtraReports.Service.Native.Services
Imports DevExpress.XtraPrinting

Namespace Q338316.Web
	Public Class CustomSessionUtilityService
		Inherits XRSessionUtilityService
		Protected Overrides Sub ConfigurePrintingSystem(ByVal ps As PrintingSystemBase)
		End Sub
	End Class
End Namespace