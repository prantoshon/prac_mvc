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
    
    public partial class WorkingDay
    {
        public decimal Sl { get; set; }
        public Nullable<System.DateTime> WrkDate { get; set; }
        public string WrkTime { get; set; }
        public string ComputerName { get; set; }
        public string UserID { get; set; }
        public Nullable<decimal> PrjCode { get; set; }
    }
}
