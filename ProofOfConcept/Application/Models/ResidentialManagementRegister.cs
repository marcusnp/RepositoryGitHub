using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class ResidentialManagementRegister
    {
        [Required(ErrorMessage = "Please inform the residential management!")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please inform the description!")]
        public string Description { get; set; }


    }
}
