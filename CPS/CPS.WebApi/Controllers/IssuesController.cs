using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using CPS.WebApi.Models;

namespace CPS.WebApi.Controllers
{
    public class IssuesController : ApiController
    {
        // GET: Issues

       public HttpResponseMessage Put(IssueDto issue, int id)
        {
            
        }

        public HttpResponseMessage Post(IssueDto issue)
        {

            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }
    }
}
