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
    
    public partial class Acc_Sub_SubHead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Acc_Sub_SubHead()
        {
            this.AccountsTransactions = new HashSet<AccountsTransaction>();
        }
    
        public Nullable<decimal> Account_SubCode { get; set; }
        public decimal Account_Sub_SubCode { get; set; }
        public string Acc_Name { get; set; }
        public Nullable<decimal> Opening_bal { get; set; }
        public string Address { get; set; }
        public string Currency { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string MobileNo { get; set; }
        public string Fax { get; set; }
        public string SMS { get; set; }
        public string EMail { get; set; }
        public string Comments { get; set; }
        public string SubLedger { get; set; }
        public string Dr_Cr { get; set; }
        public string DBType { get; set; }
        public decimal AutoSL { get; set; }
        public string BillWise { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public Nullable<decimal> EmpSalary { get; set; }
        public string SalaryStatus { get; set; }
        public string GrpName { get; set; }
        public Nullable<decimal> PrjCode { get; set; }
        public string Affect_all_project { get; set; }
        public string Acc_Name_Bangla { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountsTransaction> AccountsTransactions { get; set; }
    }
}
