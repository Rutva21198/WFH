using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToySellingApp.Model
{
    class ToyProduction
    {
        [Key]
        public int ToyProductionId { get; set; }
        [ForeignKey(nameof(ToyId))]
        public int ToyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public int CompanyId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
