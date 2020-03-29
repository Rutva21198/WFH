namespace CompanyApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeLeave")]
    public partial class EmployeeLeave
    {
        [Key]
        public int LeaveId { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string LeaveReason { get; set; }

        [Required]
        [StringLength(30)]
        public string StartDate { get; set; }

        [Required]
        [StringLength(30)]
        public string EndDate { get; set; }
    }
}
