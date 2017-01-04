using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace PrismDeNwnpOnTab.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private INavigationService _navigationservice;
        public ICommand GoSubCommand { get; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;
            GoSubCommand = new DelegateCommand(GoSub);
        }

        async private void GoSub()
        {
            await _navigationservice.NavigateAsync("SubPage");
            // タブの中だけサブページに切り替えたいけど無理っぽい
            // タブも覆い隠してサブページが表示されちゃう
        }
    }
}
