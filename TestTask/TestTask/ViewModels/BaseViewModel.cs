using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace TestTask.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware
    {

        protected readonly INavigationService _navigationService;

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }



        public DelegateCommand<string> NavCommand { get; set; }

        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavCommand = new DelegateCommand<string>(Navigate);
        }

        private async void Navigate(string name)
        {
            await _navigationService.NavigateAsync(name);
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
