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
    
    public partial class volunteer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public volunteer()
        {
            this.eventOfVolunteer = new HashSet<eventOfVolunteer>();
            this.typeDisability = new HashSet<typeDisability>();
            this.volunteerHistory = new HashSet<volunteerHistory>();
            this.volunteerOfChild = new HashSet<volunteerOfChild>();
        }
    
        public int volunteerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public Nullable<int> age { get; set; }
        public string status { get; set; }
        public string mail { get; set; }
        public string formContact { get; set; }
        public string sax { get; set; }
        public Nullable<System.DateTime> dateEntryToSite { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eventOfVolunteer> eventOfVolunteer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<typeDisability> typeDisability { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<volunteerHistory> volunteerHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<volunteerOfChild> volunteerOfChild { get; set; }
    }
}
