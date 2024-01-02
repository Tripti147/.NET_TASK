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
    public class RentUserinfoServices
    {
        public static List<RentUserinfoDTO> Get()
        {
            var data = DataAccessFactory.RentUserinfoData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<RentUserinfo, RentUserinfoDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<RentUserinfoDTO>>(data);
            return mapped;


        }
        public static RentUserinfoDTO Get(int id)
        {
            var data = DataAccessFactory.RentUserinfoData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<RentUserinfo, RentUserinfoDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<RentUserinfoDTO>(data);
            return mapped;
        }
        public static RentUserinforeviewDTO GetwithComments(int id)
        {
            var data = DataAccessFactory.RentUserinfoData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<RentUserinfo, RentUserinforeviewDTO>();
                c.CreateMap<RentUserreview, RentUserreviewDTO>();
                c.CreateMap<RentUser, RentUserDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<RentUserinforeviewDTO>(data);
            return mapped;
        }
    }
}