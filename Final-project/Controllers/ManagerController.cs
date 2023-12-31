using BLL.DTOs;
using BLL.Services;
using Final_project.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Final_project.Controllers
{
    [Logged]
    [EnableCors("*", "*", "*")]
    public class ManagerController : ApiController
    {
        [HttpGet]
        [Route("api/managers")]
        public HttpResponseMessage Managers()
        {
            try
            {
                var data = ManagerService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/managers/{email}")]
        public HttpResponseMessage Manager(string email)
        {
            try
            {
                var data = ManagerService.Get(email);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/managers/delete/{email}")]
        public HttpResponseMessage DeleteManager(string email)
        {
            try
            {
                var data = ManagerService.Delete(email);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/managers/insert")]
        public HttpResponseMessage InsertEmployee(ManagerDTO manager)
        {
            try
            {
                var data = ManagerService.Create(manager);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/managers/update")]
        public HttpResponseMessage UpdateEmployee(ManagerDTO manager)
        {
            try
            {
                var data = ManagerService.Update(manager);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
