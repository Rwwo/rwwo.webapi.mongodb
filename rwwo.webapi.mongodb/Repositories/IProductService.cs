using rwwo.webapi.mongodb.Entities;

namespace rwwo.webapi.mongodb.Repositories
{
    public interface IProductService
    {
        public Task<List<ProductDetails>> ProductListAsync();
        public Task<ProductDetails> GetProductDetailByIdAsync(string productId);
        public Task AddProductAsync(ProductDetails productDetails);
        public Task UpdateProductAsync(string productId, ProductDetails productDetails);
        public Task DeleteProductAsync(string productId);
    }
}
