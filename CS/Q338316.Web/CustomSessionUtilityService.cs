using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.XtraReports.Service.Native.Services;
using DevExpress.XtraPrinting;

namespace Q338316.Web {
    public class CustomSessionUtilityService : XRSessionUtilityService {
        protected override void ConfigurePrintingSystem(PrintingSystemBase ps) {
        }
    }
}