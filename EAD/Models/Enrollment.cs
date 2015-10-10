using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EAD.Models
{
    public enum Status
    {
        Ativo,Completado,Ativado
    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Status Status { get; set; }

        public string StudentId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

    }
}