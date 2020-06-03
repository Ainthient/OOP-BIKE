using Microsoft.Extensions.DependencyInjection;
using BIKESobj.ApplicationServices.GetLocationListUseCase;
using BIKESobj.ApplicationServices.Ports.Cache;
using BIKESobj.ApplicationServices.Repositories;
using BIKESobj.DesktopClient.InfrastructureServices.ViewModels;
using BIKESobj.DomainObjects;
using BIKESobj.DomainObjects.Ports;
using BIKESobj.InfrastructureServices.Cache;
using BIKESobj.InfrastructureServices.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BIKESobj.DesktopClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDomainObjectsCache<bikesobj>, DomainObjectsMemoryCache<bikesobj>>();
            services.AddSingleton<NetworkBIKESobjRepository>(
                x => new NetworkBIKESobjRepository("localhost", 80, useTls: false, x.GetRequiredService<IDomainObjectsCache<bikesobj>>())
            );
            services.AddSingleton<CachedReadOnlyBIKESobjRepository>(
                x => new CachedReadOnlyBIKESobjRepository(
                    x.GetRequiredService<NetworkBIKESobjRepository>(), 
                    x.GetRequiredService<IDomainObjectsCache<bikesobj>>()
                )
            );
            services.AddSingleton<IReadOnlyBIKESobjRepository>(x => x.GetRequiredService<CachedReadOnlyBIKESobjRepository>());
            services.AddSingleton<IGetBIKESobjListUseCase, GetBIKESobjListUseCase>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs args)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
