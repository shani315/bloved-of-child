using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DTO;
using DAL;
namespace Volunteering.Controllers
{
    public class volunteerController : ApiController
    {
        [HttpGet]
        [Route("api/Volunteer/GetAllVolunteer")]
        //מחזירה את רשימת המתנדבות
        public List<volunteerDTO> GetAllVolunteer()
        {
            return VolunteerBL.GetAllVolunteers();
        }
        [HttpDelete]
        [Route("api/Volunteer/removeVolunteerByID")]
        //מסירה מתנדב לפי ת.ז
        public bool removeVolunteerByID([FromBody]deleteVolunteer volunteer)
        {
            volunteeringEntities1 volunteeringET = new volunteeringEntities1();
            return VolunteerBL.removeVolunteerByID(volunteer.Id);
        }
        //מחזירה רשימה של מתנדבות שעזבו
        [HttpGet]
        [Route("api/Volunteer/GetVolunteersWhoLeft")]
        public List<volunteerDTO> GetVolunteersWhoLeft()
        {
            return VolunteerBL.GetVolunteersWhoLeft();
        }
        //מוסיפה מתנדבת חדשה למערכת
        [HttpPut]
        [Route("api/Volunteer/AddNewVolunteer")]
        public bool AddNewVolunteer(volunteer v)
        {
           return VolunteerBL.AddNewVolunteer(v);

        }
        //בחירת מתנדב ושליחת מייל
        public class deleteVolunteer
        {
            public int Id { get; set; }
        }
    }
}