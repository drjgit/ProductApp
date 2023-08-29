using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDomain.Entity
{
    public class ProductType
    {
        public Guid Id { get; init; }
        public string Name { get; private set; } // 基础班

        private ProductType() { }   

        public ProductType(string name) 
        { 
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
