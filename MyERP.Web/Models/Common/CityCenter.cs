using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Models.Common
{
    public class CityCenter : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int GovernorateId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Type { get; set; } // center | city



        // Navigation
        public Governorate Governorate { get; set; }
        public ICollection<LocalUnit> LocalUnits { get; set; }
        public ICollection<Village> Villages { get; set; }
    }
}
