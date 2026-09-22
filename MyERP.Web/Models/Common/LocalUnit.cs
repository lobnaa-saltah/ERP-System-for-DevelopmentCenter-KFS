using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Models.Common
{
    public class LocalUnit : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CityCenterId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        // Navigation Properties
        [ForeignKey(nameof(CityCenterId))]
        public CityCenter CityCenter { get; set; }

        public ICollection<Village> Villages { get; set; }
    
}
}
