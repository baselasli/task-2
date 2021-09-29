using AutoMapper;
using First_Traning.Controllers.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_Traning.models
{
    public class MapConfig:Profile
    {
        public MapConfig()
        {
            CreateMap<User, UserViweModel>().ReverseMap();
            CreateMap<Post, PostViweModel>().ReverseMap();
        }
    }
}
