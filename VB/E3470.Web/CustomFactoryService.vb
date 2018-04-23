Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Printing.Service.Native.Services
Imports DevExpress.XtraPrinting

Namespace E3470.Web
	Public Class CustomFactoryService
		Inherits FactoryService
		Public Sub New(ByVal container As IIntegrityContainer)
			MyBase.New(container)
		End Sub
		Protected Overrides Sub EnableXpsExport(ByVal printingSystem As PrintingSystemBase)
		End Sub
	End Class
End Namespace