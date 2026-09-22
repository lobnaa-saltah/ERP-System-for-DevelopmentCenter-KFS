using Microsoft.EntityFrameworkCore;

namespace MyERP.Web.Areas.Admin.Models.SeedData
{
    public class QualitativeGroupSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QualitativeGroup>().HasData(
                new QualitativeGroup
                {
                    Id = 1,
                    Code = "SPEC",
                    Name = "مجموعة الوظائف التخصصية",
                    Description = "تشمل الوظائف التي تتطلب مؤهلات علمية أو تخصصية محددة",
                    IsActive = true
                },
                new QualitativeGroup
                {
                    Id = 2,
                    Code = "TECH",
                    Name = "مجموعة الوظائف الفنية",
                    Description = "تشمل الوظائف الفنية والتقنية التي تعتمد على المهارات التطبيقية",
                    IsActive = true
                },
                new QualitativeGroup
                {
                    Id = 3,
                    Code = "CLERK",
                    Name = "مجموعة الوظائف المكتبية",
                    Description = "تشمل الأعمال الإدارية والمكتبية والدعم التنظيمي",
                    IsActive = true
                },
                new QualitativeGroup
                {
                    Id = 4,
                    Code = "CRAFT",
                    Name = "مجموعة الوظائف الحرفية",
                    Description = "تشمل الوظائف التي تعتمد على الحرف والصناعات اليدوية",
                    IsActive = true
                },
                new QualitativeGroup
                {
                    Id = 5,
                    Code = "SERVICE",
                    Name = "مجموعة الوظائف الخدمية المعاونة",
                    Description = "تشمل الوظائف الخدمية المساعدة والداعمة لبيئة العمل",
                    IsActive = true
                }
            );
        }
    }
}
