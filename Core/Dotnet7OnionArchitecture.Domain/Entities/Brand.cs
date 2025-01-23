using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotnet7OnionArchitecture.Domain.Common;

namespace Dotnet7OnionArchitecture.Domain.Entities
{
    public class Brand : EntityBase
    {
        public Brand(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        
    }
}
