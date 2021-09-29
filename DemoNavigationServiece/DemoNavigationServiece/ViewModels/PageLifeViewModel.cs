using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoNavigationServiece.ViewModels
{
    public class PageLifeViewModel : ViewModelBase
    {
        public PageLifeViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }

        //public override void Initialize(INavigationParameters parameters)
        //{
        //    Console.WriteLine("We are appearing");
        //} 

        //public override void OnNavigatedTo(INavigationParameters parameters)
        //{
        //    Console.WriteLine("We are disappearing");
        //    
        //}

        public override void OnAppearing()
        {
            Console.WriteLine("We are disappearing");
        }
        public override void OnDisappearing()
        {
            Console.WriteLine("We are disappearing");
        }
    }
}
