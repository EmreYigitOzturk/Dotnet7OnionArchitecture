using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Dotnet7OnionArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet7OnionArchitecture.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(250);

            Faker faker = new Faker("tr");

            builder.HasData(
                new Brand
                {
                    Id = 1,
                    Name = faker.Company.CompanyName(),
                    CreateDate = DateTime.Now,
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 2,
                    Name = faker.Company.CompanyName(),
                    CreateDate = DateTime.Now,
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 3,
                    Name = faker.Company.CompanyName(),
                    CreateDate = DateTime.Now,
                    IsDeleted = false

                }
            );

        }
    }
}
