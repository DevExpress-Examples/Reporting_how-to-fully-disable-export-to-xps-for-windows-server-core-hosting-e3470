Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Printing.Service.Native.Services.Factories
Imports DevExpress.XtraPrinting

Namespace E3470.Web
	Public Class CustomPrintingSystemFactory
		Inherits PrintingSystemFactory
		Public Sub New(ByVal exportFactory As IExportFactory)
			MyBase.New(exportFactory)
		End Sub

		Public Overrides Sub EnableXpsExport(ByVal printingSystem As PrintingSystemBase)
		End Sub
	End Class
End Namespace