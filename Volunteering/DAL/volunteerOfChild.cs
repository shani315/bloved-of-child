//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class volunteerOfChild
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public volunteerOfChild()
        {
            this.volunteerHistory = new HashSet<volunteerHistory>();
        }
    
        public int volunteerOfChildID { get; set; }
        public Nullable<int> volunteerId { get; set; }
        public Nullable<int> childId { get; set; }
        public Nullable<System.TimeSpan> hour { get; set; }
        public Nullable<int> day { get; set; }
        public string details { get; set; }
        public string remarks { get; set; }
        public string status { get; set; }
    
        public virtual child child { get; set; }
        public virtual volunteer volunteer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<volunteerHistory> volunteerHistory { get; set; }
    }
}
