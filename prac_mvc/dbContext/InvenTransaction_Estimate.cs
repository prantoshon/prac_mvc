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
    
    public partial class InvenTransaction_Estimate
    {
        public decimal Auto_SLNo { get; set; }
        public Nullable<System.DateTime> SDate { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
        public Nullable<decimal> VoucherNo { get; set; }
        public Nullable<decimal> TransNo { get; set; }
        public Nullable<decimal> PrjCode { get; set; }
        public string SubItemCode { get; set; }
        public Nullable<decimal> In_Item { get; set; }
        public Nullable<decimal> Out_Item { get; set; }
        public Nullable<decimal> Rate_Per_Item { get; set; }
        public Nullable<decimal> Total_amt { get; set; }
        public string TransactionType { get; set; }
        public string Comments { get; set; }
        public string UserID { get; set; }
        public string UserID_Edit { get; set; }
        public string ComputerName { get; set; }
        public string EditDate { get; set; }
        public string AddDate { get; set; }
    }
}
