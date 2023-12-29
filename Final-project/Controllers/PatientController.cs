using BLL.DTOs.Patient_DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Final_project.Controllers
{
    public class PatientController : ApiController
    {
        [HttpGet]
        [Route("api/courses/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = PatientService.Read();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/courses/create")]
        public HttpResponseMessage Create(PatientDTO c)
        {
            try
            {
                var data = PatientService.Create(c);
                return Request.CreateResponse(System.Net.HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(System.Net.HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/posts/{id}/comments")]
        public HttpResponseMessage Update(int id)
        {
            try
            {
                var data = PatientService.Update(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/posts/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var res = PatientService.(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }
    }
}
