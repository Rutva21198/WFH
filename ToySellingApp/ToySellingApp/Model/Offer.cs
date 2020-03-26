using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToySellingApp.Model
{
    class Offer
    {
        [Key]
        public int OfferId { get; set; }
        public int MinAmount { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public int CompanyId { get; set; }
        public float Discount { get; set; }
    }
}
