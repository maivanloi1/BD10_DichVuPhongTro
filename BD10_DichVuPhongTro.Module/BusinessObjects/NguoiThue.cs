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
    [DefaultProperty("HoTen")]
    [System.ComponentModel.DisplayName("Người Thuê")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class NguoiThue : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public NguoiThue(Session session)
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


        private string _HoTen;
        [XafDisplayName("Họ Tên")]
        [Size(30)]
        public string HoTen
        {
            get { return _HoTen; }
            set { SetPropertyValue<string>(nameof(HoTen), ref _HoTen, value); }
        }


        private string _SDT;
        [XafDisplayName("Số ĐT"),Size(10)]
        public string SDT
        {
            get { return _SDT; }
            set { SetPropertyValue<string>(nameof(SDT), ref _SDT, value); }
        }


        private string _CCCD;
        [XafDisplayName("Căn Cước Công Dân"),Size(12)]
        public string CCCD
        {
            get { return _CCCD; }
            set { SetPropertyValue<string>(nameof(CCCD), ref _CCCD, value); }
        }


        private string _QueQuan;
        [XafDisplayName("Quê Quán"),Size(45)]
        public string QueQuan
        {
            get { return _QueQuan; }
            set { SetPropertyValue<string>(nameof(QueQuan), ref _QueQuan, value); }
        }

        [DevExpress.Xpo.Aggregated, Association("NT-HopDong")]
        public XPCollection<HopDong> HopDongs
        {
            get { return GetCollection<HopDong>(nameof(HopDongs)); }
        }


        [DevExpress.Xpo.Aggregated, Association("NT-GopY")]
        public XPCollection<GopY> GopYs
        {
            get { return GetCollection<GopY>(nameof(GopYs)); }
        }

    }
}