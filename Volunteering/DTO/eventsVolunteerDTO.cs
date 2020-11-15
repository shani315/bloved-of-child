using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class eventsVolunteerDTO
    {
        public int eventsVolunteerID { get; set; }
        public string responsibleSecretary { get; set; }
        public string place { get; set; }
        public string typeEvent { get; set; }
        public Nullable<System.DateTime> dateEvent { get; set; }
        public Nullable<int> maxCountParticipants { get; set; }
        public Nullable<int> countParticipants { get; set; }
        public Nullable<int> minVolunteers { get; set; }
        public string description { get; set; }
    }
}
