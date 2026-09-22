using Microsoft.EntityFrameworkCore;

namespace MyERP.Web.Areas.Admin.Models.SeedData
{
    public class QualificationTypeSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QualificationType>().HasData(
                new QualificationType { Id = 1, Name = "دكتوراه", Description = "أعلى مؤهل أكاديمي", IsActive = true },
                new QualificationType { Id = 2, Name = "ماجستير", Description = "درجة الدراسات العليا بعد البكالوريوس", IsActive = true },
                new QualificationType { Id = 3, Name = "بكالوريوس", Description = "درجة البكالوريوس الجامعية", IsActive = true },
                new QualificationType { Id = 4, Name = "دبلوم فوق المتوسط", Description = "دبلوم بعد الثانوية العامة لمدة سنتين", IsActive = true },
                new QualificationType { Id = 5, Name = "دبلوم فني", Description = "دبلوم فني متخصص", IsActive = true },
                new QualificationType { Id = 6, Name = "الثانوية العامة", Description = "الشهادة الثانوية العامة", IsActive = true },
                new QualificationType { Id = 7, Name = "الشهادة الإعدادية", Description = "الشهادة الإعدادية", IsActive = true },
                new QualificationType { Id = 8, Name = "الشهادة الابتدائية", Description = "الشهادة الابتدائية", IsActive = true }
            );
        }
    }
}
