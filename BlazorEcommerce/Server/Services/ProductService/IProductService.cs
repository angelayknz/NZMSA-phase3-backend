using System;
namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

        Task<ServiceResponse<Product>> GetProductAsync(int ProductId);

        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
    }
}

