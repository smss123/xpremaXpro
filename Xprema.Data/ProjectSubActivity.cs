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
    
    public partial class ProjectSubActivity
    {
        public ProjectSubActivity()
        {
            this.ProjectExpens = new HashSet<ProjectExpens>();
        }
    
        public int ID { get; set; }
        public string SubActivityName { get; set; }
        public string Description { get; set; }
        public System.DateTime Startdate { get; set; }
        public System.DateTime enddate { get; set; }
        public string Status { get; set; }
        public int Persentage { get; set; }
        public string TotalCost { get; set; }
    
        public virtual ProjectActivity ProjectActivity { get; set; }
        public virtual ICollection<ProjectExpens> ProjectExpens { get; set; }
    }
}
