using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.Printing;
using DevExpress.XtraPrinting;

namespace E3470 {
    public class CustomReportPreviewModel : ReportPreviewModel {
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
