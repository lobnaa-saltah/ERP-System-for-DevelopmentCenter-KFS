using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace MyERP.Web.Areas.Admin.Models
{
    public class JobTitle : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int FunctionalGroupId { get; set; }

        [Required, MaxLength(50)]
        public string Code { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation
        [ForeignKey(nameof(FunctionalGroupId))]
        public FunctionalGroup FunctionalGroup { get; set; }
    }
}
