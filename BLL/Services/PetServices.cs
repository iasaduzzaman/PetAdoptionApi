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
    public class PetServices
    {
        public static List<PetDTO> Get()
        {
            var data = DataAccessFactory.PetData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Pet, PetDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<PetDTO>>(data);
        }

        public static PetDTO Get(int id)
        {
            var data = DataAccessFactory.PetData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Pet, PetDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<PetDTO>(data);
        }

        public static PetDTO Create(PetDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PetDTO, Pet>();
                c.CreateMap<Pet, PetDTO>();
            });
            var mapper = new Mapper(cfg);
            var entity = mapper.Map<Pet>(obj);
            var created = DataAccessFactory.PetData().Create(entity);
            return created == null ? null : mapper.Map<PetDTO>(created);
        }

        public static PetDTO Update(PetDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PetDTO, Pet>();
                c.CreateMap<Pet, PetDTO>();
            });
            var mapper = new Mapper(cfg);
            var entity = mapper.Map<Pet>(obj);
            var updated = DataAccessFactory.PetData().Update(entity);
            return updated == null ? null : mapper.Map<PetDTO>(updated);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.PetData().Delete(id);
        }
    }
}
