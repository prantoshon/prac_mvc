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
    
    public partial class Inv_Sales_Quotation
    {
        public decimal Auto_SLNo { get; set; }
        public Nullable<System.DateTime> PDate { get; set; }
        public Nullable<decimal> PYear { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string PONo { get; set; }
        public string VoucherNo { get; set; }
        public Nullable<decimal> VoucherNo_auto { get; set; }
        public string BatchNo { get; set; }
        public Nullable<decimal> TransNo { get; set; }
        public Nullable<decimal> PrjCode { get; set; }
        public string GodownNo { get; set; }
        public Nullable<decimal> Account_Sub_SubCode { get; set; }
        public Nullable<decimal> Purchase_Sale_Acc_sub_subCode { get; set; }
        public string SubItemCode { get; set; }
        public Nullable<decimal> Estimate { get; set; }
        public Nullable<decimal> In_Item { get; set; }
        public Nullable<decimal> Out_Item { get; set; }
        public Nullable<decimal> BonusQnt { get; set; }
        public string Item_Entity { get; set; }
        public Nullable<decimal> Bal_Item { get; set; }
        public Nullable<decimal> Rate_Per_Item { get; set; }
        public string CurrancyCode { get; set; }
        public Nullable<decimal> Commision { get; set; }
        public Nullable<decimal> TotalCommision { get; set; }
        public Nullable<decimal> Total_amt { get; set; }
        public string TransactionType { get; set; }
        public string TransactionStatus { get; set; }
        public string Comments { get; set; }
        public string EmpCodeNo { get; set; }
        public string UserID { get; set; }
        public string ComputerName { get; set; }
        public string DO_VoucherNo { get; set; }
        public Nullable<System.DateTime> DO_Date { get; set; }
        public Nullable<decimal> VAT { get; set; }
        public Nullable<decimal> TotVAT { get; set; }
        public string Sales_by { get; set; }
        public string EditDate { get; set; }
        public string AddDate { get; set; }
        public string OrderNo { get; set; }
        public string Status { get; set; }
        public string DBStatus { get; set; }
        public string Entry_Ref_No { get; set; }
    }
}
