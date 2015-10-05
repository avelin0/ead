using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EAD.Models
{
    public class CourseViewModel
    {
        [Required(ErrorMessage="You must enter a name")]
        [Display(Name="Course Name")]
        public string Name { get; set; }

        [Required(ErrorMessage="You must choose a level")]
        [Display(Name="Course level")]
        public Level Level { get; set; }
    }
}