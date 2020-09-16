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

        static volunteeringEntities1 VolunteeringET = new volunteeringEntities1();
        [HttpGet]
        [Route("Child/GetChild/{id}")]
        //מחזירה ילד ע"פ ת.ז
        public HttpResponseMessage GetChild(int id)
        {
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

       [HttpPost]
        //מוסיפה ילד חדש למערכת
        [Route("Child/NewChild")]
        public void NewChild([FromBody]child newChild)
        {
            volunteeringEntities1 volunteeringET=new volunteeringEntities1();
         if(newChild!=null&&ModelState.IsValid==true)
            {
            volunteeringET.child.Add(newChild);
                volunteeringET.SaveChanges();
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }
        [Route("Child/GetAllChildrenWhoNeedApproval")]
        //מחזירה את כל הילדים שהסטטוס שלהם לא פעיל
        public List<childDTO> GetAllChildrenWhoNeedApproval()
        {
            List<childDTO> listOfChildren = new List<childDTO>();
            listOfChildren=ChildBL.GetAllChildrenWhoNeedAproval();
            return listOfChildren;
        }
        //משנה את הסטטוס של הילד לפעיל
        //לשאול מה לגבי מחכה לתשובה
        [HttpGet]
        [Route("Child/UpdateTheStatus/{id}")]
        public bool UpdateTheStatus(int id)
        {
            return ChildBL.UpdateTheStatus(id);
        }
        //שליחת מייל
        public bool sendEmail(string email,string subject,string body)
        {
            return GlobalBL.SendEmail(email,subject,body);
        }
        //מחזירה את רשימת הילדים
        public List<childDTO> GetAllChildrens()
        {
            return ChildBL.GetAllChildrens();
        }
        //מחזירה כמות ילדים שהצטרפו לאתר לפי חודש 
        //מחזירה פעיל ולא פעיל באחוזים
        [Route("Child/GetActiveAndInactiveInPercent")]
        public float GetActiveAndInactiveInPercent()
        {
            return ChildBL.GetActiveAndInactiveInPercent();
        }
    }
}