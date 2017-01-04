using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace PrismDeNwnpOnTab.ViewModels
{
    public class SubPageViewModel : BindableBase
    {
        private INavigationService _navigationservice;
        public ICommand GoMainCommand { get; }

        public SubPageViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;
            GoMainCommand = new DelegateCommand(GoMain);
        }

        async private void GoMain()
        {
            await _navigationservice.GoBackAsync();
            //await _navigationservice.NavigateAsync("MainPage");
        }
    }
}
