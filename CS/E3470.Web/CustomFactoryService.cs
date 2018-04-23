using DevExpress.Xpf.Printing.Service.Native.Services;
using DevExpress.XtraPrinting;

namespace E3470.Web {
    public class CustomFactoryService : FactoryService {
        public CustomFactoryService(IIntegrityContainer container)
            : base(container) {
        }
        protected override void EnableXpsExport(PrintingSystemBase printingSystem) {
        }
    }
}