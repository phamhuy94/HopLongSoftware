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
    
    public partial class MANAGE_SALES_AND_CUSTOMERS
    {
        public int ID_QUAN_LY { get; set; }
        public string MA_KHACH_HANG { get; set; }
        public int NHAN_VIEN_PHU_TRACH { get; set; }
        public Nullable<System.DateTime> NGAY_BAT_DAU_PHU_TRACH { get; set; }
        public Nullable<System.DateTime> NGAY_NGUNG_PHU_TRACH { get; set; }
        public string LY_DO_NGUNG_PHU_TRACH { get; set; }
        public string GHI_CHU { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual USER USER { get; set; }
    }
}
