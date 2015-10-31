using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD.Models
{
    public enum Level
    {
        begginer, intermidiate, advanced
    }

    public class Course
    {
        public int CourseID { get; set; }

        public string CreatorID { get; set; }

        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public Level Level { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}