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
    
    public partial class AccountTrans_Budget_vs_Expenditure
    {
        public decimal Auto_SLNo { get; set; }
        public Nullable<System.DateTime> SDate { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
        public Nullable<decimal> PrjCode { get; set; }
        public decimal Account_Sub_SubCode { get; set; }
        public string TransactionType { get; set; }
        public Nullable<decimal> Budget_amt { get; set; }
        public Nullable<decimal> Expenditure_amt { get; set; }
    }
}
