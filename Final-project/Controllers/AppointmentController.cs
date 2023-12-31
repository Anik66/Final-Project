using BLL.DTOs;
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
    public class AppointmentController : ApiController
    {
        [HttpGet]
        [Route("api/Appointments")]
        public HttpResponseMessage Appointments()
        {
            try
            {
                var data = AppointmentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/Appointments/{id}")]
        public HttpResponseMessage Appointmentl(int id)
        {
            try
            {
                var data = AppointmentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/Appointments/delete/{id}")]
        public HttpResponseMessage DeleteAppointment(int id)
        {
            try
            {
                var data = AppointmentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/Appointments/insert")]
        public HttpResponseMessage InsertBill(AppointmentDTO appointment)
        {
            try
            {
                var data = AppointmentService.Create(appointment);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/Appointments/update")]
        public HttpResponseMessage UpdateBill(AppointmentDTO appointment)
        {
            try
            {
                var data = AppointmentService.Update(appointment);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
