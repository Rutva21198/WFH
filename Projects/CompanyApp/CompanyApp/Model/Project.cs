namespace CompanyApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Project
    {
        public int ProjectId { get; set; }

        public int ProjectTitle { get; set; }

        [Required]
        [StringLength(30)]
        public string StartDate { get; set; }

        [Required]
        [StringLength(30)]
        public string EndDate { get; set; }
    }
}
