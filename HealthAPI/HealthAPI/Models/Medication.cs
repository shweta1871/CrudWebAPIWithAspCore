using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAPI.Models
{
    public class Medication
    {
        [Key]
        public string Name { get; set; }  // e.g name of medicine disprin
        public string Doses { get; set; } // e.g 2 tablets one in a day
    }
}
