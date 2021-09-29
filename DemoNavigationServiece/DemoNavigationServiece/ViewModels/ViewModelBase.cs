using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNavigationServiece.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible, IPageLifecycleAware
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {
            // đây là ham nhảy vào đầu tiên khi chuyển trang

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
            // đây làm hàm nhảy vào thứ 2 khi chuyển trang A sang trang B
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
            // đây là hàm nhảy vào thứ 2 khi chuyển từ màn hình screen vào trang
        }

        public virtual void Destroy()
        {
            // đây là hàm khi rời trang
        }

        public virtual void OnAppearing()
        {
           
        }

        public virtual void OnDisappearing()
        {
           
        }
    }
}
