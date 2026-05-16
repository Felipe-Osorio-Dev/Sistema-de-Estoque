using EstoqueAPI.DTOs.Requests;
using EstoqueAPI.Models.Product;
using EstoqueAPI.Repositorys.Product;
using MapsterMapper;

namespace EstoqueAPI.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task RegisterProduct(RegisterProductDTO product)
        {
            var model = _mapper.Map<ProductModel>(product);

            await _repository.RegisterProduct(model);
        }
    }
}
