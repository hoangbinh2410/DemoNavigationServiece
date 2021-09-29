using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoNavigationServiece.ViewModels
{
    public class Page_LifecycleViewModel : ViewModelBase, IPageLifecycleAware
    {
        public Page_LifecycleViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }

        public void OnAppearing()
        {
            Console.WriteLine("We are appearing");
        }

        public void OnDisappearing()
        {
            Console.WriteLine("We are disappearing");
        }
    }
}
