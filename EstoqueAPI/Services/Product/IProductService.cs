using EstoqueAPI.DTOs.Requests;

namespace EstoqueAPI.Services.Product
{
    public interface IProductService
    {
        Task RegisterProduct(RegisterProductDTO product);
    }
}
