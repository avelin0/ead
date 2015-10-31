using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EAD.Models
{
    public class EadContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Topico> Topicoes { get; set; }

        public System.Data.Entity.DbSet<EAD.Models.Pagina> Paginas { get; set; }
    }
}