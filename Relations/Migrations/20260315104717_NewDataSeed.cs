using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFP48.Migrations
{
    /// <inheritdoc />
    public partial class NewDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "my_categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("020c4989-67a4-4e4b-afbc-1d39a0e5d00b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Audio Equipment" },
                    { new Guid("0d5d102d-e7b0-4a2e-a4fa-076deb014547"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mice" },
                    { new Guid("20f8768c-ab73-4cc6-8ebb-cc58fe00ad4d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wearable Technology" },
                    { new Guid("34c0032d-9a67-40a8-b6c4-8c0d15b23650"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Computers" },
                    { new Guid("4af1ce03-b37c-40a5-8462-28494820f53f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Monitors" },
                    { new Guid("561ac3ea-6374-4b26-b422-4c619bdc26fa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Smartphones" },
                    { new Guid("6c179026-9a44-4eca-b75a-811ebb8a577a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Keyboards" },
                    { new Guid("89b21758-c1c1-469d-86f9-a3a8705f593c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Cameras & Photography" },
                    { new Guid("89bd4978-0429-4913-8c74-843f24e35cb6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Laptops" },
                    { new Guid("8e1b8de7-421b-4020-ac41-3e96b01ba8d3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "TV-sets" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "DeletedAt", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1279005e-64d9-4509-bbc0-59a979b55f82"), new Guid("020c4989-67a4-4e4b-afbc-1d39a0e5d00b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sony WH-1000XM5 Headphones", 349.0 },
                    { new Guid("217a73c9-4f13-455b-8daa-91bb194beb5a"), new Guid("20f8768c-ab73-4cc6-8ebb-cc58fe00ad4d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Oura Ring Gen3", 299.0 },
                    { new Guid("41644484-cebf-4f2c-b9b4-f42d4d7f5076"), new Guid("20f8768c-ab73-4cc6-8ebb-cc58fe00ad4d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Garmin Venu Sq", 249.0 },
                    { new Guid("443414ba-f852-4733-92e6-ded212c77fe7"), new Guid("020c4989-67a4-4e4b-afbc-1d39a0e5d00b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "JBL Charge 5 Speaker", 179.0 },
                    { new Guid("923df676-5088-4289-8ddc-050cd7ebfcd0"), new Guid("20f8768c-ab73-4cc6-8ebb-cc58fe00ad4d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Samsung Galaxy Watch 6", 299.0 },
                    { new Guid("a1111111-1111-4aaa-8aaa-111111111111"), new Guid("561ac3ea-6374-4b26-b422-4c619bdc26fa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "iPhone 15", 999.99000000000001 },
                    { new Guid("a1111111-1111-4aaa-8aaa-111111111112"), new Guid("561ac3ea-6374-4b26-b422-4c619bdc26fa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Samsung Galaxy S24", 899.99000000000001 },
                    { new Guid("a1111111-1111-4aaa-8aaa-111111111113"), new Guid("561ac3ea-6374-4b26-b422-4c619bdc26fa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Google Pixel 8", 799.99000000000001 },
                    { new Guid("a1111111-1111-4aaa-8aaa-111111111114"), new Guid("561ac3ea-6374-4b26-b422-4c619bdc26fa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xiaomi 14", 699.99000000000001 },
                    { new Guid("a1111111-1111-4aaa-8aaa-111111111115"), new Guid("561ac3ea-6374-4b26-b422-4c619bdc26fa"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OnePlus 12", 749.99000000000001 },
                    { new Guid("a92c46dc-2037-44ae-9cc5-0ba08e07b401"), new Guid("20f8768c-ab73-4cc6-8ebb-cc58fe00ad4d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fitbit Charge 6", 159.0 },
                    { new Guid("aacc2981-b45b-457b-9b7a-22dff703400f"), new Guid("89b21758-c1c1-469d-86f9-a3a8705f593c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "GoPro HERO12 Black", 399.0 },
                    { new Guid("aacd266f-bf5c-4ac0-93ba-739c937f8c22"), new Guid("89b21758-c1c1-469d-86f9-a3a8705f593c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fujifilm Instax Mini 12", 79.0 },
                    { new Guid("b2222222-2222-4bbb-8bbb-222222222221"), new Guid("34c0032d-9a67-40a8-b6c4-8c0d15b23650"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Dell OptiPlex 7010", 1200.0 },
                    { new Guid("b2222222-2222-4bbb-8bbb-222222222222"), new Guid("34c0032d-9a67-40a8-b6c4-8c0d15b23650"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "HP Pavilion Desktop", 950.0 },
                    { new Guid("b2222222-2222-4bbb-8bbb-222222222223"), new Guid("34c0032d-9a67-40a8-b6c4-8c0d15b23650"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lenovo ThinkCentre", 1100.0 },
                    { new Guid("b2222222-2222-4bbb-8bbb-222222222224"), new Guid("34c0032d-9a67-40a8-b6c4-8c0d15b23650"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "iMac 24", 1800.0 },
                    { new Guid("b2222222-2222-4bbb-8bbb-222222222225"), new Guid("34c0032d-9a67-40a8-b6c4-8c0d15b23650"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Asus ExpertCenter", 1050.0 },
                    { new Guid("b48fa24b-6876-4404-bd21-6e99cf5550ec"), new Guid("020c4989-67a4-4e4b-afbc-1d39a0e5d00b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Blue Yeti USB Microphone", 129.0 },
                    { new Guid("bffdfb7d-73c9-4ab8-b9eb-34a63065427c"), new Guid("020c4989-67a4-4e4b-afbc-1d39a0e5d00b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Apple AirPods Pro(2nd Gen)", 249.0 },
                    { new Guid("c3333333-3333-4ccc-8ccc-333333333331"), new Guid("89bd4978-0429-4913-8c74-843f24e35cb6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "MacBook Air M3", 1500.0 },
                    { new Guid("c3333333-3333-4ccc-8ccc-333333333332"), new Guid("89bd4978-0429-4913-8c74-843f24e35cb6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Dell XPS 15", 1700.0 },
                    { new Guid("c3333333-3333-4ccc-8ccc-333333333333"), new Guid("89bd4978-0429-4913-8c74-843f24e35cb6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HP Spectre x360", 1600.0 },
                    { new Guid("c3333333-3333-4ccc-8ccc-333333333334"), new Guid("89bd4978-0429-4913-8c74-843f24e35cb6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lenovo Legion 5", 1400.0 },
                    { new Guid("c3333333-3333-4ccc-8ccc-333333333335"), new Guid("89bd4978-0429-4913-8c74-843f24e35cb6"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Asus ROG Zephyrus", 1900.0 },
                    { new Guid("cd5c791f-c0cc-467f-bd96-40624a302f7d"), new Guid("20f8768c-ab73-4cc6-8ebb-cc58fe00ad4d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Apple Watch Series 9", 399.0 },
                    { new Guid("d31f4cad-418c-4792-89f6-7a5f3cd65afb"), new Guid("89b21758-c1c1-469d-86f9-a3a8705f593c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Canon EOS R50", 829.0 },
                    { new Guid("d4444444-4444-4ddd-8ddd-444444444441"), new Guid("8e1b8de7-421b-4020-ac41-3e96b01ba8d3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Samsung QLED 55", 1300.0 },
                    { new Guid("d4444444-4444-4ddd-8ddd-444444444442"), new Guid("8e1b8de7-421b-4020-ac41-3e96b01ba8d3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LG OLED C3", 2100.0 },
                    { new Guid("d4444444-4444-4ddd-8ddd-444444444443"), new Guid("8e1b8de7-421b-4020-ac41-3e96b01ba8d3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sony Bravia XR", 2000.0 },
                    { new Guid("d4444444-4444-4ddd-8ddd-444444444444"), new Guid("8e1b8de7-421b-4020-ac41-3e96b01ba8d3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Philips Ambilight 65", 1700.0 },
                    { new Guid("d4444444-4444-4ddd-8ddd-444444444445"), new Guid("8e1b8de7-421b-4020-ac41-3e96b01ba8d3"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TCL 4K UHD", 900.0 },
                    { new Guid("d5276fcc-bf5e-4bec-9d61-e67f2906db69"), new Guid("89b21758-c1c1-469d-86f9-a3a8705f593c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sony Alpha a6400", 898.0 },
                    { new Guid("e5555555-5555-4eee-8eee-555555555551"), new Guid("4af1ce03-b37c-40a5-8462-28494820f53f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Dell UltraSharp 27", 600.0 },
                    { new Guid("e5555555-5555-4eee-8eee-555555555552"), new Guid("4af1ce03-b37c-40a5-8462-28494820f53f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LG UltraGear 32", 750.0 },
                    { new Guid("e5555555-5555-4eee-8eee-555555555553"), new Guid("4af1ce03-b37c-40a5-8462-28494820f53f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Samsung Odyssey G7", 800.0 },
                    { new Guid("e5555555-5555-4eee-8eee-555555555554"), new Guid("4af1ce03-b37c-40a5-8462-28494820f53f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Asus ProArt Display", 950.0 },
                    { new Guid("e5555555-5555-4eee-8eee-555555555555"), new Guid("4af1ce03-b37c-40a5-8462-28494820f53f"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Acer Predator XB", 850.0 },
                    { new Guid("e7777777-7777-4aaa-8aaa-777777777771"), new Guid("6c179026-9a44-4eca-b75a-811ebb8a577a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Logitech MX Keys", 130.0 },
                    { new Guid("e7777777-7777-4aaa-8aaa-777777777772"), new Guid("6c179026-9a44-4eca-b75a-811ebb8a577a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Razer BlackWidow V4", 180.0 },
                    { new Guid("e7777777-7777-4aaa-8aaa-777777777773"), new Guid("6c179026-9a44-4eca-b75a-811ebb8a577a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Corsair K95 RGB", 200.0 },
                    { new Guid("e7777777-7777-4aaa-8aaa-777777777774"), new Guid("6c179026-9a44-4eca-b75a-811ebb8a577a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "SteelSeries Apex Pro", 210.0 },
                    { new Guid("e7777777-7777-4aaa-8aaa-777777777775"), new Guid("6c179026-9a44-4eca-b75a-811ebb8a577a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Keychron K8", 110.0 },
                    { new Guid("eccc2c13-0b0f-43a1-ab12-3730b5183943"), new Guid("020c4989-67a4-4e4b-afbc-1d39a0e5d00b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bose Smart Soundbar 600", 499.0 },
                    { new Guid("f6666666-6666-4fff-8fff-666666666661"), new Guid("0d5d102d-e7b0-4a2e-a4fa-076deb014547"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Logitech MX Master 3", 120.0 },
                    { new Guid("f6666666-6666-4fff-8fff-666666666662"), new Guid("0d5d102d-e7b0-4a2e-a4fa-076deb014547"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Razer DeathAdder V3", 99.989999999999995 },
                    { new Guid("f6666666-6666-4fff-8fff-666666666663"), new Guid("0d5d102d-e7b0-4a2e-a4fa-076deb014547"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SteelSeries Rival 5", 79.989999999999995 },
                    { new Guid("f6666666-6666-4fff-8fff-666666666664"), new Guid("0d5d102d-e7b0-4a2e-a4fa-076deb014547"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "HyperX Pulsefire", 69.989999999999995 },
                    { new Guid("f6666666-6666-4fff-8fff-666666666665"), new Guid("0d5d102d-e7b0-4a2e-a4fa-076deb014547"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Corsair Dark Core", 89.989999999999995 },
                    { new Guid("f6c85122-e889-46d8-ac43-63dc0e8a01b2"), new Guid("89b21758-c1c1-469d-86f9-a3a8705f593c"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nikon Z30", 706.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_my_categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "my_categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_my_categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1279005e-64d9-4509-bbc0-59a979b55f82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("217a73c9-4f13-455b-8daa-91bb194beb5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41644484-cebf-4f2c-b9b4-f42d4d7f5076"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("443414ba-f852-4733-92e6-ded212c77fe7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("923df676-5088-4289-8ddc-050cd7ebfcd0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-1111-4aaa-8aaa-111111111111"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-1111-4aaa-8aaa-111111111112"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-1111-4aaa-8aaa-111111111113"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-1111-4aaa-8aaa-111111111114"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-1111-4aaa-8aaa-111111111115"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a92c46dc-2037-44ae-9cc5-0ba08e07b401"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aacc2981-b45b-457b-9b7a-22dff703400f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aacd266f-bf5c-4ac0-93ba-739c937f8c22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2222222-2222-4bbb-8bbb-222222222221"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2222222-2222-4bbb-8bbb-222222222222"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2222222-2222-4bbb-8bbb-222222222223"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2222222-2222-4bbb-8bbb-222222222224"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2222222-2222-4bbb-8bbb-222222222225"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b48fa24b-6876-4404-bd21-6e99cf5550ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bffdfb7d-73c9-4ab8-b9eb-34a63065427c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3333333-3333-4ccc-8ccc-333333333331"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3333333-3333-4ccc-8ccc-333333333332"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3333333-3333-4ccc-8ccc-333333333333"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3333333-3333-4ccc-8ccc-333333333334"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3333333-3333-4ccc-8ccc-333333333335"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd5c791f-c0cc-467f-bd96-40624a302f7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d31f4cad-418c-4792-89f6-7a5f3cd65afb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4444444-4444-4ddd-8ddd-444444444441"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4444444-4444-4ddd-8ddd-444444444442"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4444444-4444-4ddd-8ddd-444444444443"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4444444-4444-4ddd-8ddd-444444444444"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4444444-4444-4ddd-8ddd-444444444445"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5276fcc-bf5e-4bec-9d61-e67f2906db69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-4eee-8eee-555555555551"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-4eee-8eee-555555555552"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-4eee-8eee-555555555553"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-4eee-8eee-555555555554"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-4eee-8eee-555555555555"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-4aaa-8aaa-777777777771"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-4aaa-8aaa-777777777772"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-4aaa-8aaa-777777777773"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-4aaa-8aaa-777777777774"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-4aaa-8aaa-777777777775"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eccc2c13-0b0f-43a1-ab12-3730b5183943"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-4fff-8fff-666666666661"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-4fff-8fff-666666666662"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-4fff-8fff-666666666663"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-4fff-8fff-666666666664"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-4fff-8fff-666666666665"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6c85122-e889-46d8-ac43-63dc0e8a01b2"));

            migrationBuilder.DeleteData(
                table: "my_categories",
                keyColumn: "Id",
                keyValue: new Guid("020c4989-67a4-4e4b-afbc-1d39a0e5d00b"));

            migrationBuilder.DeleteData(
                table: "my_categories",
                keyColumn: "Id",
                keyValue: new Guid("0d5d102d-e7b0-4a2e-a4fa-076deb014547"));

            migrationBuilder.DeleteData(
                table: "my_categories",
                keyColumn: "Id",
                keyValue: new Guid("20f8768c-ab73-4cc6-8ebb-cc58fe00ad4d"));

            migrationBuilder.DeleteData(
                table: "my_categories",
                keyColumn: "Id",
                keyValue: new Guid("34c0032d-9a67-40a8-b6c4-8c0d15b23650"));

            migrationBuilder.DeleteData(
                table: "my_categories",
                keyColumn: "Id",
                keyValue: new Guid("4af1ce03-b37c-40a5-8462-28494820f53f"));

            migrationBuilder.DeleteData(
                table: "my_categories",
                keyColumn: "Id",
                keyValue: new Guid("561ac3ea-6374-4b26-b422-4c619bdc26fa"));

            migrationBuilder.DeleteData(
                table: "my_categories",
                keyColumn: "Id",
                keyValue: new Guid("6c179026-9a44-4eca-b75a-811ebb8a577a"));

            migrationBuilder.DeleteData(
                table: "my_categories",
                keyColumn: "Id",
                keyValue: new Guid("89b21758-c1c1-469d-86f9-a3a8705f593c"));

            migrationBuilder.DeleteData(
                table: "my_categories",
                keyColumn: "Id",
                keyValue: new Guid("89bd4978-0429-4913-8c74-843f24e35cb6"));

            migrationBuilder.DeleteData(
                table: "my_categories",
                keyColumn: "Id",
                keyValue: new Guid("8e1b8de7-421b-4020-ac41-3e96b01ba8d3"));

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");
        }
    }
}
