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
    
    public partial class working_progress
    {
        public Nullable<decimal> PrjCode { get; set; }
        public string OrderNo { get; set; }
        public Nullable<decimal> DrAmt { get; set; }
        public decimal Target_Qnt { get; set; }
        public Nullable<decimal> FinishGoods { get; set; }
        public Nullable<decimal> Workin_Progress_Qnt { get; set; }
        public Nullable<decimal> FinishGoods_Cost { get; set; }
        public Nullable<decimal> Workin_Progress_atm { get; set; }
    }
}