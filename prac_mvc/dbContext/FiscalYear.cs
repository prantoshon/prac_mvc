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
    
    public partial class FiscalYear
    {
        public string FiscalID { get; set; }
        public string FiscalName { get; set; }
        public Nullable<System.DateTime> SDate { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
        public string Status { get; set; }
    }
}