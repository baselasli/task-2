using AutoMapper;
using First_Traning.Controllers.models;
using First_Traning.models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_Traning.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostControllar : ControllerBase
    
    {
        IPostRepo posT = null;
        private readonly IMapper _mapper;
        AppDBContext dbc;
        public PostControllar(IMapper mapper, IPostRepo P, AppDBContext DBC)
        {
            this.posT = P;
            this._mapper = mapper;
            this.dbc = DBC;
        }


        [HttpGet]
        public async Task<IEnumerable<Post>> Getpost()
        {

            return await posT.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Post> GetUser(int id)
        {
            return await posT.GetByID(id);

        }

        [HttpPost]
        public async Task AdduPost(Post po)
        {
            await posT.Add(po);

        }

        [HttpDelete("{id}")]
        public async Task Deletepost(int id)
        {
            await posT.DeleteByID(id);

        }
    }
}
