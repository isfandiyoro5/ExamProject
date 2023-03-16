using ExamProject.Models;

namespace ExamProject.Service
{
    public interface IProductService
    {
        public List<Product> GetProducts();
        public Product GetProduct(int id);
        public Product AddProduct(Product product);
        public Product UpdateProduct(int id, Product product);
        public int DeleteProduct(int id);
    }
}
