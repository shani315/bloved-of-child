using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.cast
{
    class toEventsVolunteerDTO
    {
        public static eventsVolunteerDTO GetEventsVolunteer(eventsVolunteer ev)
        {
            eventsVolunteerDTO newEventsVolunteer = new eventsVolunteerDTO();
            newEventsVolunteer.countParticipants = ev.countParticipants;
            newEventsVolunteer.dateEvent = ev.dateEvent;
            newEventsVolunteer.description = ev.description;
            newEventsVolunteer.eventsVolunteerID = ev.eventsVolunteerID;
            newEventsVolunteer.maxCountParticipants = ev.maxCountParticipants;
            newEventsVolunteer.minVolunteers = ev.minVolunteers;
            newEventsVolunteer.place = ev.place;
            newEventsVolunteer.responsibleSecretary = ev.responsibleSecretary;
            newEventsVolunteer.typeEvent = ev.typeEvent;
            return newEventsVolunteer;
        }
    }
}
