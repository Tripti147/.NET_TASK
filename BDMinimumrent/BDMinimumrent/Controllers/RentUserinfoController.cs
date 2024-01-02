using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BDMinimumrent.Controllers
{
    public class RentUserinfoController : ApiController
    {
        public object RentUserServices { get; private set; }

        [HttpGet]
        [Route("api/Adminhotelinfos")]
        public HttpResponseMessage Adminhotelinfos()
        {
            try
            {
                var data = RentUserServices.GetType();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/Adminhotelinfos/{id}")]
        public HttpResponseMessage Adminhotelinfo(int id)
        {
            try
            {
                var data = RentUserinfoServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("api/Adminhotelinfos/{id}/Adminhotelreviews")]
        public HttpResponseMessage Adminhotelinforeviews(int id)
        {
            try
            {
                var data = RentUserinfoServices.GetwithComments(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

    }
}
