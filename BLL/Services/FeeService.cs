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
    public class FeeService
    {
        public static List<FeeDTO> Get()
        {
            var data = DataAccessFactory.FeeData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Fee, FeeDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<FeeDTO>>(data);
            return mapped;
        }
        public static FeeDTO Get(int id)
        {
            var data = DataAccessFactory.FeeData().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Fee, FeeDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FeeDTO>(data);
            return mapped;
        }
        public static bool Create(FeeDTO bill)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FeeDTO, Fee>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Fee>(bill);
            return DataAccessFactory.FeeData().Insert(mapped);
        }
        public static bool Update(FeeDTO fee)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FeeDTO, Fee>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Fee>(fee);
            return DataAccessFactory.FeeData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.FeeData().Delete(id);
        }
    }

}
