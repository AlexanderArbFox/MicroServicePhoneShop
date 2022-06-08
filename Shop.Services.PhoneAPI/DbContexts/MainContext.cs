using Microsoft.EntityFrameworkCore;
using Shop.Services.PhoneAPI.Models;

namespace Shop.Services.PhoneAPI.DbContexts
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

        }
        public DbSet<Goods> Goods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            

            modelBuilder.Entity<Goods>().HasData(new Goods
            {
                GoodId = 1,
                Name = "Iphone 11",
                Price = 45000,
                Description = "Apple iPhone 11 поражает возможностями.",
                ImageUrl = "https://storage.yandexcloud.net/foxstoragearbfirst/Phones/11.png",
                CategoryName = "Phone"
            });
            modelBuilder.Entity<Goods>().HasData(new Goods
            {
                GoodId = 2,
                Name = "Iphone 12",
                Price = 50000,
                Description = "Apple iPhone 12 поражает возможностями. Высокопроизводительный процессор от Apple A14 Bionic для iPhone.<br/>Обновленная система двух камер 12 Мп: сверхширокоугольная и широкоугольная.",
                ImageUrl = "https://storage.yandexcloud.net/foxstoragearbfirst/Phones/12.png",
                CategoryName = "Phone"
            });
            modelBuilder.Entity<Goods>().HasData(new Goods
            {
                GoodId = 3,
                Name = "Iphone 13",
                Price = 61000.99M,
                Description = "Невероятно быстрый и энергоэффективный новый процессор A15 Bionic в Apple iPhone 13 512GB обеспечивает работу режима «Киноэффект», Фотографических стилей и других функций.<br/>Secure Enclave защищает персональные данные, включая Face ID и контакты.",
                ImageUrl = "https://storage.yandexcloud.net/foxstoragearbfirst/Phones/13.png",
                CategoryName = "Phone"
            });
            modelBuilder.Entity<Goods>().HasData(new Goods
            {
                GoodId = 4,
                Name = "Iphone 14",
                Price = 99000.05M,
                Description = "Безграничный экран",
                ImageUrl = "https://storage.yandexcloud.net/foxstoragearbfirst/Phones/14.png",
                CategoryName = "Phone"
            });
        }
    }
}
