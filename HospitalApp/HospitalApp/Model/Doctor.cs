
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HospitalApp.Model
{
    class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int WorkExperience { get; set; }
        public string Degree { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public int DepartmentId { get; set; }
    }
}
