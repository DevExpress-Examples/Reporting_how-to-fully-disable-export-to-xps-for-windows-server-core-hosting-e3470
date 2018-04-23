Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Printing

Namespace E3470
	Public Class CustomReportServicePreviewModel
		Inherits ReportServicePreviewModel
		Private Const XpsExportFormat As String = "Xps"

		Protected Overrides Function CanExport(ByVal parameter As Object) As Boolean
			If CStr(parameter) = XpsExportFormat Then
				Return False
			End If
			Return MyBase.CanExport(parameter)
		End Function

		Protected Overrides Function CanExportToWindow(ByVal parameter As Object) As Boolean
			If CStr(parameter) = XpsExportFormat Then
				Return False
			End If
			Return MyBase.CanExportToWindow(parameter)
		End Function
	End Class
End Namespace
