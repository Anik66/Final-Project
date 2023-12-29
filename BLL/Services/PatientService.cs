using AutoMapper;
using BLL.DTOs.Patient_DTO;
using DAL;
using DAL.Models.Patient_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PatientService
    {
        public static List<PatientDTO> Read()
        {
            var data = DataAccessFactory.PatientData().Read();
            var Config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Patient, PatientDTO>();
            });
            var mapper = new Mapper(Config);
            return mapper.Map<List<PatientDTO>>(data);
        }
        public static Patient Create (PatientDTO c)
        {
            var Config = new MapperConfiguration(cfg => {
                cfg.CreateMap<PatientDTO, Patient>();
            });
            var mapper = new Mapper(Config);
            var data = mapper.Map<Patient>(c);
            return DataAccessFactory.PatientData().Create(data);
        }
        
    }
}
