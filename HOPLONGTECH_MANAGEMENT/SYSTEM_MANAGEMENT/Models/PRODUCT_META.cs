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
    
    public partial class PRODUCT_META
    {
        public string MA_HANG_HT { get; set; }
        public Nullable<int> SL_1LOT { get; set; }
        public Nullable<int> SL_1THUNG { get; set; }
        public Nullable<int> SL_1PALLET { get; set; }
        public string THE_TICH_BOX { get; set; }
    
        public virtual PRODUCT PRODUCT { get; set; }
    }
}
