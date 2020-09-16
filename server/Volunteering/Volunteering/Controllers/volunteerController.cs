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
        //מחזירה את רשימת המתנדבות
        public List<volunteerDTO> GetAllVolunteer()
        {
            return VolunteerBL.GetAllVolunteers();
        }
        //מסירה מתנדב לפי ת.ז
        public bool removeVolunteerByID(int id)
        {
            return VolunteerBL.removeVolunteerByID(id);
        }
        //מחזירה רשימה של מתנדבות שעזבו
        [Route("Volunteer/GetVolunteersWhoLeft")]
        public List<volunteerDTO> GetVolunteersWhoLeft()
        {
            return VolunteerBL.GetVolunteersWhoLeft();
        }
        //מוסיפה מתנדבת חדשה למערכת
        public bool AddNewVolunteer(volunteer v)
        {
           return VolunteerBL.AddNewVolunteer(v);

        }
    }
}