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
    
    public partial class Monthly_Att_Statement
    {
        public string EmpCodeNo { get; set; }
        public Nullable<System.DateTime> PDate { get; set; }
        public string PMonth { get; set; }
        public Nullable<decimal> PYear { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> LateCome { get; set; }
        public Nullable<decimal> OnTime { get; set; }
        public Nullable<decimal> OT { get; set; }
        public Nullable<decimal> EL { get; set; }
        public Nullable<decimal> CL { get; set; }
        public Nullable<decimal> ML { get; set; }
        public Nullable<decimal> OL { get; set; }
        public Nullable<decimal> WP { get; set; }
        public Nullable<decimal> OD { get; set; }
        public decimal SlAuto { get; set; }
    }
}
