using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismNavigation.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismNavigation.ViewModels
{
    public class PageTwoViewModel : BaseViewModel
    {
        public PageTwoViewModel(PageNavigationService navigationService) : base(navigationService)
        {
        }

        public DelegateCommand GoDeeperCommand => new DelegateCommand(OnGoDeeperCommandExecutedAsync);

        private async void OnGoDeeperCommandExecutedAsync()
        {
                var success = await _navigationService.NavigateAsync(nameof(DeepPage));

            if (success.Success == false)
                throw new Exception("Fail", success.Exception);
        }
    }
}
