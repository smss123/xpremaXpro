//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xprema.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectExpens
    {
        public int ID { get; set; }
        public string ExpensesName { get; set; }
        public System.DateTime DateofProcess { get; set; }
        public string BillNumber { get; set; }
        public double RequiarAmount { get; set; }
        public string CashingNumber { get; set; }
    
        public virtual ProjectSubActivity ProjectSubActivity { get; set; }
        public virtual Account Account { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
