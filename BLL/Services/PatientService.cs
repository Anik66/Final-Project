using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PatientService
    {
        public static List<PatientDTO> Get()
        {
            var data = DataAccessFactory.PatientData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Patient, PatientDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PatientDTO>>(data);
            return mapped;
        }
        public static PatientDTO Get(string email)
        {
            var data = DataAccessFactory.PatientData().Get(email);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Patient, PatientDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PatientDTO>(data);
            return mapped;
        }
        public static bool Create(PatientDTO Patient)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PatientDTO, Patient>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Patient>(Patient);
            return DataAccessFactory.PatientData().Insert(mapped);
        }
        public static bool Update(PatientDTO Patient)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PatientDTO, Patient>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Patient>(Patient);
            return DataAccessFactory.PatientData().Update(mapped);
        }
        public static bool Delete(string email)
        {
            return DataAccessFactory.PatientData().Delete(email);
        }
    }
}
