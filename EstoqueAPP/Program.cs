using EstoqueAPP.Presenters.Main;
using EstoqueAPP.Presenters.Register;
using EstoqueAPP.Services.Navigation;
using EstoqueAPP.Views.Main;
using EstoqueAPP.Views.Register;
using Microsoft.Extensions.DependencyInjection;

namespace EstoqueAPP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var scope = services.BuildServiceProvider())
            {
                ApplicationConfiguration.Initialize();

                var mainForm = scope.GetRequiredService<MainForm>();
                scope.GetRequiredService<MainPresenter>();

                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //Container Principal
            services.AddSingleton<MainForm>();

            //Forms
            services.AddScoped<RegisterForm>();

            //Presenters
            services.AddSingleton<MainPresenter>();
            services.AddScoped<RegisterPresenter>();

            //Interfaces
            services.AddSingleton<INavigationService, NavigationService>();
            services.AddTransient<IMainView>(sp => sp.GetRequiredService<MainForm>());
            services.AddTransient<IRegisterView, RegisterForm>();

            //Services
            services.AddSingleton<NavigationService>();
        }
    }
}