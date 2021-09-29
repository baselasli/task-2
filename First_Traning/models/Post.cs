using First_Traning.Controllers.model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace First_Traning.models
{
    [Table("POSTS")]
    public class Post:IBM
    {
        public Post(int id, string title, string body)
        {
            this.id = id;
            this.title = title;
            this.body = body;
        }
        public Post() { }
        [Key]
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        public string body { get; set; }

        [ForeignKey("user1")]
        public int userId { get; set; }

        [InverseProperty("Posts")]
        public User Users { get; set; }
       
    }
}
