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
    
    public partial class Supplier
    {
        public Supplier()
        {
            this.ProjectExpens = new HashSet<ProjectExpens>();
        }
    
        public int ID { get; set; }
        public string name { get; set; }
        public string PhoneNumber { get; set; }
        public string SuppliersNatural { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Adderss { get; set; }
    
        public virtual ICollection<ProjectExpens> ProjectExpens { get; set; }
    }
}
