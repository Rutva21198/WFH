using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToySellingApp.Model
{
    class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
    }
}
