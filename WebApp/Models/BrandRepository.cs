namespace WebApp.Models
{
    public class BrandRepository
    {
        StoreContext _context;
        public BrandRepository(StoreContext context)
        {
            this._context = context;
        }
        public List<Brand> GetBrands() 
        {
            return _context.Brands.ToList(); 
        }
    }
}
