using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using CPS.Contract;
using CPS.WebApi.Models;
using CPS.Business;

namespace CPS.WebApi.Controllers
{
    public class ClaimsController : ApiController
    {
        public HttpResponseMessage Post(ClaimDto claim)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var claimBl = new ClaimBusiness();
                    var newClaim = claimBl.Create(claim);
                    var response = Request.CreateResponse<ClaimDto>(HttpStatusCode.Created, newClaim);
                    var uri = Url.Link("DefaultApi", new { id = newClaim.Id});
                    response.Headers.Location = new Uri(uri);
                    return response;
                }
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.BadRequest));
            }
            catch (Exception e)
            {
                var response = Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                throw new HttpResponseException(response);

            }
        }

        public ClaimDto Get(int id)
        {
            var claim = new ClaimBusiness().Get(id);

            if (claim == null) throw new HttpResponseException(HttpStatusCode.NotFound);
            return claim;
        }
    }
}
