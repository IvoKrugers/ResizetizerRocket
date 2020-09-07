using System.Runtime.CompilerServices;
using BoardPapers.Core.Services.Logging;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;

[assembly: InternalsVisibleTo("BoardPapers.UnitTests")]

namespace BoardPapers.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Provider")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.IoCProvider.RegisterSingleton<IConnectivity>(() => new ConnectivityImplementation());

            // register the appstart object
            RegisterCustomAppStart<AppStart>();
        }
    }
}
