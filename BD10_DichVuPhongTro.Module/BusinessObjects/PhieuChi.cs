using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BD10_DichVuPhongTro.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("BO_Contact")]
    [System.ComponentModel.DisplayName("Phiếu Chi")]
    [DefaultProperty("SoCT")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class PhieuChi : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public PhieuChi(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {

            base.AfterConstruction();
            if (Session.IsNewObject(this)) { Ngay = DateTime.Now; }

            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}


        private string _SoCT;
        [XafDisplayName("Số Chứng Từ"), Size(45)]
        [RuleRequiredField("Yêu Cầu SoCT", DefaultContexts.Save, "Phải Nhập Số Chứng Từ")]
        [RuleUniqueValue, Indexed(Unique = true)]
        public string SoCT
        {
            get { return _SoCT; }
            set { SetPropertyValue<string>(nameof(SoCT), ref _SoCT, value); }
        }


        private DateTime _Ngay;
        [ModelDefault("EditMask", "dd/MM/yyyy HH:mm")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        [XafDisplayName("Ngày Thu")]
        public DateTime Ngay
        {
            get { return _Ngay; }
            set { SetPropertyValue<DateTime>(nameof(Ngay), ref _Ngay, value); }
        }


        private decimal _TongTien;
        [XafDisplayName("Tổng Tiền")]
        [ModelDefault("DisplayFormat", "### ### ### ### VNĐ")]
        public decimal TongTien
        {
            get { return _TongTien; }
            set { SetPropertyValue<decimal>(nameof(TongTien), ref _TongTien, value); }
        }


        private string _NoiDung;
        [XafDisplayName("Nội Dung"),Size(30)]
        public string NoiDung
        {
            get { return _NoiDung; }
            set { SetPropertyValue<string>(nameof(NoiDung), ref _NoiDung, value); }
        }

        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<HopDong> HopDongs
        {
            get { return GetCollection<HopDong>(nameof(HopDongs)); }
        }
    }
}