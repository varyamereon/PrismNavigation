using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using PrismNavigation.ViewModels;
using PrismNavigation.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PrismNavigation
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage/NavigationPage/PageOne");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<PageOne, PageOneViewModel>();
            containerRegistry.RegisterForNavigation<PageTwo, PageTwoViewModel>();
            containerRegistry.RegisterForNavigation<DeepPage, DeepPageViewModel>();
        }
    }
}
