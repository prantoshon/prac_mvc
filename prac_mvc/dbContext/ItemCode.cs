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
    
    public partial class ItemCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemCode()
        {
            this.SubItemCodes = new HashSet<SubItemCode>();
        }
    
        public Nullable<decimal> PrjCode { get; set; }
        public decimal GrpSlNo { get; set; }
        public decimal ItemCode1 { get; set; }
        public string ItemName { get; set; }
        public Nullable<decimal> Commision { get; set; }
        public string Affect_all_project { get; set; }
    
        public virtual ItemGroup ItemGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubItemCode> SubItemCodes { get; set; }
    }
}
