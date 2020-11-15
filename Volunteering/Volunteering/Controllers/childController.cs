using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web.Http;
using BL;
using DAL;
using DTO;
namespace Volunteering.Controllers
{
    public class childController : ApiController
    {
        public class updateStatus
        {
            public int id { get; set; }
        }

        static volunteeringEntities1 VolunteeringET = new volunteeringEntities1();
        [HttpGet]
        [Route("api/Child/GetChild/{id}")]
        //מחזירה ילד ע"פ ת.ז
        public HttpResponseMessage GetChild(int id)
        {
            //Request.Headers.Contains("id");
            HttpResponseMessage response;
            child c = VolunteeringET.child.Find(id);
            if (c == null)
            {
                response = Request.CreateResponse();
                response.StatusCode = HttpStatusCode.NotFound;
            }
            else
            {
                response = Request.CreateResponse(ChildBL.GetChildById(id));
                response.StatusCode = HttpStatusCode.OK;
            }
            return response;
        }
        //מוסיפה ילד חדש 
        //לשאול מה לגבי המשפחה שצריך להוסיף ומה לגבי מספר ילדים במשפחה
        [HttpPut]
        [Route("api/Child/NewChild")]
        public bool NewChild([FromBody]child newChild)
        {
            return ChildBL.NewChild(newChild);
        }
        [HttpGet]
        [Route("api/Child/GetAllChildrenWhoNeedApproval")]
        //מחזירה את כל הילדים שהסטטוס שלהם לא פעיל
        public List<childDTO> GetAllChildrenWhoNeedApproval()
        {
            List<childDTO> listOfChildren = new List<childDTO>();
            listOfChildren = ChildBL.GetAllChildrenWhoNeedAproval();
            return listOfChildren;
        }
        //משנה את הסטטוס של הילד לפעיל
        //לשאול מה לגבי מחכה לתשובה
        [HttpPost]
        [Route("api/Child/UpdateTheStatus")]
        public bool UpdateTheStatus([FromBody] updateStatus updateStatus)
        {
            return ChildBL.UpdateTheStatus(updateStatus.id);
        }

        //שליחת מייל
        public bool sendEmail(string email, string subject, string body)
        {
            return GlobalBL.SendEmail(email, subject, body);
        }
        //מחזירה את רשימת הילדים
        [HttpGet]
        [Route("api/Child/GetAllChildrens")]
        public List<childDTO> AllChildrens()
        {
            return ChildBL.GetAllChildrens();
        }
        //מחזירה כמות ילדים שהצטרפו לאתר לפי חודש 
        //מחזירה פעיל ולא פעיל באחוזים
        [HttpGet]
        [Route("api/Child/GetActiveAndInactiveInPercent")]
        public float GetActiveAndInactiveInPercent()
        {
            return ChildBL.GetActiveAndInactiveInPercent();
        }
    }
}