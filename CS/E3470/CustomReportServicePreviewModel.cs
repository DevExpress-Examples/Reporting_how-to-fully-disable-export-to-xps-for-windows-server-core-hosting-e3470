using DevExpress.Xpf.Printing;

namespace E3470 {
    public class CustomReportServicePreviewModel : ReportServicePreviewModel {
        const string XpsExportFormat = "Xps";

        protected override bool CanExport(object parameter) {
            if((string)parameter == XpsExportFormat)
                return false;
            return base.CanExport(parameter);
        }

        protected override bool CanExportToWindow(object parameter) {
            if((string)parameter == XpsExportFormat)
                return false;
            return base.CanExportToWindow(parameter);
        }
    }
}
