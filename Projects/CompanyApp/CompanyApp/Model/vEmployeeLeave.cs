namespace CompanyApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vEmployeeLeave")]
    public partial class vEmployeeLeave
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LeaveId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string LeaveReason { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string StartDate { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string EndDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
