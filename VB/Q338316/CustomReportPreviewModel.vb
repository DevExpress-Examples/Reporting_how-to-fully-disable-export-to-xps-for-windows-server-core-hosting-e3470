Imports Microsoft.VisualBasic
Imports System
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraPrinting

Namespace Q338316
	Public Class CustomReportPreviewModel
		Inherits ReportPreviewModel
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
