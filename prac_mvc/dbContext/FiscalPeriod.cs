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
    
    public partial class FiscalPeriod
    {
        public int PeriodID { get; set; }
        public string FiscalID { get; set; }
        public string PeriodName { get; set; }
        public Nullable<System.DateTime> SDate { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
        public decimal AutoSLNO { get; set; }
    }
}
