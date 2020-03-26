using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToySellingApp.Model
{
    class Toys
    {
        [Key]
        public int ToyId { get; set; }
        public string Toy { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(ToyCategoryId))]
        public int ToyCategoryId { get; set; }

    }
}
