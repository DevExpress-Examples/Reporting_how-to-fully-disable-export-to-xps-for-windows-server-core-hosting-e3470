using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using DevExpress.Xpf.Printing.Service;
using DevExpress.XtraReports.Service;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Service.Native.Services;

namespace Q338316.Web {
    [SilverlightFaultBehavior]
    public class ReportService1 : DevExpress.XtraReports.Service.ReportService {
        public ReportService1() {
        }
    }
}
