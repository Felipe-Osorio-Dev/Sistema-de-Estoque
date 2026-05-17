using EstoqueAPP.DTO.Requests;

namespace EstoqueAPP.Services.Product
{
    internal interface IProductService
    {
        Task RegisterProduct(RegisterProductDTO product);
    }
}
