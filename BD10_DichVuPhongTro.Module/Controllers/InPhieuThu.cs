using BD10_DichVuPhongTro.Module.BusinessObjects;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Persistent.BaseImpl;

namespace BD10_DichVuPhongTro.Blazor.Server.Controllers
{
    public abstract class InPhieuThu : ViewController
    {
        public InPhieuThu()
        {
            TargetObjectType = typeof(PhieuThu);
            SimpleAction inphieuthu = new(this, "inphieuthu", "View")
            {
                Caption = "In Phiếu",
                ImageName = "",
                ToolTip = "In Phiếu Thu",
                TargetObjectType = typeof(PhieuThu),
                ConfirmationMessage = "Có Chắc Chắn In Không?"
            };
            inphieuthu.Execute += Inphieuthu_Execute;
        }

        private void Inphieuthu_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            if (View.CurrentObject is PhieuThu p)
            {
                string ChungTuID = p.Oid.ToString();
                if (!string.IsNullOrEmpty(ChungTuID))
                {
                    IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(ReportDataV2));
                    IReportDataV2 reportData = objectSpace.FindObject<ReportDataV2>(
                        new BinaryOperator("DisplayName", "pthu"));
                    if (reportData != null)
                    {
                        PrintReport(reportData, Guid.Parse(ChungTuID));
                    }
                }
            }
        }

        protected abstract void PrintReport(IReportDataV2 reportData, Guid guid);
    }
}
