
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HospitalApp.Model
{
    class Departments
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Department { get; set; }
    }
}
