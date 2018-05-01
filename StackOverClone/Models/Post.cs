using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackOverClone.Models
{
    
        [Table("Posts")]
        public class Post
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Username { get; set; }
            public string Question { get; set; }
            public virtual ICollection<Answer> Answers { get; set; }

        }


    }

