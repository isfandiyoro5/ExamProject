using ExamProject.Models;

namespace ExamProject.Service
{
    public class ProductService:IProductService
    {
        private readonly ProductDbContext _context;

        public ProductService(ProductDbContext context)
        {
            _context = context;
        }

        public Product AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public int DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product  GetProduct(Product product)
        {
            _context.Products.Add(product);
            return product;
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
