using MyERP.Web.Areas.HR.Models;
using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Areas.Admin.Models
{
    public class EmploymentType : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsCivilServiceLaw { get; set; }
        public bool HasContractPeriod { get; set; }
        public int? DurationInMonths { get; set; }

        public bool HasPension { get; set; }
        public bool HasAnnualIncrease { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
