namespace CompanyApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjectAllocation")]
    public partial class ProjectAllocation
    {
        [Key]
        public int AllocationId { get; set; }

        public int EmployeeId { get; set; }

        public int ProjectId { get; set; }

        public int BusinessId { get; set; }

        [Required]
        [StringLength(50)]
        public string Task { get; set; }
    }
}
