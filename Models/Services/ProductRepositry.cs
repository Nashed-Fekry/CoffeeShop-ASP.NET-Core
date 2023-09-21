using CoffeeShop.Models.InterFaces;

namespace CoffeeShop.Models.Services
{
    public class ProductRepositry : IProductRepositry
    {
        private List<Product> ProductList = new List<Product>()
        {
            new Product { Id = 1,Name="Amricano",Price=25,Detail="The Amricano coffee is classic"},
            new Product { Id = 2,Name="Mocha",Price=30,Detail="The Mocha coffee is Modern"},
            new Product { Id = 1,Name="au Lait",Price=42,Detail="The Lait coffee is New Coffee"}
        };
        public Product GetProductDetail(int id)
        {
            return ProductList.FirstOrDefault(P => P.Id == id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return ProductList;
        }

        public IEnumerable<Product> GetTrendingProduct()
        {
            return ProductList.Where(P => P.IsTrendingProduct);
        }
    }
}
