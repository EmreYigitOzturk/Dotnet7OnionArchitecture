using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotnet7OnionArchitecture.Domain.Common;

namespace Dotnet7OnionArchitecture.Domain.Entities
{
    public class Category : EntityBase
    {
        

        public  int ParentId { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }

        public ICollection<Detail> Details { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
