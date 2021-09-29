using First_Traning.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace First_Traning.Controllers.model
{
    public class User:IBM
    {
      

        
        public int id { set; get; }
        public string name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public ICollection<Post> Posts { get; set; }
      



        //List<Post> Lst = new List<Post>();

        
        public User() { }
        public User(int id ,String name, string email, string phone) 
        {
            this.id = id;
            this.name = name;
            this.Email = email;
            this.Phone = phone;
        }

    }
}
