using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace ExternalViewsTest.Lib.ViewModels
{
	public class SecondPageViewModel : ViewModelBase
    {
        public SecondPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Second Page";
            GoToThirdPageCommand = new DelegateCommand(() => navigationService.NavigateAsync("ThirdPage"));

        }

        public DelegateCommand GoToThirdPageCommand { get; set; }
    }
	public class FourthPageViewModel : ViewModelBase
    {
        public FourthPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Fourth Page";

        }
        
    }
}
