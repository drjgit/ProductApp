
namespace ProductDomain.Entity
{
    public class ProductType
    {
        public Guid Id { get; init; }
        public string Name { get; private set; } // 基础版

        private ProductType() { }   

        public ProductType(string name) 
        { 
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
