using HotelAPIfinal.Models;
using HotelDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelAPIfinal.Controllers
{
    [Authorize]
    public class RaportController : ApiController
    {
        [Authorize(Roles = "client")]
        [Route("Raport/{nr_camera:int}/{id_client:int}")]
        [HttpGet]
        public HttpResponseMessage Get(int nr_camera, int id_client)
        {
            try
            {
                using (HotelTsgDBEntities entities = new HotelTsgDBEntities())
                {
                    spRezervareRaportv2_Result rez_result = entities.spRezervareRaportv2(nr_camera, id_client).FirstOrDefault();
                    rez_result.dotari = entities.spGetDotByRoom(nr_camera).ToList();
                    rez_result.servicii = entities.spGetServiceByRez(nr_camera, id_client).ToList();

                    //in spRezervareRaportv2_Result
                    //public List<spGetDotByRoom_Result> dotari { get; set; }
                    //public List<spGetServiceByRez_Result> servicii { get; set; }

                    return Request.CreateResponse(HttpStatusCode.OK, rez_result);
                }
            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,"!Eroare, verfica daca valorile introduse corespund unei rezervari" ,e);
            }
        }
    }
}
