namespace CompanyApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool Gender { get; set; }

        [Required]
        [StringLength(30)]
        public string DateOfBirth { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }
    }
}
