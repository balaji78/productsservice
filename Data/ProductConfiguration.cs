using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductService.Models;
using CsvHelper;
using System.Globalization;

namespace ProductService.Data
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entityType)
        {
            entityType.HasData(GetProductsFromCSV("Data/products.csv"));
        }

        private List<Product> GetProductsFromCSV(string csvFile)
        {
            using var reader = new StreamReader(csvFile);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Product>().ToList();
        }
    }
}