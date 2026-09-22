using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Areas.HR.Models
{
    public class EmployeeFamily : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required, MaxLength(200)]
        public string FullName { get; set; }

        [Required, MaxLength(50)]
        public string RelationshipType { get; set; }
        // Father, Mother, Wife, Son, Daughter

        [MaxLength(50)]
        public string HealthStatus { get; set; }

        public bool IsDisabled { get; set; }

        [MaxLength(20)]
        public string NationalId { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        // Navigation
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
    }
}
