//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prac_mvc.dbContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assets_Deprciation
    {
        public decimal SLNo { get; set; }
        public Nullable<decimal> VoucherNo { get; set; }
        public Nullable<System.DateTime> PDate { get; set; }
        public string Asset_ID { get; set; }
        public Nullable<decimal> DrAmt { get; set; }
        public Nullable<decimal> CrAmt { get; set; }
        public string Notes { get; set; }
    }
}