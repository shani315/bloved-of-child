using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
namespace Volunteering.Controllers
{
    public class GlobalController : ApiController
    {
        [HttpGet]
        [Route("Global/ReturnsUserType/{userName}-{password}")]
        public object ReturnsUserType(string userName, string password)
        {
            return GlobalBL.ReturnsUserType(userName, password);
        }
    }
}
