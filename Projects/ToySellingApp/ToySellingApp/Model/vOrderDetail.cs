using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToySellingApp.Model
{
    class vOrderDetail
    {
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int OderId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int CustomerId { get; set; }
        public string Address { get; set; }
        public int ToyProductionId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
