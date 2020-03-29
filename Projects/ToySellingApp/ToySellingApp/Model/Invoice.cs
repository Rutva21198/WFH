using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToySellingApp.Model
{
    class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public int OrderId { get; set; }
        [ForeignKey(nameof(OfferId))]
        public int OfferId { get; set; }
        public float FinalPrice { get; set; }
        public float Price { get; set; }

    }
}
