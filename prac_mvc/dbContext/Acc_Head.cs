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
    
    public partial class Acc_Head
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Acc_Head()
        {
            this.Acc_SubHead = new HashSet<Acc_SubHead>();
        }
    
        public int Account_Code { get; set; }
        public string Account_Head { get; set; }
        public string Sl { get; set; }
        public string Dr_Cr { get; set; }
        public Nullable<decimal> MainCode { get; set; }
        public Nullable<decimal> PrjCode { get; set; }
        public string Affect_all_project { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acc_SubHead> Acc_SubHead { get; set; }
    }
}
