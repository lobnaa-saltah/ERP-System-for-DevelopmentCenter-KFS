using Microsoft.EntityFrameworkCore;

namespace MyERP.Web.Areas.Admin.Models.SeedData
{
    public class FunctionalGroupSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FunctionalGroup>().HasData(
                // مجموعة الوظائف التخصصية (QualitativeGroupId = 1)
                new FunctionalGroup { Id = 1, QualitativeGroupId = 1, Code = "MGMT", Name = "وظائف الإدارة", Description = "وظائف تتعلق بالإدارة العليا والمتوسطة", IsActive = true },
                new FunctionalGroup { Id = 2, QualitativeGroupId = 1, Code = "FIN", Name = "وظائف التمويل والمحاسبة", Description = "وظائف المحاسبة والمالية", IsActive = true },
                new FunctionalGroup { Id = 3, QualitativeGroupId = 1, Code = "LAW", Name = "وظائف القانون", Description = "وظائف استشارية وقانونية", IsActive = true },
                new FunctionalGroup { Id = 4, QualitativeGroupId = 1, Code = "ENG", Name = "وظائف الهندسة", Description = "وظائف هندسية متعددة التخصصات", IsActive = true },
                new FunctionalGroup { Id = 5, QualitativeGroupId = 1, Code = "MED", Name = "وظائف الطب", Description = "وظائف طبية وصحية", IsActive = true },
                new FunctionalGroup { Id = 6, QualitativeGroupId = 1, Code = "EDU", Name = "وظائف التعليم", Description = "وظائف تدريسية وتربوية", IsActive = true },
                new FunctionalGroup { Id = 7, QualitativeGroupId = 1, Code = "IT", Name = "وظائف تكنولوجيا المعلومات", Description = "وظائف الحاسب وتقنية المعلومات", IsActive = true },
                new FunctionalGroup { Id = 8, QualitativeGroupId = 1, Code = "RSRCH", Name = "وظائف البحث العلمي", Description = "وظائف البحث والتطوير العلمي", IsActive = true },
                new FunctionalGroup { Id = 9, QualitativeGroupId = 1, Code = "STAT", Name = "وظائف الإحصاء", Description = "وظائف جمع وتحليل البيانات الإحصائية", IsActive = true },
                new FunctionalGroup { Id = 10, QualitativeGroupId = 1, Code = "MEDIA", Name = "وظائف الإعلام", Description = "وظائف إعلامية وصحفية", IsActive = true },
                new FunctionalGroup { Id = 11, QualitativeGroupId = 1, Code = "PLAN", Name = "وظائف التخطيط والمتابعة", Description = "وظائف التخطيط والمتابعة الإدارية", IsActive = true },
                new FunctionalGroup { Id = 12, QualitativeGroupId = 1, Code = "DEV", Name = "وظائف التنمية الإدارية", Description = "وظائف تطوير وإدارة الموارد البشرية", IsActive = true },

                // مجموعة الوظائف الفنية (QualitativeGroupId = 2)
                new FunctionalGroup { Id = 13, QualitativeGroupId = 2, Code = "TECH", Name = "الفنيين", Description = "وظائف تعتمد على مهارات فنية متخصصة", IsActive = true },
                new FunctionalGroup { Id = 14, QualitativeGroupId = 2, Code = "ASSIST", Name = "المساعدين الفنيين", Description = "مساندة الفنيين في أعمالهم", IsActive = true },
                new FunctionalGroup { Id = 15, QualitativeGroupId = 2, Code = "INSPECT", Name = "المراقبين", Description = "وظائف المراقبة الفنية", IsActive = true },
                new FunctionalGroup { Id = 16, QualitativeGroupId = 2, Code = "OP", Name = "المشغلين", Description = "وظائف التشغيل الفني", IsActive = true },
                new FunctionalGroup { Id = 17, QualitativeGroupId = 2, Code = "DRAFT", Name = "الرسامين", Description = "وظائف الرسم الفني", IsActive = true },
                new FunctionalGroup { Id = 18, QualitativeGroupId = 2, Code = "TECH_WR", Name = "الكتّاب الفنيين", Description = "وظائف كتابة التقارير الفنية", IsActive = true },

                // مجموعة الوظائف المكتبية (QualitativeGroupId = 3)
                new FunctionalGroup { Id = 19, QualitativeGroupId = 3, Code = "CLERK", Name = "الكتّاب", Description = "وظائف إدخال البيانات والكتابة المكتبية", IsActive = true },
                new FunctionalGroup { Id = 20, QualitativeGroupId = 3, Code = "STORE", Name = "أمناء المخازن", Description = "وظائف حفظ وإدارة المخازن", IsActive = true },
                new FunctionalGroup { Id = 21, QualitativeGroupId = 3, Code = "SEC", Name = "السكرتارية", Description = "وظائف السكرتارية والدعم الإداري", IsActive = true },
                new FunctionalGroup { Id = 22, QualitativeGroupId = 3, Code = "HR", Name = "شئون العاملين", Description = "وظائف الموارد البشرية", IsActive = true },
                new FunctionalGroup { Id = 23, QualitativeGroupId = 3, Code = "RECORDS", Name = "السجلات", Description = "وظائف حفظ السجلات والمحفوظات", IsActive = true },
                new FunctionalGroup { Id = 24, QualitativeGroupId = 3, Code = "ARCHIVE", Name = "المحفوظات", Description = "وظائف الأرشفة وحفظ الوثائق", IsActive = true },
                new FunctionalGroup { Id = 25, QualitativeGroupId = 3, Code = "DATA", Name = "إدخال البيانات", Description = "وظائف إدخال البيانات على أنظمة الحاسب", IsActive = true },

                // مجموعة الوظائف الحرفية (QualitativeGroupId = 4)
                new FunctionalGroup { Id = 26, QualitativeGroupId = 4, Code = "CARP", Name = "النجارة", Description = "وظائف النجارة والأعمال الخشبية", IsActive = true },
                new FunctionalGroup { Id = 27, QualitativeGroupId = 4, Code = "PLUMB", Name = "السباكة", Description = "وظائف السباكة والصرف الصحي", IsActive = true },
                new FunctionalGroup { Id = 28, QualitativeGroupId = 4, Code = "ELEC", Name = "الكهرباء", Description = "وظائف الكهرباء والصيانة الكهربائية", IsActive = true },
                new FunctionalGroup { Id = 29, QualitativeGroupId = 4, Code = "MAINT", Name = "الصيانة", Description = "وظائف الصيانة العامة", IsActive = true },
                new FunctionalGroup { Id = 30, QualitativeGroupId = 4, Code = "OPER", Name = "التشغيل", Description = "وظائف التشغيل الفني", IsActive = true },
                new FunctionalGroup { Id = 31, QualitativeGroupId = 4, Code = "SEC_TECH", Name = "الحراسة الفنية", Description = "وظائف الحراسة الفنية", IsActive = true },

                // مجموعة الوظائف الخدمية المعاونة (QualitativeGroupId = 5)
                new FunctionalGroup { Id = 32, QualitativeGroupId = 5, Code = "WORKER", Name = "العمال", Description = "وظائف العمالة العامة", IsActive = true },
                new FunctionalGroup { Id = 33, QualitativeGroupId = 5, Code = "MESSENGER", Name = "السعاة", Description = "وظائف التوصيل والسعاة", IsActive = true },
                new FunctionalGroup { Id = 34, QualitativeGroupId = 5, Code = "BEDS", Name = "الفراشين", Description = "وظائف النظافة الداخلية والمساعدة", IsActive = true },
                new FunctionalGroup { Id = 35, QualitativeGroupId = 5, Code = "CLEAN", Name = "عمال النظافة", Description = "وظائف تنظيف المباني والمرافق", IsActive = true },
                new FunctionalGroup { Id = 36, QualitativeGroupId = 5, Code = "AUX", Name = "عمال الخدمات المعاونة", Description = "وظائف الدعم المساعد", IsActive = true }
            );
        }
    }
}
