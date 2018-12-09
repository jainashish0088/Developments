using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using SAEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace smarthomeautomation.Controllers
{
    public class DefaultController : ApiController
    {
        public string test()
        {
            DalProduct objDalProduct = new DalProduct();
            objDalProduct.SelectProductList("cdf");
            return "";
        }
        [HttpGet]
        [Route("AuthorizedUser")]
        [Authorize(Roles = "Admin")]
        public IHttpActionResult AuthorizedUser(string user, string password)
        {
            return Ok("");
        }
    }
}
