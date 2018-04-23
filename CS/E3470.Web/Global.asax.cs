using System;
using DevExpress.Xpf.Printing.Service.Native.ServiceContainer;
using DevExpress.Xpf.Printing.Service.Native.Services;
using DevExpress.XtraReports.Service;

namespace E3470.Web {
    public class Global : System.Web.HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            ReportService.StaticInitialize();
            DefaultContainer.Current.RegisterType<IFactoryService, CustomFactoryService>();
        }

        protected void Session_Start(object sender, EventArgs e) {

        }

        protected void Application_BeginRequest(object sender, EventArgs e) {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_Error(object sender, EventArgs e) {

        }

        protected void Session_End(object sender, EventArgs e) {

        }

        protected void Application_End(object sender, EventArgs e) {

        }
    }
}