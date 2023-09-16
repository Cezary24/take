using Library.Contracts.Services;
using Library.Contracts.Views;
using Library.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestSharp;
using StudentInternship.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestSharp;
using Library.Services.Interfaces;
using Library.Services.Web;
using Library.Views;
using Library.Windows.Interfaces;
using Library.Core.Models.Title;
using Library.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IHost _host;

        public T GetService<T>()
            where T : class
            => _host.Services.GetService(typeof(T)) as T;

        public App()
        {
        }

        private async void OnStartup(object sender, StartupEventArgs e)
        {
            var appLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            // For more information about .NET generic host see  https://docs.microsoft.com/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-3.0
            _host = Host.CreateDefaultBuilder(e.Args)
                    .ConfigureAppConfiguration(c =>
                    {
                        c.SetBasePath(appLocation);
                    })
                    .ConfigureServices(ConfigureServices)
                    .Build();

            await _host.StartAsync();
        }

        private void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            // TODO WTS: Register your services, viewmodels and pages here

            // App Host
            services.AddHostedService<ApplicationHostService>();

            // Activation Handlers

            // Core Services

            // Services
            services.AddSingleton<INavigationService, NavigationService>();

            services.AddScoped<IRestClient, RestClient>();
            services.AddScoped<IReaderService, ReaderService>();
            services.AddSingleton<IRentalService, RentalService>();
            services.AddScoped<ITitleService, TitleService>();
            services.AddScoped<IVolumeService, VolumeService>();


            // Views
            services.AddTransient<IShellWindow, ShellWindow>();

            services.AddTransient<ReadersPage>();

            services.AddTransient<VolumesPage>();

            // Configuration
            services.Configure<AppConfig>(context.Configuration.GetSection(nameof(AppConfig)));

            //Windows
            services.AddTransient<IReaderWindow, NewReaderWindow>();
           services.AddTransient<IRentalWindow, NewRentalWindow>();
            services.AddTransient<ITitleWindow, NewTitleWindow>();
            services.AddTransient<IVolumeWindow, NewVolumeWindow>();
        }

        private async void OnExit(object sender, ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();
            _host = null;
        }

        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // TODO WTS: Please log and handle the exception as appropriate to your scenario
            // For more info see https://docs.microsoft.com/dotnet/api/system.windows.application.dispatcherunhandledexception?view=netcore-3.0
        }
    }
}
