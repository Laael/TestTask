using System.Collections.Generic;
using Prism.Commands;
using Prism.Navigation;
using TestTask.Model;
using TestTask.Repository;


namespace TestTask.ViewModels
{
    public class VersionsViewModel : BaseViewModel
    {
        private readonly DescriptionRepository descriptionRepository;
   

        private List<AndroidVersion> androidVersions;

      

        public List<AndroidVersion> AndroidVersions
        {
            get 
            {
                return androidVersions; 
            }
        }


        public DelegateCommand<AndroidVersion> ItemClicked 
        { 
            get;
            private set;
        }

        public VersionsViewModel(INavigationService navigationService, DescriptionRepository DescriptionRepository) : base(navigationService)
        {
            descriptionRepository = DescriptionRepository;

            androidVersions = App.Repository.GetItems();

            Title = "Versions";
            ItemClicked = new DelegateCommand<AndroidVersion>(DoVersionClicked);
         
        }

        private async void DoVersionClicked(AndroidVersion version)
        {
         
                var parameter = new NavigationParameters($"id={version.ID}");
                await navigationService.NavigateAsync("DetailPageView", parameter);
       
           
        }


     
    }
}
