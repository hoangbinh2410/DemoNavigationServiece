using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoNavigationServiece.ViewModels
{
    public class BasicNavigationViewModel : ViewModelBase,IConfirmNavigation,IConfirmNavigationAsync
    {
        public Command ClickBnt { get; }
        public readonly INavigationService _navigationService;
        public readonly IPageDialogService _pageDialogService;
        public BasicNavigationViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
            ClickBnt = new Command(GoPage);
        }
        public async void GoPage()
        {
            var p = new NavigationParameters();
            p.Add("title", "hello");

            await _navigationService.NavigateAsync("PageA", p);
        }

        // thien xong chuyen trang
        public bool CanNavigate(INavigationParameters parameters)
        {
            
            return true;
        }

        public Task<bool> CanNavigateAsync(INavigationParameters parameters)
        {
            return _pageDialogService.DisplayAlertAsync("My title", "Save", "Ok", "Cancel");
        }
        public override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Unsubscribe<App>(this, "Hi");
        }

        public override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<App>(this, "Bye");
        }


    }
}
