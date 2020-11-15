using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using BL;
using DTO;
namespace Volunteering.Controllers
{
    public class volunteerHistoryController : ApiController
    {
        //מחזירה את כל ההתנדבויות שהיו בשבוע האחרון
        [HttpGet]
        [Route("api/VolunteerHistory/GetAllTheVolunteersThatWereInTheLastWeek")]
        public List<volunteerHistoryDTO> GetAllTheVolunteersThatWereInTheLastWeek()
        {
           return VolunteerHistoryBL.GetAllTheVolunteersThatWereInTheLastWeek();
        }
        //מוסיפה התנדבות שהתבצעה
        [HttpPut]
        [Route("api/VolunteerHistory/AddNewVolunteerHistory")]
        public bool AddNewVolunteerHistory([FromBody] volunteerHistory vh)
        {
            return VolunteerHistoryBL.AddNewVolunteerHistory(vh);
        }
    }
}