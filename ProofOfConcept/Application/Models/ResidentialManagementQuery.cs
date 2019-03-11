using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models
{
    public class ResidentialManagementQuery
    {
        public int ResidentialManagementId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TenancyId { get; set; }
        public string TenancyName { get; set; }
    }
}
