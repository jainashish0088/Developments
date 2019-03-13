using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace smarthomeautomation.Controllers
{
    public class TestController : ApiController
    {
        // GET: api/Test
        public IEnumerable<string> GetCustomer()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Test/5
        public string GetCustomer(int id)
        {
            return "value";
        }

        // POST: api/Test
        [HttpPost]
        public void CreateCustomer([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        [HttpPut]
        public void UpdateCustomer(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        [HttpDelete]
        public void DeleteCustomer(int id)
        {

        }
    }
}
