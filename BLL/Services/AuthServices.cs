﻿using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthServices
    {
        public static TokenDTO Authenticate(string uname, string pass)
        {
           var res = DataAccessFactory.AuthData().Authenticate(uname, pass);
            if (res)
            {
                var token = new Token();
                token.UserId = uname;
                token.CreatedAt = DateTime.Now;
                token.TKey = Guid.NewGuid().ToString();
                var ret = DataAccessFactory.TokenData().Create(token);
                if(ret != null)
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(ret);
                }
            }
            return null;
        }
    }
}
