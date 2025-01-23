using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotnet7OnionArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet7OnionArchitecture.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category Category1 = new Category()
            {
                Id = 1,
                Name = "Elektronik",
                Priority = 1,
                CreateDate = DateTime.Now,
                IsDeleted = false,
                ParentId = 0
            };
            Category Category2 = new Category()
            {
                Id = 2,
                Name = "Moda",
                Priority = 2,
                CreateDate = DateTime.Now,
                IsDeleted = false,
                ParentId = 0
            };
            Category Category3 = new Category()
            {
                Id = 3,
                Name = "Bilgisayar",
                Priority = 3,
                CreateDate = DateTime.Now,
                IsDeleted = false,
                ParentId = 1
            };

            Category Category4 = new Category()
            {
                Id = 4,
                Name = "Kadın",
                Priority = 4,
                CreateDate = DateTime.Now,
                IsDeleted = false,
                ParentId = 2
            };

            builder.HasData(Category1, Category2, Category3, Category4);

        }
    }
}
