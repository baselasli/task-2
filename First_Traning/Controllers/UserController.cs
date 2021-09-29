using First_Traning.Controllers.models;
using First_Traning.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Traning.Controllers.model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace First_Traning.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : ControllerBase

    {
        IUserRepo MyUser = null;
        private readonly IMapper _mapper;
        AppDBContext db;
        public UserController(IMapper mapper, IUserRepo MyUser, AppDBContext DB)
        {
            this.MyUser = MyUser;
            this._mapper = mapper;
            this.db = DB;
        }


        [HttpGet]
        public async Task<IEnumerable<User>> GetUser()
        {

            return await MyUser.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<User> GetUser(int id)
        {

            return await MyUser.GetByID(id);
        }

        [HttpPost]
        public async Task Adduser(User user)
        {
            await MyUser.Add(user);

        }

        [HttpDelete("{id}")]
        public async Task Deleteuser(int id)
        {
            await MyUser.DeleteByID(id);

        }








        //IUserRepo MyUser = null;

        //public UserController(IUserRepo myUser)
        //{
        //    MyUser = myUser;
        //}

        //[HttpGet]
        //public IEnumerable<User> GetAllUsers()
        //{
        //    return MyUser.getList();

        //}

        //[HttpGet("{id}")]
        //public User GetUser(int id)
        //{
        //    return MyUser.get(id);
        //}

        ////[HttpDelete("{id}")]
        ////public void DeleteUser(int id)
        ////{
        ////    MyUser.DeleteByid(id);

        ////}


        //[HttpPost]
        //public void AddUser([FromBody] User user)
        //{
        //    MyUser.add(user);
        //}




















        // private readonly AppDBContext dbContext;

        //public UserController(IUserRepo userRepo)
        //{
        //    this.dbContext = dbContext;
        //}
        //public IEnumerable<User> getAllUsers()
        //{
        //    return dbContext.user.ToList();
        //}
        //

        //IUser FirstUser = null;
        //public UserController(IUser firstUser)
        //{
        //    FirstUser = firstUser;
        //}

        //[HttpPost]
        //public void addUser([FromBody] Users user)
        //{
        //    FirstUser.addUser(user);
        //}
        //[HttpDelete("{id}")]
        //public void deleteUser(int id)
        //{
        //    FirstUser.deleteUser(id);
        //}
        //[HttpGet]
        //public List<Users> GetAllUsers()
        //{
        //    return FirstUser.GetAllUsers();
        //}
        //[HttpGet("{id}")]
        //public Users getUser(int id)
        //{
        //    return FirstUser.getUser(id);
        //}

    }
}





