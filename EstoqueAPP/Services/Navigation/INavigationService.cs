namespace EstoqueAPP.Services.Navigation
{
    internal interface INavigationService
    {
        void SetContainerParent(Form form);
        void NavigateTo<TForm, TPresenter>() where TForm : Form where TPresenter : class;
    }
}
