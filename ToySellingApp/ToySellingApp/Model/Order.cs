using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToySellingApp.Model
{
    class Order
    {
        [Key]
        public int OderId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(ToyProductionId))]
        public int ToyProductionId { get; set; }
        public int Quantity { get; set; }
        [ForeignKey(nameof(AddressId))]
        public int AddressId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
