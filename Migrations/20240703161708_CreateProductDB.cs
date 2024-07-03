using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductService.Migrations
{
    /// <inheritdoc />
    public partial class CreateProductDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(3500)", maxLength: 3500, nullable: true),
                    Specifications = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    ShippingWeight = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Dimensions", "ImageURL", "Model", "Name", "Price", "ShippingWeight", "Specifications", "Tags" },
                values: new object[,]
                {
                    { 1, "Cat-1", "23x45", "https://image.com/img2132", "MXC-3952", "Product1", 100.45f, "50", "Spec-1", "Product | Cat-1" },
                    { 2, "Cat-2", "34x24", "https://image.com/img2133", "MXC-3953", "Product2", 23.53f, "30", "Spec-2", "Product | Cat-2" },
                    { 3, "Cat-3", "22x32", "https://image.com/img2134", "MXC-3954", "Product3", 373.35f, "35", "Spec-3", "Product | Cat-3" },
                    { 4, "Cat-4", "23x46", "https://image.com/img2135", "MXC-3955", "Product4", 438.67667f, "23.33", "Spec-4", "Product | Cat-4" },
                    { 5, "Cat-5", "34x25", "https://image.com/img2136", "MXC-3956", "Product5", 575.12665f, "15.83", "Spec-5", "Product | Cat-5" },
                    { 6, "Cat-6", "22x33", "https://image.com/img2137", "MXC-3957", "Product6", 711.57666f, "8.33", "Spec-6", "Product | Cat-6" },
                    { 7, "Cat-7", "23x47", "https://image.com/img2138", "MXC-3958", "Product7", 848.0267f, "0.83", "Spec-7", "Product | Cat-7" },
                    { 8, "Cat-8", "34x26", "https://image.com/img2139", "MXC-3959", "Product8", 984.4767f, "6.66", "Spec-8", "Product | Cat-8" },
                    { 9, "Cat-9", "22x34", "https://image.com/img2140", "MXC-3960", "Product9", 1120.9266f, "14.16", "Spec-9", "Product | Cat-9" },
                    { 10, "Cat-10", "23x48", "https://image.com/img2141", "MXC-3961", "Product10", 1257.3767f, "21.66", "Spec-10", "Product | Cat-10" },
                    { 11, "Cat-11", "34x27", "https://image.com/img2142", "MXC-3962", "Product11", 1393.8267f, "29.16", "Spec-11", "Product | Cat-11" },
                    { 12, "Cat-12", "22x35", "https://image.com/img2143", "MXC-3963", "Product12", 1530.2766f, "36.66", "Spec-12", "Product | Cat-12" },
                    { 13, "Cat-13", "23x49", "https://image.com/img2144", "MXC-3964", "Product13", 1666.7267f, "44.16", "Spec-13", "Product | Cat-13" },
                    { 14, "Cat-14", "34x28", "https://image.com/img2145", "MXC-3965", "Product14", 1803.1766f, "51.66", "Spec-14", "Product | Cat-14" },
                    { 15, "Cat-15", "22x36", "https://image.com/img2146", "MXC-3966", "Product15", 1939.6267f, "59.16", "Spec-15", "Product | Cat-15" },
                    { 16, "Cat-16", "23x50", "https://image.com/img2147", "MXC-3967", "Product16", 2076.0767f, "66.66", "Spec-16", "Product | Cat-16" },
                    { 17, "Cat-17", "34x29", "https://image.com/img2148", "MXC-3968", "Product17", 2212.5266f, "74.16", "Spec-17", "Product | Cat-17" },
                    { 18, "Cat-18", "22x36", "https://image.com/img2149", "MXC-3969", "Product18", 2348.9766f, "81.66", "Spec-18", "Product | Cat-18" },
                    { 19, "Cat-19", "23x50", "https://image.com/img2150", "MXC-3970", "Product19", 2485.4268f, "89.16", "Spec-19", "Product | Cat-19" },
                    { 20, "Cat-20", "34x29", "https://image.com/img2151", "MXC-3971", "Product20", 2621.8767f, "96.66", "Spec-20", "Product | Cat-20" },
                    { 21, "Cat-21", "22x37", "https://image.com/img2152", "MXC-3972", "Product21", 2758.3267f, "104.16", "Spec-21", "Product | Cat-21" },
                    { 22, "Cat-22", "23x51", "https://image.com/img2153", "MXC-3973", "Product22", 2894.7766f, "111.66", "Spec-22", "Product | Cat-22" },
                    { 23, "Cat-23", "34x30", "https://image.com/img2154", "MXC-3974", "Product23", 3031.2266f, "119.16", "Spec-23", "Product | Cat-23" },
                    { 24, "Cat-24", "22x37", "https://image.com/img2155", "MXC-3975", "Product24", 3167.6768f, "126.66", "Spec-24", "Product | Cat-24" },
                    { 25, "Cat-25", "23x51", "https://image.com/img2156", "MXC-3976", "Product25", 3304.1267f, "134.16", "Spec-25", "Product | Cat-25" },
                    { 26, "Cat-26", "34x30", "https://image.com/img2157", "MXC-3977", "Product26", 3440.5767f, "141.66", "Spec-26", "Product | Cat-26" },
                    { 27, "Cat-27", "22x38", "https://image.com/img2158", "MXC-3978", "Product27", 3577.0266f, "149.16", "Spec-27", "Product | Cat-27" },
                    { 28, "Cat-28", "23x52", "https://image.com/img2159", "MXC-3979", "Product28", 3713.4766f, "156.66", "Spec-28", "Product | Cat-28" },
                    { 29, "Cat-29", "34x31", "https://image.com/img2160", "MXC-3980", "Product29", 3849.9268f, "164.16", "Spec-29", "Product | Cat-29" },
                    { 30, "Cat-30", "22x38", "https://image.com/img2161", "MXC-3981", "Product30", 3986.3767f, "171.66", "Spec-30", "Product | Cat-30" },
                    { 31, "Cat-31", "23x52", "https://image.com/img2162", "MXC-3982", "Product31", 4122.8267f, "179.16", "Spec-31", "Product | Cat-31" },
                    { 32, "Cat-32", "34x31", "https://image.com/img2163", "MXC-3983", "Product32", 4259.277f, "186.66", "Spec-32", "Product | Cat-32" },
                    { 33, "Cat-33", "22x39", "https://image.com/img2164", "MXC-3984", "Product33", 4395.7266f, "194.16", "Spec-33", "Product | Cat-33" },
                    { 34, "Cat-34", "23x53", "https://image.com/img2165", "MXC-3985", "Product34", 4532.177f, "201.66", "Spec-34", "Product | Cat-34" },
                    { 35, "Cat-35", "34x32", "https://image.com/img2166", "MXC-3986", "Product35", 4668.6265f, "209.16", "Spec-35", "Product | Cat-35" },
                    { 36, "Cat-36", "22x39", "https://image.com/img2167", "MXC-3987", "Product36", 4805.0767f, "216.66", "Spec-36", "Product | Cat-36" },
                    { 37, "Cat-37", "23x53", "https://image.com/img2168", "MXC-3988", "Product37", 4941.527f, "224.16", "Spec-37", "Product | Cat-37" },
                    { 38, "Cat-38", "34x32", "https://image.com/img2169", "MXC-3989", "Product38", 5077.9766f, "231.66", "Spec-38", "Product | Cat-38" },
                    { 39, "Cat-39", "22x40", "https://image.com/img2170", "MXC-3990", "Product39", 5214.427f, "239.16", "Spec-39", "Product | Cat-39" },
                    { 40, "Cat-40", "23x54", "https://image.com/img2171", "MXC-3991", "Product40", 5350.8765f, "246.66", "Spec-40", "Product | Cat-40" },
                    { 41, "Cat-41", "34x33", "https://image.com/img2172", "MXC-3992", "Product41", 5487.3267f, "254.16", "Spec-41", "Product | Cat-41" },
                    { 42, "Cat-42", "22x40", "https://image.com/img2173", "MXC-3993", "Product42", 5623.777f, "261.66", "Spec-42", "Product | Cat-42" },
                    { 43, "Cat-43", "23x54", "https://image.com/img2174", "MXC-3994", "Product43", 5760.2266f, "269.16", "Spec-43", "Product | Cat-43" },
                    { 44, "Cat-44", "34x33", "https://image.com/img2175", "MXC-3995", "Product44", 5896.677f, "276.66", "Spec-44", "Product | Cat-44" },
                    { 45, "Cat-45", "22x41", "https://image.com/img2176", "MXC-3996", "Product45", 6033.1265f, "284.16", "Spec-45", "Product | Cat-45" },
                    { 46, "Cat-46", "23x55", "https://image.com/img2177", "MXC-3997", "Product46", 6169.5767f, "291.66", "Spec-46", "Product | Cat-46" },
                    { 47, "Cat-47", "34x34", "https://image.com/img2178", "MXC-3998", "Product47", 6306.027f, "299.16", "Spec-47", "Product | Cat-47" },
                    { 48, "Cat-48", "22x41", "https://image.com/img2179", "MXC-3999", "Product48", 6442.4766f, "306.66", "Spec-48", "Product | Cat-48" },
                    { 49, "Cat-49", "23x55", "https://image.com/img2180", "MXC-4000", "Product49", 6578.927f, "314.16", "Spec-49", "Product | Cat-49" },
                    { 50, "Cat-50", "34x34", "https://image.com/img2181", "MXC-4001", "Product50", 6715.3765f, "321.66", "Spec-50", "Product | Cat-50" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
