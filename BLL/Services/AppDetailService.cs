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
    public class AppDetailService
    {
        public static List<AppDetailDTO> Get()
        {
            var data = DataAccessFactory.AppDetailData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AppDetail, AppDetailDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AppDetailDTO>>(data);
            return mapped;
        }
        public static AppDetailDTO Get(int id)
        {
            var data = DataAccessFactory.AppDetailData().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AppDetail, AppDetailDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AppDetailDTO>(data);
            return mapped;
        }
        public static bool Create(AppDetailDTO appdetail)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AppDetailDTO, AppDetail>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AppDetail>(appdetail);
            return DataAccessFactory.AppDetailData().Insert(mapped);
        }
        public static bool Update(AppDetailDTO appdetail)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AppDetailDTO, AppDetail>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AppDetail>(appdetail);
            return DataAccessFactory.AppDetailData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.AppDetailData().Delete(id);
        }
    }
}

