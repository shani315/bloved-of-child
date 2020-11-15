using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class EventsVolunteerBL
    {
        static volunteeringEntities1 volunteeringET = new volunteeringEntities1();
        //public bool addNewEvents(eventsVolunteer eventsVolunteer)
        //{

        //}
        //שולפת את כל האירועים
        public static List<eventsVolunteerDTO> GetAllEvents()
        {
            List<eventsVolunteer> eventsVolunteers = volunteeringET.eventsVolunteer.ToList();
            List<eventsVolunteerDTO> eventsVolunteerDTO = new List<eventsVolunteerDTO>();
            foreach (var item in eventsVolunteers)
            {
                eventsVolunteerDTO.Add(cast.toEventsVolunteerDTO.GetEventsVolunteer(item));
            }
            return eventsVolunteerDTO;
        }
    }
}

