//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SYSTEM_MANAGEMENT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PURCHASE_ORDER
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> NGAY_ORDER { get; set; }
        public string THOI_GIAN_YEU_CAU_CUA_KINH_DOANH { get; set; }
        public string MA_HANG_HT { get; set; }
        public string TINH_TRANG { get; set; }
        public Nullable<decimal> GIA_BAN { get; set; }
        public Nullable<decimal> GIA_NHAP { get; set; }
        public Nullable<decimal> CHENH_LECH { get; set; }
        public string MA_NHOM_HANG { get; set; }
        public Nullable<int> SL_NHAP { get; set; }
        public Nullable<int> SL_THUC_NHAN { get; set; }
        public Nullable<System.DateTime> NGAY_HANG_VE { get; set; }
        public int KINH_DOANH_BAN { get; set; }
        public string GHI_CHU { get; set; }
    
        public virtual PRODUCT_CATEGORIES PRODUCT_CATEGORIES { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }
        public virtual USER USER { get; set; }
    }
}
