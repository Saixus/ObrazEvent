using ObrazEvent.Data.Contract;
using ObrazEvent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ObrazEvent.Web.Controllers
{
    public class ServiceController : ApiControllerBase
    {
        public ServiceController(IObrazEventUow uow)
        {
            Uow = uow;
        }
        // GET api/service
        public IEnumerable<string> Get()
        {
            return new string[] { "" };
        }

        // GET api/service/5
        public IEnumerable<Video> Get(int id)
        {
            return Uow.Services.GetVideos(id);
        }

        // POST api/service
        public void Post([FromBody]string value)
        {
        }

        // PUT api/service/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/service/5
        public void Delete(int id)
        {
        }
    }
}
