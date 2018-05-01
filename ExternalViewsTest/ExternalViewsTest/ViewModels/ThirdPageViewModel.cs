using ExternalViewsTest.Lib.ViewModels;
using Prism.Navigation;

namespace ExternalViewsTest.ViewModels
{
    public class ThirdPageViewModel : ViewModelBase
    {
        public ThirdPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Third Page - From VM";
        }
    }
}