using Microsoft.EntityFrameworkCore;
using MyERP.Web.Models.Common;

namespace MyERP.Web.Models.SeedDataModels
{
    public class CityCentersSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // تمثل DateTime.Now وقت إنشاء الميجريشن
            var createdAt = new DateTime(2025, 01, 01, 12, 00, 00);

            modelBuilder.Entity<CityCenter>().HasData(
                new CityCenter { Id = 1, Name = "كفر الشيخ", GovernorateId = 100, Type = "مركز", CreatedAt = createdAt },
                new CityCenter { Id = 1, Name = "دسوق", GovernorateId = 100, Type = "مركز", CreatedAt = createdAt });
               
        }
    }
    }
