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
    
    public partial class Work_Order_Vs_Receipt
    {
        public Nullable<System.DateTime> PDate { get; set; }
        public string VoucherNo { get; set; }
        public Nullable<decimal> VoucherNo_auto { get; set; }
        public Nullable<decimal> PrjCode { get; set; }
        public string OrderNo { get; set; }
        public Nullable<decimal> Account_Sub_SubCode { get; set; }
        public string TransactionType { get; set; }
        public string Comments { get; set; }
        public string UserID { get; set; }
        public Nullable<decimal> Quantity_In { get; set; }
        public Nullable<decimal> Quantity_Out { get; set; }
        public string Materila_Desc { get; set; }
        public decimal Auto_SlNo { get; set; }
    }
}
