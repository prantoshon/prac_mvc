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
    
    public partial class Incentive_Statement
    {
        public Nullable<System.DateTime> PDate { get; set; }
        public string VoucherNo { get; set; }
        public Nullable<decimal> VoucherNo_auto { get; set; }
        public string PYear { get; set; }
        public string EmpCodeNo { get; set; }
        public string SubAreaName { get; set; }
        public string EmpName { get; set; }
        public Nullable<decimal> Incentive_amt { get; set; }
        public Nullable<decimal> Account_Sub_SubCode { get; set; }
        public string Notes { get; set; }
        public string DBStatus { get; set; }
        public decimal AutoSL { get; set; }
    }
}
