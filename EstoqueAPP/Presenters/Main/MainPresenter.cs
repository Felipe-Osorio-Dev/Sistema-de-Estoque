using EstoqueAPP.Presenters.Register;
using EstoqueAPP.Services.Navigation;
using EstoqueAPP.Views.Main;
using EstoqueAPP.Views.Register;

namespace EstoqueAPP.Presenters.Main
{
    internal class MainPresenter
    {
        private readonly IMainView _view;
        private readonly INavigationService _navigationService;

        public MainPresenter(IMainView view, INavigationService navigationService)
        {
            _view = view;
            _navigationService = navigationService;

            _navigationService.SetContainerParent((Form) view);

            _view.RegisterProduct += OnRegisterProduct;
        }

        private void OnRegisterProduct(Object sender, EventArgs e)
        {
            _navigationService.NavigateTo<RegisterForm, RegisterPresenter>();
        }
    }
}
