using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExternalViewsTest.Lib.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string message;

        public string Message
        {
            get => message;
            set => SetProperty(ref message, value);
        }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
            Message = "Message from VM";
        }
    }
}
