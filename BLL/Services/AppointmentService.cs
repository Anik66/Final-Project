using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.Patient_DTO;
using DAL.Models.Patient_Models;

namespace BLL.Services
{
    public class AppointmentService
    {
        public static List<AppointmentDTO> Get()
        {
            var data = DataAccessFactory.AppointmentData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Appointment, AppointmentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AppointmentDTO>>(data);
            return mapped;
        }
        public static AppointmentDTO Get(int id)
        {
            var data = DataAccessFactory.AppointmentData().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Appointment, AppointmentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AppointmentDTO>(data);
            return mapped;
        }
        public static bool Create(AppointmentDTO bill)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AppointmentDTO, Appointment>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Appointment>(bill);
            return DataAccessFactory.AppointmentData().Insert(mapped);
        }
        public static bool Update(AppointmentDTO Appointment)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AppointmentDTO, Appointment>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Appointment>(Appointment);
            return DataAccessFactory.AppointmentData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.AppointmentData().Delete(id);
        }
    }
}
