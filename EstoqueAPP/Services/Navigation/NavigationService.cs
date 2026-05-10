using Microsoft.Extensions.DependencyInjection;

namespace EstoqueAPP.Services.Navigation
{
    internal class NavigationService : INavigationService
    {
        private readonly IServiceProvider _services;
        private static Form? _mdiParent;

        public NavigationService(IServiceProvider services)
        {
            _services = services;
        }

        public void NavigateTo<TForm, TPresenter>()
            where TForm : Form
            where TPresenter : class
        {
            var scoped = _services.CreateScope();

            var existingForm = _mdiParent?.MdiChildren.FirstOrDefault(f => f is TForm);

            if (existingForm != null)
            {
                existingForm.Activate();
                scoped.Dispose();
                return;
            }

            var newForm = scoped.ServiceProvider.GetRequiredService<TForm>();
            scoped.ServiceProvider.GetRequiredService<TPresenter>();

            newForm.FormClosed += (s, e) => scoped.Dispose();
            newForm.MdiParent = _mdiParent;
            newForm.Show();


        }

        public void SetContainerParent(Form form)
        {
            _mdiParent = form;
        }
    }
}
