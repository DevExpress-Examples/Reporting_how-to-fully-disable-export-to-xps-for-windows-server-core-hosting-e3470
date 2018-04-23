Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Printing.Service.Native.ServiceContainer
Imports DevExpress.Xpf.Printing.Service.Native.Services
Imports DevExpress.XtraReports.Service

Namespace E3470.Web
	Public Class [Global]
		Inherits System.Web.HttpApplication

		Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
			ReportService.StaticInitialize()
			DefaultContainer.Current.RegisterType(Of IFactoryService, CustomFactoryService)()
		End Sub

		Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
	End Class
End Namespace