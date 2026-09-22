using Microsoft.EntityFrameworkCore;

namespace MyERP.Web.Areas.Admin.Models.SeedData
{
    public class EmploymentTypeSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            
                modelBuilder.Entity<EmploymentType>().HasData(
                    new EmploymentType
                    {
                        Id = 1,
                        Name = "تثبيت",
                        Description = "تعيين دائم خاضع لقانون الخدمة المدنية",
                        IsCivilServiceLaw = true,
                        HasContractPeriod = false,
                        DurationInMonths = null,
                        HasPension = true,
                        HasAnnualIncrease = true
                    },
                    new EmploymentType
                    {
                        Id = 2,
                        Name = "تعاقد بمدة",
                        Description = "تعاقد محدد المدة وفق احتياجات الجهة",
                        IsCivilServiceLaw = true,
                        HasContractPeriod = true,
                        DurationInMonths = 12,
                        HasPension = false,
                        HasAnnualIncrease = false
                    },
                    new EmploymentType
                    {
                        Id = 3,
                        Name = "تعاقد بند 2/3",
                        Description = "تعاقد وفق البندين 2 و3 من الموازنة",
                        IsCivilServiceLaw = false,
                        HasContractPeriod = true,
                        DurationInMonths = 12,
                        HasPension = false,
                        HasAnnualIncrease = false
                    },
                    new EmploymentType
                    {
                        Id = 4,
                        Name = "بالأجر اليومي",
                        Description = "عمل مؤقت يُحاسب بالأجر اليومي",
                        IsCivilServiceLaw = false,
                        HasContractPeriod = false,
                        DurationInMonths = null,
                        HasPension = false,
                        HasAnnualIncrease = false
                    },
                    new EmploymentType
                    {
                        Id = 5,
                        Name = "نقل",
                        Description = "نقل موظف من جهة حكومية إلى جهة أخرى",
                        IsCivilServiceLaw = true,
                        HasContractPeriod = false,
                        DurationInMonths = null,
                        HasPension = true,
                        HasAnnualIncrease = true
                    },
                    new EmploymentType
                    {
                        Id = 6,
                        Name = "ندب",
                        Description = "ندب مؤقت لأداء عمل بجهة أخرى",
                        IsCivilServiceLaw = true,
                        HasContractPeriod = true,
                        DurationInMonths = 12,
                        HasPension = true,
                        HasAnnualIncrease = true
                    },
                    new EmploymentType
                    {
                        Id = 7,
                        Name = "إعارة",
                        Description = "إعارة للعمل خارج الجهة أو خارج الدولة",
                        IsCivilServiceLaw = true,
                        HasContractPeriod = true,
                        DurationInMonths = 12,
                        HasPension = false,
                        HasAnnualIncrease = false
                    },
                    new EmploymentType
                    {
                        Id = 8,
                        Name = "استعانة",
                        Description = "الاستعانة بخبرات أو عمالة مؤقتة دون تعيين",
                        IsCivilServiceLaw = false,
                        HasContractPeriod = true,
                        DurationInMonths = 6,
                        HasPension = false,
                        HasAnnualIncrease = false
                    }
                );
            
        }
    }
}
