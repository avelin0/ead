using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EAD.Models
{
    public class Student
    {
        [Key]
        public string UserId { get; set; }
        
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

       
    }
}