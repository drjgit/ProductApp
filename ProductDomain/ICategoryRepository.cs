
namespace ProductDomain
{
    public interface ICategoryRepository
    {
        Task<List<Entity.Category>> FindAllCategoriesAsync();
    }
}
