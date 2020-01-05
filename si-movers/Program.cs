using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using si_movers.Services.IMoversServices;
using si_movers.Services.MoversServices;
using System;


namespace si_movers
{
    class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            RegisterServices();

            var personService = _serviceProvider.GetService<IPersonService>();
            personService.AddPerson(Int32.Parse(args[0]));

            DisposeServices();
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            var builder = new ContainerBuilder();

            builder.RegisterType<GenerateData>().As<IGenerateData>();
            builder.RegisterType<PersonService>().As<IPersonService>();

            builder.Populate(services);
            var appContainer = builder.Build();
            _serviceProvider = new AutofacServiceProvider(appContainer);
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}

