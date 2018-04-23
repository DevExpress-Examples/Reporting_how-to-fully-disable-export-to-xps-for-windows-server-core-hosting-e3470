using DevExpress.Xpf.Printing.Service.Native.Services.Factories;
using DevExpress.XtraPrinting;

namespace E3470.Web {
    public class CustomPrintingSystemFactory : PrintingSystemFactory {
        public CustomPrintingSystemFactory(IExportFactory exportFactory)
            : base(exportFactory) {
        }

        public override void EnableXpsExport(PrintingSystemBase printingSystem) {
        }
    }
}