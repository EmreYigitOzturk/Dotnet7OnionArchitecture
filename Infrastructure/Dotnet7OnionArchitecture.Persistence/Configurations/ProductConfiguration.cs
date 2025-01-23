using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Dotnet7OnionArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dotnet7OnionArchitecture.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            Faker faker = new Faker("tr");

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Title = faker.Commerce.ProductName(),
                    Description = faker.Commerce.ProductDescription(),
                    Price = faker.Finance.Amount(10,1000),
                    BrandId = 1,
                    Discount = faker.Random.Decimal(1, 10),
                    CreateDate = DateTime.Now,
                    IsDeleted = false
                },
                new Product
                {
                    Id = 2,
                    Title = faker.Commerce.ProductName(),
                    Description = faker.Commerce.ProductDescription(),
                    Price = faker.Finance.Amount(10, 1000),
                    BrandId = 2,
                    Discount = faker.Random.Decimal(1, 10),
                    CreateDate = DateTime.Now,
                    IsDeleted = false
                },
                new Product
                {
                    Id = 3,
                    Title = faker.Commerce.ProductName(),
                    Description = faker.Commerce.ProductDescription(),
                    Price = faker.Finance.Amount(10, 1000),
                    BrandId = 3,
                    Discount = faker.Random.Decimal(1, 10),
                    CreateDate = DateTime.Now,
                    IsDeleted = false
                }
            );


        }
    }
}
