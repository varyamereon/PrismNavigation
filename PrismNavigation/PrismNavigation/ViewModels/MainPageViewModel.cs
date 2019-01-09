using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Navigation;

namespace PrismNavigation.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public List<MenuItem> MenuItems { get; private set; }

        public MainPageViewModel(PageNavigationService navigationService) : base(navigationService)
        {
            MenuItems = new List<MenuItem>()
            {
                new MenuItem()
                {
                    Title="Page One",
                    Uri="NavigationPage/PageOne",
                },
                new MenuItem()
                {
                    Title="Page Two",
                    Uri="NavigationPage/PageTwo"
                }
            };

            NavigateCommand = new DelegateCommand<MenuItem>(OnNavigateCommandExecuted);
        }

        public DelegateCommand<MenuItem> NavigateCommand { get; }
        private async void OnNavigateCommandExecuted(MenuItem menuItem) => await _navigationService.NavigateAsync(menuItem?.Uri);
    }

    public class MenuItem
    {
        public string Title { get; set; }
        public string Uri { get; set; }
    }
}
