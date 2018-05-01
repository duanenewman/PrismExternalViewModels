using ExternalViewsTest.Lib.ViewModels;
using Prism.Commands;
using Prism.Navigation;

namespace ExternalViewsTest.ViewModels
{
    public class ThirdPageViewModel : ViewModelBase
    {
        public ThirdPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Third Page - From VM";
            GoToFourthPageCommand = new DelegateCommand(() => navigationService.NavigateAsync("FourthPage"));

        }

        public DelegateCommand GoToFourthPageCommand { get; set; }
    }
}