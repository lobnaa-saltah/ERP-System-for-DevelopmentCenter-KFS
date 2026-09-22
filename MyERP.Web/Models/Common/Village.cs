using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Models.Common
{
    public class Village 
    {
        [Key]
        public int Id { get; set; }



        [Required]
        public int LocalUnitId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation Properties


        [ForeignKey(nameof(LocalUnitId))]
        public LocalUnit LocalUnit { get; set; }
    }
}
