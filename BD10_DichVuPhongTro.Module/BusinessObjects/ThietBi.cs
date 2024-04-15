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
    [System.ComponentModel.DisplayName("Thiết Bị")]
    [DefaultProperty("TenTB")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class ThietBi : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public ThietBi(Session session)
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


        private string _TenTB;
        [XafDisplayName("Tên Thiết Bị"),Size(20)]
        public string TenTB
        {
            get { return _TenTB; }
            set { SetPropertyValue<string>(nameof(TenTB), ref _TenTB, value); }
        }


        private PhongTro _PhongTros;
        [Association("PT-ThietBi")]
        [XafDisplayName("Của Phòng")]
        public PhongTro PhongTros
        {
            get { return _PhongTros; }
            set { SetPropertyValue<PhongTro>(nameof(PhongTros), ref _PhongTros, value); }
        }



        private decimal _Gia;
        [XafDisplayName("Giá")]
        [ModelDefault("DisplayFormat", "### ### ### ### VNĐ")]
        public decimal Gia
        {
            get { return _Gia; }
            set { SetPropertyValue<decimal>(nameof(Gia), ref _Gia, value); }
        }


        private DateTime _NgayMua;
        [XafDisplayName("Ngày Mua")]
        [ModelDefault("EditMask", "dd/MM/yyyy HH:mm")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime NgayMua
        {
            get { return _NgayMua; }
            set { SetPropertyValue<DateTime>(nameof(NgayMua), ref _NgayMua, value); }
        }


        private string _ThoiGianBH;
        [XafDisplayName("Thời Gian Bảo Hành"),Size(10)]
        public string ThoiGianBH
        {
            get { return _ThoiGianBH; }
            set { SetPropertyValue<string>(nameof(ThoiGianBH), ref _ThoiGianBH, value); }
        }


    }
}