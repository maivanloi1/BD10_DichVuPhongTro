using DevExpress.ExpressApp.ReportsV2;
using DevExpress.XtraReports.Wizards;

namespace BD10_DichVuPhongTro.Blazor.Server.Controllers
{
    public class BlazorlnCT : InPhieuThu
    {
        protected override void PrintReport(IReportDataV2 reportData, Guid guid)
        {
            ReportsModuleV2 reportsModule = ReportsModuleV2.FindReportsModule(Application.Modules);
            if(reportsModule != null && reportsModule.ReportsDataSourceHelper != null) 
            {
                reportsModule.ReportsDataSourceHelper.BeforeShowPreview += (s, args) =>
                {
                    args.Report.Parameters["MaPhieu"].Value = guid;
                };
                string handle = ReportDataProvider.ReportsStorage.GetReportContainerHandle(reportData);
                ReportServiceController controller = Frame.GetController<ReportServiceController>();
                controller.ShowPreview(handle);
            }
        }
    }
}
