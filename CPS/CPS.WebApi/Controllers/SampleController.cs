using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CPS.WebApi.Models;

namespace CPS.WebApi.Controllers
{
    public class SampleController : ApiController
    {
        public Decimal Get()
        {
            var reponse = Request.CreateResponse(HttpStatusCode.NotFound, new HttpError(Resources.Messages.NotFound));
            throw new HttpResponseException(reponse);
        }

        public Employee Get(int id)
        {
            var employee = new Employee()
            {
                Name = "Juan Perez",
                Compensation = 45678.12M,
                Hired = DateTime.Today.AddDays(-854)

            };
            return employee;
        }
    }
}
