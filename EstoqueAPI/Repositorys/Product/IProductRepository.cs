using EstoqueAPI.Models.Product;

namespace EstoqueAPI.Repositorys.Product
{
    public interface IProductRepository
    {
        Task RegisterProduct(ProductModel product);
    }
}
