using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class TenancyRegister
    {
        [Required(ErrorMessage ="Please inform the name!")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please inform the address!")]
        public string Address { get; set; }
    }
}
