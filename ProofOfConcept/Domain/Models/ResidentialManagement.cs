using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("ResidentialManagement", Schema = "dbo")]
    public class ResidentialManagement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Residential Management Id")]
        public int ResidentialManagementId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Name of Residential Management")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(150)")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [ForeignKey("TenancyInfo")]
        [Required]
        public int TenancyId { get; set; }

        [NotMapped]
        public string TenancyName { get; set; }

        public virtual Tenancy TenancyInfo { get; set; }
    }
}
