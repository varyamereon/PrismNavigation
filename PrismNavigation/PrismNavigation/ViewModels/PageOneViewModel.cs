using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismNavigation.ViewModels
{
    public class PageOneViewModel : BaseViewModel
    {
        public PageOneViewModel(PageNavigationService navigationService) : base(navigationService)
        {
        }
    }
}
