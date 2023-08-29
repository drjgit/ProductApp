namespace ProductDomain.Entity
{
    public class Product
    {
        public Guid Id { get; init; }
        public string Titile { get; private set; }
        public string Description { get; private set; }
        public string ImageUrl { get; private set; }
        public Category? Category { get; private set; }
        public Guid CategoryId { get; private set; }
        public List<ProductVariants> Variants { get; private set; }
        public bool Featured { get; private set; }
        public bool Visiable { get; private set; }
        public bool Deleted { get; private set; }

        private Product() { }

        public Product(string title, string description, string imageUrl, Guid categoryId, List<ProductVariants> variants, 
            bool featured=false, bool visiable=true, bool delete=false)
        {
            Id = Guid.NewGuid();
            Titile = title;
            Description = description;     
            ImageUrl = imageUrl;
            CategoryId = categoryId;
            Variants = variants;
            Featured = featured;   
            Visiable = visiable;    
            Deleted = delete;
        }
    }
}