using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Services.PhoneAPI.Migrations
{
    public partial class addPhoneInDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "GoodId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Phone", "Apple iPhone 11 поражает возможностями.", "https://storage.yandexcloud.net/foxstoragearbfirst/Phones/11.png", "Iphone 11", 45000m },
                    { 2, "Phone", "Apple iPhone 12 поражает возможностями. Высокопроизводительный процессор от Apple A14 Bionic для iPhone.<br/>Обновленная система двух камер 12 Мп: сверхширокоугольная и широкоугольная.", "https://storage.yandexcloud.net/foxstoragearbfirst/Phones/12.png", "Iphone 12", 50000m },
                    { 3, "Phone", "Невероятно быстрый и энергоэффективный новый процессор A15 Bionic в Apple iPhone 13 512GB обеспечивает работу режима «Киноэффект», Фотографических стилей и других функций.<br/>Secure Enclave защищает персональные данные, включая Face ID и контакты.", "https://storage.yandexcloud.net/foxstoragearbfirst/Phones/13.png", "Iphone 13", 61000.99m },
                    { 4, "Phone", "Безграничный экран", "https://storage.yandexcloud.net/foxstoragearbfirst/Phones/14.png", "Iphone 14", 99000.05m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "GoodId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "GoodId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "GoodId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "GoodId",
                keyValue: 4);
        }
    }
}
