using MyERP.Web.Areas.HR.Models;
using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Areas.Admin.Models
{
    public class ServiceTerminationType : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Code { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool RequiresNoticePeriod { get; set; }

        public bool IsActive { get; set; } = true;

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public int? DeletedBy { get; set; }

        // Navigation
        public ICollection<ServiceTerminationRequest> ServiceTerminationRequests { get; set; }
    }
}
