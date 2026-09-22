using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Areas.Admin.Models
{
    public class QualitativeGroup : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual ICollection<FunctionalGroup> FunctionalGroups { get; set; }
    }
}
