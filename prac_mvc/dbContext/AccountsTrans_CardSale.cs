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
    
    public partial class AccountsTrans_CardSale
    {
        public Nullable<System.DateTime> PDate { get; set; }
        public string VoucherNo { get; set; }
        public Nullable<decimal> PrjCode { get; set; }
        public Nullable<decimal> DrAmt { get; set; }
        public Nullable<decimal> CrCash { get; set; }
        public Nullable<decimal> CrCard { get; set; }
        public Nullable<decimal> CrAmt { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public string TransactionType { get; set; }
        public string Comments { get; set; }
        public string UserID { get; set; }
        public string AddDate { get; set; }
        public string EditDate { get; set; }
        public string ReceivedType { get; set; }
        public string TransferStatus { get; set; }
        public string Card_Company { get; set; }
        public string ClosingStatus { get; set; }
        public string Entry_Ref_No { get; set; }
        public decimal Auto_SLNo { get; set; }
    }
}