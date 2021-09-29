using First_Traning.Controllers.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_Traning.models
{
    public class PostRepo:GenRepo<Post>,IPostRepo
    {
        private readonly AppDBContext dbcontext;
        public PostRepo(AppDBContext dBContext) : base(dBContext)
        {
            dbcontext = dBContext;
        }
    }
}
