using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HotelDataAccess;

namespace HotelTsgWebApplication.Controllers
{
    
    [Authorize]
    public class RezervareController : ApiController
    {   
        [Authorize(Roles ="administrator")]
        [Route("Rezervare")]
        [HttpGet]
        public HttpResponseMessage Get()
        {

            using (HotelTsgDBEntities entities = new HotelTsgDBEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, entities.spRezervare_GetAll().ToList());
            }

        }
        // Put ? limitare suprapunere rezervari ?
    }
}