using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace DemoNavigationServiece.ViewModels
{
    public class PageAViewModel : ViewModelBase
    {
        private string _data;
        public string Data
        {
            get { return _data; }
            set { SetProperty(ref _data, value); }
        }
        public Command ClickBnt { get; }
        public readonly INavigationService _navigationService;
        public PageAViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            ClickBnt = new Command(GoBack);

        }
        public async void GoBack()
        {
           await _navigationService.GoBackAsync();
        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Data = parameters.GetValue<string>("title");
            // _nameDepartment 
            //Binding dữ liệu khi chuyển trang
            
        }
    }
}
