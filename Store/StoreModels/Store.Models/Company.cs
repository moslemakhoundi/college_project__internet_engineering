using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    class Company
    {
        [Key]
        int Id { get; set; }
        string PersianName { get; set; }
        string EnglishName { get; set; }
        int CountryId { get; set; }
    }
}
