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
    
    public partial class eventsVolunteer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public eventsVolunteer()
        {
            this.eventOfVolunteer = new HashSet<eventOfVolunteer>();
        }
    
        public int eventsVolunteerID { get; set; }
        public string responsibleSecretary { get; set; }
        public string place { get; set; }
        public string typeEvent { get; set; }
        public Nullable<System.DateTime> dateEvent { get; set; }
        public Nullable<int> maxCountParticipants { get; set; }
        public Nullable<int> countParticipants { get; set; }
        public Nullable<int> minVolunteers { get; set; }
        public string description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eventOfVolunteer> eventOfVolunteer { get; set; }
        public virtual eventsVolunteer eventsVolunteer1 { get; set; }
        public virtual eventsVolunteer eventsVolunteer2 { get; set; }
    }
}
