using System;
using System.Globalization;
using System.Reflection;
using ExternalViewsTest.Lib.Views;
using Prism;
using ExternalViewsTest.Views;
using Prism.Mvvm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ExternalViewsTest
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<SecondPage>();
            Container.RegisterTypeForNavigation<ThirdPage>();
            Container.RegisterTypeForNavigation<FourthPage>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(viewType =>
            {
                var type = 
                    ExternalViewsTest.Lib.ViewModelLocator.ViewTypeToViewModelTypeResolver(viewType)
                    ?? ViewModelLocator.ViewTypeToViewModelTypeResolver(viewType);

                return type;
            });
        }
    }
}
