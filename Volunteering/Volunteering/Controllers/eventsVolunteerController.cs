using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using DTO;
using BL;
namespace Volunteering.Controllers
{
    public class eventsVolunteerController : ApiController
    {
        volunteeringEntities1 volunteeringET = new volunteeringEntities1();
        //הזנת אירוע חדש
        [HttpPut]
        [Route("api/eventsVolunteer")]
        public bool addNewEvents(eventsVolunteer eventsVolunteer)
        {
            if (eventsVolunteer!= null && ModelState.IsValid == true)
            {
                volunteeringET.eventsVolunteer.Add(eventsVolunteer);
                volunteeringET.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        //הצגת כל האירועים
        [HttpGet]
        [Route("api/GetAllEvents")]
        public List<eventsVolunteerDTO> GetAllEvents()
        {
            return EventsVolunteerBL.GetAllEvents();
        }
        }
}