using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToySellingApp.Model
{
    class CustomerAddress
    {
        [Key]
        public int AddressId { get; set; }
        public string Address { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public int CustomerId { get; set; }
    }
}
