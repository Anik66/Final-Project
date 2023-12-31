using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Final_project.Controllers
{
    public class FeeController : ApiController
    {
        [HttpGet]
        [Route("api/fees")]
        public HttpResponseMessage Fees()
        {
            try
            {
                var data = FeeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/fees/{id}")]
        public HttpResponseMessage Feel(int id)
        {
            try
            {
                var data = FeeService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/fees/delete/{id}")]
        public HttpResponseMessage DeleteFee(int id)
        {
            try
            {
                var data = FeeService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/fees/insert")]
        public HttpResponseMessage InsertBill(FeeDTO fee)
        {
            try
            {
                var data = FeeService.Create(fee);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/fees/update")]
        public HttpResponseMessage UpdateBill(FeeDTO fee)
        {
            try
            {
                var data = FeeService.Update(fee);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
