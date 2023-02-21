using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class PRODUCT_SEED : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Hoppe Group");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Feil, Ryan and Lueilwitz");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Schumm LLC");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Hettinger - Schamberger");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Dickinson, Schuster and Gorczany");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Books");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Books");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Automotive");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Code", "ColorName", "Description", "ModelName", "Name", "ProductBarcode", "SizeName", "UserId", "VariantName" },
                values: new object[,]
                {
                    { 1, 2, 3, 3037, "black", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome", "Cheese", 563621, "", 2, "Intelligent Soft Bike" },
                    { 2, 3, 3, 2166, "orange", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty", "Computer", 687075, "", 2, "Refined Soft Chicken" },
                    { 3, 1, 5, 8144, "orchid", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handmade", "Car", 782235, "", 1, "Fantastic Granite Ball" },
                    { 4, 5, 5, 1454, "olive", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded", "Soap", 139311, "", 2, "Tasty Soft Ball" },
                    { 5, 3, 2, 9186, "magenta", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic", "Keyboard", 674778, "", 1, "Licensed Cotton Cheese" },
                    { 6, 2, 2, 7619, "purple", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Ergonomic", "Tuna", 232041, "", 2, "Practical Granite Pants" },
                    { 7, 4, 4, 4247, "ivory", "The Football Is Good For Training And Recreational Purposes", "Handmade", "Chicken", 558315, "", 2, "Rustic Granite Pizza" },
                    { 8, 4, 2, 9395, "plum", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Sleek", "Chicken", 612194, "", 2, "Generic Soft Car" },
                    { 9, 2, 2, 5135, "violet", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licensed", "Mouse", 962006, "", 2, "Small Frozen Cheese" },
                    { 10, 1, 4, 2057, "azure", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined", "Tuna", 299761, "", 2, "Intelligent Fresh Hat" },
                    { 11, 2, 4, 8429, "turquoise", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Refined", "Mouse", 533278, "", 1, "Gorgeous Rubber Shirt" },
                    { 12, 4, 5, 3531, "azure", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Awesome", "Keyboard", 447109, "", 2, "Tasty Steel Salad" },
                    { 13, 5, 1, 1909, "yellow", "The Football Is Good For Training And Recreational Purposes", "Small", "Cheese", 992334, "", 1, "Incredible Cotton Ball" },
                    { 14, 2, 4, 5290, "violet", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek", "Computer", 300133, "", 2, "Tasty Steel Fish" },
                    { 15, 4, 3, 9348, "teal", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Unbranded", "Towels", 421449, "", 2, "Rustic Steel Chicken" },
                    { 16, 1, 3, 2202, "purple", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small", "Car", 967950, "", 1, "Practical Fresh Gloves" },
                    { 17, 4, 5, 4291, "mint green", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Generic", "Keyboard", 116317, "", 1, "Intelligent Rubber Shoes" },
                    { 18, 1, 3, 2799, "turquoise", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Ergonomic", "Soap", 700839, "", 1, "Refined Fresh Salad" },
                    { 19, 4, 5, 1019, "grey", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous", "Chips", 433543, "", 1, "Rustic Cotton Sausages" },
                    { 20, 2, 4, 7950, "olive", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined", "Sausages", 139559, "", 1, "Fantastic Wooden Shoes" },
                    { 21, 4, 5, 1289, "violet", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handmade", "Salad", 677428, "", 1, "Incredible Fresh Shirt" },
                    { 22, 4, 3, 8179, "purple", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined", "Shirt", 549691, "", 2, "Handcrafted Rubber Salad" },
                    { 23, 5, 5, 8220, "orchid", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible", "Cheese", 465836, "", 2, "Fantastic Granite Cheese" },
                    { 24, 4, 3, 5185, "azure", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantastic", "Soap", 598330, "", 2, "Handcrafted Concrete Pizza" },
                    { 25, 5, 1, 3078, "pink", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Incredible", "Gloves", 790613, "", 1, "Practical Wooden Soap" },
                    { 26, 4, 4, 4928, "azure", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Sleek", "Fish", 318454, "", 2, "Licensed Metal Table" },
                    { 27, 1, 3, 9443, "turquoise", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small", "Bacon", 762263, "", 1, "Unbranded Wooden Cheese" },
                    { 28, 5, 1, 5308, "orange", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty", "Bike", 849150, "", 2, "Refined Steel Tuna" },
                    { 29, 1, 1, 9238, "violet", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Tasty", "Soap", 497283, "", 1, "Practical Frozen Shirt" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2b$10$cD7C/yFQOVM1Az6X2eB0KevUWOYcx.ieMS0cSfs83tEOIvJBbPIF2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2b$10$cBdRhA/4CzILjJd0YIqoYOwK3Rus2g4RULdfKWal./1n9GSQqGcMW");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Koss, Boyer and Bernhard");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Harris and Sons");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Johnston, Torp and Hansen");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Grady, Labadie and Osinski");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Nienow, Bogan and Haley");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Computers");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Kids");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2b$10$cjb4eRHnKnnllrjAwRTO..tLmI2cfb6Jr.6YceDQMtTB7oNNV1Sfm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2b$10$LZZeDcs6Fnkt.dMp/wxT7.pWtNmKYD3px.5XMQLxvmcQ85P2zj.U2");
        }
    }
}
