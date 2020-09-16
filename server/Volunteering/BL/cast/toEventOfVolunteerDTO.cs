using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.cast
{
    class toEventOfVolunteerDTO
    {
   public eventOfVolunteerDTO GetEventOfVolunteer(eventOfVolunteer eov)
        {
            eventOfVolunteerDTO newEventOfVolunteer = new eventOfVolunteerDTO();
            newEventOfVolunteer.countVolunteer = eov.countVolunteer;
            newEventOfVolunteer.eventId = eov.eventId;
            newEventOfVolunteer.IsParticipant = eov.IsParticipant;
            newEventOfVolunteer.minCountVolunteering = eov.minCountVolunteering;
            newEventOfVolunteer.volunteerId = eov.volunteerId;
            newEventOfVolunteer.volunteerOfEventID = eov.volunteerOfEventID;
            return newEventOfVolunteer;
        }
    }
}
