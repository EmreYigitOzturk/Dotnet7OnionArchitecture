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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new Faker("tr");

            builder.HasData(
                new Detail
                {
                    Id = 1,
                    CategoryId = 1,
                    Description = faker.Lorem.Sentence(5),
                    Title = faker.Lorem.Sentence(1),
                    IsDeleted = false,
                    CreateDate = DateTime.Now

                },
                new Detail
                {
                    Id = 2,
                    CategoryId = 3,
                    Description = faker.Lorem.Sentence(7),
                    Title = faker.Lorem.Sentence(2),
                    IsDeleted = true,
                    CreateDate = DateTime.Now

                },
                new Detail
                {
                    Id = 3,
                    CategoryId = 4,
                    Description = faker.Lorem.Sentence(5),
                    Title = faker.Lorem.Sentence(1),
                    IsDeleted = false,
                    CreateDate = DateTime.Now

                }
            );
        }
    }
}
