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
    
    public partial class MLC_PO
    {
        public Nullable<System.DateTime> PDate { get; set; }
        public string MLCNo { get; set; }
        public string PONo { get; set; }
        public Nullable<decimal> SubItemCode { get; set; }
        public Nullable<decimal> POQnt { get; set; }
        public Nullable<decimal> POUnitCost { get; set; }
        public Nullable<decimal> POTotCost { get; set; }
        public Nullable<System.DateTime> POLastDate { get; set; }
        public string PODesc { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Auto_SLNo { get; set; }
    }
}