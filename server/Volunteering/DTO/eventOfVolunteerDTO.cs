using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class eventOfVolunteerDTO
    {
        public int volunteerOfEventID { get; set; }
        public Nullable<int> eventId { get; set; }
        public Nullable<int> volunteerId { get; set; }
        public Nullable<int> minCountVolunteering { get; set; }
        public Nullable<int> countVolunteer { get; set; }
        public string IsParticipant { get; set; }
    }
}
