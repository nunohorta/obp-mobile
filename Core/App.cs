using MvvmCross.Platform.IoC;

namespace Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            // Construct custom application start object
            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, AppStart>();

            // request a reference to the constructed appstart object 
            var appStart = Mvx.Resolve<IMvxAppStart>();

            // register the appstart object
            RegisterAppStart(appStart);
        }
    }
}
