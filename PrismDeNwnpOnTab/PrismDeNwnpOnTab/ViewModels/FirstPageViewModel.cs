using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace PrismDeNwnpOnTab.ViewModels
{
    public class FirstPageViewModel : BindableBase
    {
        private INavigationService _navigationservice;
        public ICommand GoSecondCommand { get; }

        public FirstPageViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;
            GoSecondCommand = new DelegateCommand(GoSecond);
        }

        async private void GoSecond()
        {
            await _navigationservice.NavigateAsync("SecondPage");
        }
    }
}
