using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Final_project.Controllers
{
    [EnableCors("*", "*", "*")]
    public class PatientController : ApiController
    {
         [HttpGet]
        [Route("api/patients")]
        public HttpResponseMessage Patients()
        {
            try
            {
                var data = PatientService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/patients/{id}")]
        public HttpResponseMessage Patientl(int id)
        {
            try
            {
                var data = PatientService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/patients/delete/{id}")]
        public HttpResponseMessage Deletepatient(int id)
        {
            try
            {
                var data = PatientService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/patients/insert")]
        public HttpResponseMessage InsertPatient(PatientDTO patient)
        {
            try
            {
                var data = PatientService.Create(patient);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/patients/update")]
        public HttpResponseMessage UpdatePatient(PatientDTO patient)
        {
            try
            {
                var data = PatientService.Update(patient);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
