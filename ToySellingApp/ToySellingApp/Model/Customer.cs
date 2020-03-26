using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToySellingApp.Model
{
    class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int MobileNo { get; set; }
        public string City { get; set; }

    }
}
