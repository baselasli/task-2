using First_Traning.Controllers.model;
using First_Traning.Controllers.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_Traning.models
{
    public class UserRepo : GenRepo<User>, IUserRepo
    {
        private readonly AppDBContext dbcontext;
             public UserRepo (AppDBContext dBContext) : base(dBContext) 
        { 
            dbcontext = dBContext;
        }
    }
}
