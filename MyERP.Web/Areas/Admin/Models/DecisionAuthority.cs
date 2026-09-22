using MyERP.Web.Models;
using MyERP.Web.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Areas.Admin.Models
{
    public class DecisionAuthority : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual ICollection<Decision> Decisions { get; set; }
    }
}
