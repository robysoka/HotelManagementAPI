using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HotelDataAccess;
using HotelAPIfinal.Models;

namespace HotelTSGfinal.Controllers
{
    [Authorize]
    public class CameraController : ApiController
    {
        [AllowAnonymous]
        [Route("Camera")]
        [HttpGet]
        public HttpResponseMessage Get()
        {

            using (HotelTsgDBEntities entities = new HotelTsgDBEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, entities.spCamera_GetAll().ToList());
            }

        }

        [Authorize(Roles = "client")]
        [Route("Camera/{nr_camera:int}")]
        [HttpGet]
        public HttpResponseMessage Get(int nr_camera)
        {
            using (HotelTsgDBEntities entities = new HotelTsgDBEntities())
            {
                spCamera_GetByNumber_Result entity = entities.spCamera_GetByNumber(nr_camera).FirstOrDefault();
                if (entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Camera cu numarul " + nr_camera + " nu exista");
                }
            }
        }

        [Authorize(Roles = "administrator")]
        [Route("Camera")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody] Camera camera)
        {
            try
            {
                using (HotelTsgDBEntities entities = new HotelTsgDBEntities())
                {
                    entities.spCamera_Insert(camera.nr_camera, camera.capacitate, camera.pret);

                    var message = Request.CreateResponse(HttpStatusCode.Created, camera);
                    message.Headers.Location = new Uri(Request.RequestUri.ToString());

                    return message;

                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }

        [Authorize(Roles = "client")]
        [Route("Camera/{nr_camera:int}")]
        [HttpPut]
        public HttpResponseMessage Put(int nr_camera, [FromBody] int pret)
        {
            try
            {
                using (HotelTsgDBEntities entities = new HotelTsgDBEntities())
                {
                    var count = entities.spCamere_UpdatePrice(nr_camera, pret);
                    if (count == 1)
                        return Request.CreateResponse(HttpStatusCode.OK, "Camera " + nr_camera + " a fost modificata");
                    else
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Camera cu nr: " + nr_camera + " nu exista!");
                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }

        }

        [Authorize(Roles = "administrator")]
        [Route("Camera/{nr_camera:int}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int nr_camera)
        {
            try
            {
                using (HotelTsgDBEntities entities = new HotelTsgDBEntities())
                {
                    var count = entities.spCamera_Delete(nr_camera);
                    if (count == 1)
                        return Request.CreateResponse(HttpStatusCode.OK, "Camera " + nr_camera + " a fost stearsa");
                    else
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Camera cu nr: " + nr_camera + " nu exista!");
                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }
    }
}
