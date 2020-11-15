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
    public class volunteerOfChildController : ApiController
    {public class changeStatus
        {
            public int id { get; set; }
        }
        [HttpPost]
        [Route("api/volunteerOfChild/contentedVolunteering")]
        //מאשרת בקשת התנדבות
        public bool contentedVolunteering([FromBody]changeStatus volunteerOfChildID)
        {
            return VolunteerOfChildBL.contentedVolunteering(volunteerOfChildID.id);

        }
        [HttpPost]
        [Route("api/volunteerOfChild/contentedVolunteering")]
        //דוחה בקשת התנדבות
        public bool SpurnedVolunteering([FromBody]changeStatus volunteerOfChildID)
        {
            return VolunteerOfChildBL.SpurnedVolunteering(volunteerOfChildID.id);

        }
        [HttpPost]
        [Route("api/volunteerOfChild/contentedVolunteering")]
        //ביטול קבוע התנדבות
        public bool CancelledVolunteering([FromBody]changeStatus volunteerOfChildID)
        {
            return VolunteerOfChildBL.CancelledVolunteering(volunteerOfChildID.id);

        }
        [HttpPost]
        [Route("api/volunteerOfChild/contentedVolunteering")]
        //ביטול התנדבות חד פעמי
        public bool CancellationIndividualdVolunteering([FromBody]changeStatus volunteerOfChildID)
        {
            return VolunteerOfChildBL.CancellationIndividualdVolunteering(volunteerOfChildID.id);

        }
    }
}
