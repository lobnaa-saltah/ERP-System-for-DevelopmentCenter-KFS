using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations;
namespace MyERP.Web.Areas.Admin.Models
{
    public class QualificationType : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
