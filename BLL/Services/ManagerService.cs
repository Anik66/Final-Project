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
    public class ManagerService
    {
        public static List<ManagerDTO> Get()
        {
            var data = DataAccessFactory.ManagerData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Manager, ManagerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ManagerDTO>>(data);
            return mapped;
        }
        public static ManagerDTO Get(string email)
        {
            var data = DataAccessFactory.ManagerData().Get(email);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Manager, ManagerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ManagerDTO>(data);
            return mapped;
        }
        public static bool Create(ManagerDTO manager)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ManagerDTO, Manager>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Manager>(manager);
            return DataAccessFactory.ManagerData().Insert(mapped);
        }
        public static bool Update(ManagerDTO manager)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ManagerDTO, Manager>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Manager>(manager);
            return DataAccessFactory.ManagerData().Update(mapped);
        }
        public static bool Delete(string email)
        {
            return DataAccessFactory.ManagerData().Delete(email);
        }

    }
}