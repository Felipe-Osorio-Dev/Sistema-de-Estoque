using EstoqueAPP.Services.Product;
using EstoqueAPP.Views.Register;

namespace EstoqueAPP.Presenters.Register
{
    internal class RegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly IProductService _productService;

        public RegisterPresenter(IRegisterView view, IProductService service)
        {
            _view = view;
            _productService = service;

            _view.ClickRegisterProduct += OnRegisterProduct;
        }

        private async void OnRegisterProduct(object sender, RegisterProductEventArgs e)
        {
            MessageBox.Show("Testando");
            await _productService.RegisterProduct(e.Product);
        }
    }
}
