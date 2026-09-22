using Microsoft.EntityFrameworkCore;
using MyERP.Web.Areas.Admin.Models;
using MyERP.Web.Models.Common;

namespace MyERP.Web.Models.SeedDataModels
{
    public class GovernorateSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // تمثل DateTime.Now وقت إنشاء الميجريشن
            var createdAt = new DateTime(2025, 01, 01, 12, 00, 00);

            modelBuilder.Entity<Governorate>().HasData(
                new Governorate { Id = 100, Name = "كفر الشيخ", Code = "047", CreatedAt = createdAt },
                new Governorate { Id = 121, Name = "القاهرة", Code = "02", CreatedAt = createdAt },

                new Governorate { Id = 101, Name = "الجيزة", Code = "02", CreatedAt = createdAt },
                new Governorate { Id = 102, Name = "الإسكندرية", Code = "03", CreatedAt = createdAt },
                new Governorate { Id = 103, Name = "الدقهلية", Code = "050", CreatedAt = createdAt },
                new Governorate { Id = 104, Name = "البحر الأحمر", Code = "065", CreatedAt = createdAt },
                new Governorate { Id = 105, Name = "البحيرة", Code = "045", CreatedAt = createdAt },
                new Governorate { Id = 106, Name = "الفيوم", Code = "084", CreatedAt = createdAt },
                new Governorate { Id = 107, Name = "الغربية", Code = "040", CreatedAt = createdAt },
                new Governorate { Id = 108, Name = "الإسماعيلية", Code = "064", CreatedAt = createdAt },
                new Governorate { Id = 109, Name = "المنوفية", Code = "048", CreatedAt = createdAt },
                new Governorate { Id = 110, Name = "المنيا", Code = "086", CreatedAt = createdAt },
                new Governorate { Id = 111, Name = "القليوبية", Code = "013", CreatedAt = createdAt },
                new Governorate { Id = 112, Name = "الوادي الجديد", Code = "092", CreatedAt = createdAt },
                new Governorate { Id = 113, Name = "السويس", Code = "062", CreatedAt = createdAt },
                new Governorate { Id = 114, Name = "اسوان", Code = "097", CreatedAt = createdAt },
                new Governorate { Id = 115, Name = "اسيوط", Code = "088", CreatedAt = createdAt },
                new Governorate { Id = 116, Name = "بني سويف", Code = "082", CreatedAt = createdAt },
                new Governorate { Id = 117, Name = "بورسعيد", Code = "066", CreatedAt = createdAt },
                new Governorate { Id = 118, Name = "دمياط", Code = "057", CreatedAt = createdAt },
                new Governorate { Id = 119, Name = "الشرقية", Code = "055", CreatedAt = createdAt },
                new Governorate { Id = 120, Name = "جنوب سيناء", Code = "069", CreatedAt = createdAt },
                new Governorate { Id = 122, Name = "مطروح", Code = "046", CreatedAt = createdAt },
                new Governorate { Id = 123, Name = "الأقصر", Code = "095", CreatedAt = createdAt },
                new Governorate { Id = 124, Name = "قنا", Code = "096", CreatedAt = createdAt },
                new Governorate { Id = 125, Name = "شمال سيناء", Code = "068", CreatedAt = createdAt },
                new Governorate { Id = 126, Name = "سوهاج", Code = "093", CreatedAt = createdAt }
            );
        }
    }
}
