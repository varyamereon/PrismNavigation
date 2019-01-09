using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismNavigation.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware
    {
        protected PageNavigationService _navigationService { get; }

        public BaseViewModel(PageNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters) { }
        public virtual void OnNavigatedTo(INavigationParameters parameters) { }
        public virtual void OnNavigatingTo(INavigationParameters parameters) { }
    }
}
