using System.Text.Json.Serialization;

namespace ProductDomain.Entity
{
    public class ProductVariants
    {
        public Guid Id { get; init; }

        [JsonIgnore]
        public Product? Product { get; private set; }
        public Guid ProductId { get; private set; }
        public ProductType? ProductType { get; private set; }
        public Guid ProductTypeId { get; private set; }
        public decimal Price { get; private set; }
        public decimal OriginalPrice { get; private set; }
        public bool Visiable { get; private set; }
        public bool Deleted { get; private set; }

        private ProductVariants() { }

        public ProductVariants(Guid productId, Guid typeId, decimal price, decimal originalPrice, 
            bool visiable = true, bool deleted = false)
        {
            Id = Guid.NewGuid();
            ProductId = productId;
            ProductTypeId = typeId;
            Price = price;
            OriginalPrice = originalPrice;
            Visiable = visiable;
            Deleted = deleted;
        }

        public void UpdateType(ProductType type)
        {
            if (type.Name == ProductType.Name)
            {
                Console.WriteLine("已存在该套餐");
            }
            this.ProductType = type;
        }

        public void ProductVisiable()
        {
            this.Visiable = true;
        }

        public void ProductInvisiable()
        {
            this.Visiable = false;
        }

        public void ProductDeleted()
        {
            this.Deleted = true;
        }
    }
}
