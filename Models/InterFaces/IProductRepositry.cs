namespace CoffeeShop.Models.InterFaces
{
    public interface IProductRepositry
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetTrendingProduct();
        Product GetProductDetail(int id);
    }
}
