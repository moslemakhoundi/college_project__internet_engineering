using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    class Product
    {
        [Key]
        int Id { get; set; }
        int CategoryId { get; set; }
        int BrandId { get; set; }
        string ModelName { get; set; }
        string Description { get; set; }
    }
}
