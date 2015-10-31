using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EAD.Models
{
    public class Topico
    {
        [Key]
        public int TopicoID { get; set; }

        public string Name { get; set; }

        public DateTime CreationDate { get; set; }
    }
}