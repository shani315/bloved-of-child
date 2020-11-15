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
    public class familyController : ApiController
    {
        //מוסיפה משפחה
        [HttpPut]
        [Route("api/family/newFamily")]
        public bool newFamily([FromBody] family family)
        {
            return FamilyBL.newFamily(family);

        }
    }
}