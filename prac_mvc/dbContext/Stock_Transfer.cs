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
    
    public partial class Stock_Transfer
    {
        public Nullable<System.DateTime> PDate { get; set; }
        public string VoucherNo { get; set; }
        public string SubItemCode { get; set; }
        public string SubItemName { get; set; }
        public Nullable<decimal> PrjCode_in { get; set; }
        public Nullable<decimal> PrjCode_out { get; set; }
        public Nullable<decimal> Qnty { get; set; }
        public Nullable<decimal> Rate_Per_Item { get; set; }
        public Nullable<decimal> Total_amt { get; set; }
        public string TransactionType { get; set; }
        public string Comments { get; set; }
        public string GodownNo { get; set; }
        public decimal AutoSLNo { get; set; }
    }
}
