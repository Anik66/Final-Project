using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DoctorService
    {
        public static List<DoctorDTO> Get()
        {
            var data = DataAccessFactory.DoctorData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Doctor, DoctorDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DoctorDTO>>(data);
            return mapped;
        }
        public static DoctorDTO Get(string email)
        {
            var data = DataAccessFactory.DoctorData().Get(email);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Doctor, DoctorDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DoctorDTO>(data);
            return mapped;
        }
        public static bool Create(DoctorDTO doctor)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DoctorDTO, Doctor>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Doctor>(doctor);
            return DataAccessFactory.DoctorData().Insert(mapped);
        }
        public static bool Update(DoctorDTO doctor)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DoctorDTO, Doctor>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Doctor>(doctor);
            return DataAccessFactory.DoctorData().Update(mapped);
        }
        public static bool Delete(string email)
        {
            return DataAccessFactory.DoctorData().Delete(email);
        }

    }
}
