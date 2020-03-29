namespace CompanyApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vProjectAllocationDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Business { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Employee { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Gender { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AllocationId { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Task { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectId { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectTitle { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(30)]
        public string StartDate { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(30)]
        public string EndDate { get; set; }
    }
}
