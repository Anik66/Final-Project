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
    public class DoctorController : ApiController
    {
        [HttpGet]
        [Route("api/doctors")]
        public HttpResponseMessage Doctors()
        {
            try
            {
                var data = DoctorService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/doctors/{email}")]
        public HttpResponseMessage Doctor(string email)
        {
            try
            {
                var data = DoctorService.Get(email);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/doctors/delete/{email}")]
        public HttpResponseMessage DeleteDoctor(string email)
        {
            try
            {
                var data = DoctorService.Delete(email);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/doctors/insert")]
        public HttpResponseMessage InsertEmployee(DoctorDTO doctor)
        {
            try
            {
                var data = DoctorService.Create(doctor);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/doctors/update")]
        public HttpResponseMessage UpdateEmployee(DoctorDTO doctor)
        {
            try
            {
                var data = DoctorService.Update(doctor);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
