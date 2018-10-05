using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrashWebApplication1.Models;

namespace TrashWebApplication1.Controllers
{
    [RoutePrefix("blah")]
    public class DefaultController : ApiController
    {
        [Route]
        [HttpGet]
        public SomePoco Get()
        {
            return new SomePoco();
        }

        [Route]
        [HttpPut]
        public IHttpActionResult Put(SomePoco somePoco)
        {
            return Created($"blah/{somePoco.Id}", somePoco);
        }
    }
}
