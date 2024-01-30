namespace PieShop.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly PieShopDbContext _pieShopDbContext;

        public CategoryRepository(PieShopDbContext _pieShopDbContext)
        {
            _pieShopDbContext = _pieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _pieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
