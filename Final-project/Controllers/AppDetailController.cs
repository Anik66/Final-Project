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
    public class AppDetailController : ApiController
    {
        [HttpGet]
        [Route("api/appdetails")]
        public HttpResponseMessage AppDetails()
        {
            try
            {
                var data = AppDetailService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/appdetails/{id}")]
        public HttpResponseMessage AppDetail(int id)
        {
            try
            {
                var data = AppDetailService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/appdetails/delete/{id}")]
        public HttpResponseMessage DeleteAppDetail(int id)
        {
            try
            {
                var data = AppDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/appdetails/insert")]
        public HttpResponseMessage InsertOrderDetail(AppDetailDTO appdetail)
        {
            try
            {
                var data = AppDetailService.Create(appdetail);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/appdetails/update")]
        public HttpResponseMessage UpdateOrderDetail(AppDetailDTO appdetail)
        {
            try
            {
                var data = AppDetailService.Update(appdetail);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
    }
}
