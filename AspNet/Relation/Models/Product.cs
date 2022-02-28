using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        public string ProductName { get; set; }

        public int CustomerID { get; set; }
        public virtual Customer Customers { get; set; }
    }
}
