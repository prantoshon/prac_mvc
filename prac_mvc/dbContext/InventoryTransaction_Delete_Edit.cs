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
    
    public partial class InventoryTransaction_Delete_Edit
    {
        public decimal Auto_SLNo { get; set; }
        public Nullable<System.DateTime> PDate { get; set; }
        public string VoucherNo { get; set; }
        public Nullable<decimal> PrjCode { get; set; }
        public Nullable<decimal> In_Item { get; set; }
        public Nullable<decimal> Out_Item { get; set; }
        public Nullable<decimal> Rate_Per_Item { get; set; }
        public string TransactionType { get; set; }
        public string Del_Edit_UserID { get; set; }
        public string ComputerName { get; set; }
        public string Del_Edit_Date_Time { get; set; }
        public string Status { get; set; }
    }
}