using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int pid { get; set; }
        public string pname { get; set; }
        public float price { get; set; }
        public string pdesc { get; set; }

    }
}
