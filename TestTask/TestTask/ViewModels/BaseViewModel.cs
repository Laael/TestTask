using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace TestTask.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware
    {

        protected readonly INavigationService navigationService;

        private string title;
        public string Title
        {
            get 
            {
                return title;
            }
            set 
            { 
                SetProperty(ref title, value);
            }
        }



        DelegateCommand<string> NavCommand 
        {
            get; 
            set;
        }

        public BaseViewModel(INavigationService NavigationService)
        {
            navigationService = NavigationService;
            NavCommand = new DelegateCommand<string>(Navigate);
        }

        private async void Navigate(string name)
        {
            await navigationService.NavigateAsync(name);
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
           
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
           
        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {
           
        }
    }
}
