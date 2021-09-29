using DemoNavigationServiece.ViewModels;
using DemoNavigationServiece.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace DemoNavigationServiece
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/BasicNavigation");
        }
        protected override void OnResume()
        {
            base.OnResume();
        }
        protected override void OnStart()
        {
            base.OnStart();
        }
        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<BasicNavigation, BasicNavigationViewModel>();
            containerRegistry.RegisterForNavigation<Page_Lifecycle, Page_LifecycleViewModel>();
            containerRegistry.RegisterForNavigation<PageLife, PageLifeViewModel>();
            containerRegistry.RegisterForNavigation<NavigationBase, NavigationBaseViewModel>();
            containerRegistry.RegisterForNavigation<PageA, PageAViewModel>();
        }
    }
}
