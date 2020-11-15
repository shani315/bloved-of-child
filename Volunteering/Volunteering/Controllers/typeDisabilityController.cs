using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DAL;
namespace Volunteering.Controllers
{
    public class typeDisabilityController : ApiController
    {
        //מוסיפה סוג התנדבות למתנדב/מוגבלות לילד חדש
        public bool addtypeDisability([FromBody] typeDisability typeDisability)
        {
            return TypeDisabilityBL.addtypeDisability(typeDisability);
        }

    }
}