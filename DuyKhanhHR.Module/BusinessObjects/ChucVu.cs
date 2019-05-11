using DevExpress.ExpressApp.DC;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyKhanhHR.Module.BusinessObjects
{
    [Persistent(@"ChucVu")]
    [DefaultProperty("tenChucVu")]
    [XafDisplayName("Bộ Phận")]
    public class ChucVu : XPLiteObject
    {
        public ChucVu(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        int fId;
        [Key(true)]
        [XafDisplayName("STT")]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>("Id", ref fId, value); }
        }
        string fMaChucVu;
        [XafDisplayName("Mã Chức Vụ")]
        public string maChucVu
        {
            get { return fMaChucVu; }
            set { SetPropertyValue("maChucVu", ref fMaChucVu, value); }
        }
        string fTenChucVu;
        [XafDisplayName("Tên Chức Vụ")]
        public string tenChucVu
        {
            get { return fTenChucVu; }
            set { SetPropertyValue("tenChucVu", ref fTenChucVu, value); }
        }
        string fGhiChu;
        [XafDisplayName("Ghi Chú")]
        public string ghiChu
        {
            get { return fGhiChu; }
            set { SetPropertyValue("ghiChu", ref fGhiChu, value); }
        }
    }
}
