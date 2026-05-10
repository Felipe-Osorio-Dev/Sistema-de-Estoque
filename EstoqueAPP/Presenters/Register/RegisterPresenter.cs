using EstoqueAPP.Views.Register;

namespace EstoqueAPP.Presenters.Register
{
    internal class RegisterPresenter
    {
        private readonly IRegisterView _view;

        public RegisterPresenter(IRegisterView view)
        {
            _view = view;
        }
    }
}
