using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations;
namespace MyERP.Web.Areas.Admin.Models
{
    public class JobGrade : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Code { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        public int GradeLevel { get; set; }

        public string Description { get; set; }

        public int YearsNo { get; set; }

        public bool IsActive { get; set; } = true;

    }
}
