using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using BL;
namespace Volunteering.Controllers
{
    public class eventOfVolunteerController : ApiController
    {
        public class approvalParticipation
        {
            public int id { get; set; }
        }
        //בדיקה מי יכולה להשתתף באירוע ושליחת אימייל לכל אחת
        public bool invitationParticipants(int eventsVolunteerID)
        {
            //בדיקה מי יכול להשתתף באירוע לפי מספר שעות התנדבות מינימאלי
            return EventOfVolunteerBL.invitationParticipants(eventsVolunteerID);
        }
       // מתנדב מאשר השתתפות באירוע
       [HttpPost]
       [Route("api/eventOfVolunteer/approvalParticipationInEvent")]
       public bool approvalParticipationInEvent([FromBody] approvalParticipation approvalParticipation)
        {
            return EventOfVolunteerBL.approvalParticipationInEvent(approvalParticipation.id);
        }
    }
}