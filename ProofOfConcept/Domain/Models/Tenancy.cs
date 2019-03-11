using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models

{

    [Table("Tenancy", Schema = "dbo")]
    public class Tenancy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Tenancy Id")]
        public int TenancyId { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Name of Tenacy")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(15)")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Address Tenancy")]
        public string Address { get; set; }

    }
}
