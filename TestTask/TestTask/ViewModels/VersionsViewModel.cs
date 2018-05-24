using System;
using System.Diagnostics;
using System.Collections.ObjectModel;

using Prism.Commands;
using Prism.Navigation;
using Prism.Events;

using Xamarin.Forms;
using System.Linq;

using TestTask.Model;
using TestTask.Repository;


namespace TestTask.ViewModels
{
    public class VersionsViewModel : BaseViewModel
    {
        private readonly DescriptionRepository _descriptionRepository;
   

        private ObservableCollection<AndroidVersion> _androidVersions;

      

        public ObservableCollection<AndroidVersion> AndroidVersions
        {
            get { return _androidVersions; }
        }


        public DelegateCommand<AndroidVersion> ItemClicked { get; set; }

        public VersionsViewModel(
            INavigationService navigationService,
            DescriptionRepository descriptionRepository
        )
            : base(navigationService)
        {
            _descriptionRepository = descriptionRepository;
            //Репозиторий с описанием передаю в параметрах конструктора

            // Репозиторий с версиями общий на весь код, поэтому не передаю его в параметрах
            _androidVersions = App.Repository.GetItems();

            Title = "Versions";
            ItemClicked = new DelegateCommand<AndroidVersion>(DoVersionClicked);
         
        }

        private async void DoVersionClicked(AndroidVersion version)
        {
            if (Device.Idiom == TargetIdiom.Phone)
            {
                var parameter = new NavigationParameters($"id={version.id}");
                await _navigationService.NavigateAsync("DetailPageView", parameter);
            }
           
        }


     
    }
}
