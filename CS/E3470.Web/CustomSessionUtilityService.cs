using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Service.Native.Services;

namespace E3470.Web {
    public class CustomSessionUtilityService : XRSessionUtilityService {
        protected override void EnableXpsExport(PrintingSystemBase printingSystem) {
        }
    }
}