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
    
    public partial class AccountsReport_Ledger
    {
        public Nullable<System.DateTime> PDate { get; set; }
        public string VoucherNo { get; set; }
        public Nullable<decimal> PrjCode { get; set; }
        public Nullable<decimal> Account_Sub_SubCode { get; set; }
        public Nullable<decimal> DrAmt { get; set; }
        public Nullable<decimal> CrAmt { get; set; }
        public string TransactionType { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> ChqDate { get; set; }
        public string ChqNo { get; set; }
        public decimal Sl { get; set; }
        public string DrCr { get; set; }
        public Nullable<decimal> LedgerCode { get; set; }
        public string DO_VoucherNo { get; set; }
    }
}
