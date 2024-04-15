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
    [System.ComponentModel.DisplayName("Hợp Đồng")]
    [DefaultProperty("Ngay")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class HopDong : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public HopDong(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
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


        private DateTime _Ngay;
        [XafDisplayName("Ngày Hợp Đồng")]
        [ModelDefault("EditMask", "dd/MM/yyyy HH:mm")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime Ngay
        {
            get { return _Ngay; }
            set { SetPropertyValue<DateTime>(nameof(Ngay), ref _Ngay, value); }
        }


        private NguoiThue _NguoiThues;
        [XafDisplayName("Họ Tên Người Thuê")]
        [Association("NT-HopDong")]
        public NguoiThue NguoiThues
        {
            get { return _NguoiThues; }
            set { SetPropertyValue<NguoiThue>(nameof(NguoiThues), ref _NguoiThues, value); }
        }


        private Dien _Diens;
        [XafDisplayName("Ngày Thu Tiền Điện")]
        [Association]
        public Dien Diens
        {
            get { return _Diens; }
            set { SetPropertyValue<Dien>(nameof(Diens), ref _Diens, value); }
        }


        private Nuoc _Nuocs;
        [XafDisplayName("Ngày Thu Tiền Nước")]
        [Association]
        public Nuoc Nuocs
        {
            get { return _Nuocs; }
            set { SetPropertyValue<Nuoc>(nameof(Nuocs), ref _Nuocs, value); }
        }


        private KhaiBao _KhaiBaos;
        [XafDisplayName("Loại Khai Báo")]
        [Association]
        public KhaiBao KhaiBaos
        {
            get { return _KhaiBaos; }
            set { SetPropertyValue<KhaiBao>(nameof(KhaiBaos), ref _KhaiBaos, value); }
        }


        private PhongTro _PhongTros;
        [XafDisplayName("Phòng Số")]
        [Association("PT-HopDong")]
        public PhongTro PhongTros
        {
            get { return _PhongTros; }
            set { SetPropertyValue<PhongTro>(nameof(PhongTros), ref _PhongTros, value); }
        }


        private PhieuThu _PhieuThus;
        [XafDisplayName("Phiếu Thu")]
        [Association]
        public PhieuThu PhieuThus
        {
            get { return _PhieuThus; }
            set { SetPropertyValue<PhieuThu>(nameof(PhieuThus), ref _PhieuThus, value); }
        }


        private PhieuChi _PhieuChis;
        [XafDisplayName("Phiếu Chi")]
        [Association]
        public PhieuChi PhieuChis
        {
            get { return _PhieuChis; }
            set { SetPropertyValue<PhieuChi>(nameof(PhieuChis), ref _PhieuChis, value); }
        }



    }
}