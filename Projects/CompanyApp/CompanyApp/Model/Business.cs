namespace CompanyApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Business
    {
        public int BusinessId { get; set; }

        [Required]
        [StringLength(50)]
        public string BusinessName { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }
    }
}
