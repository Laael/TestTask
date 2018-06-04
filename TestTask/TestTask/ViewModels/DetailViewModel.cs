using Prism.Navigation;
using TestTask.Model;
using TestTask.Repository;

namespace TestTask.ViewModels
{
    public class DetailViewModel : BaseViewModel
    {
        private readonly DescriptionRepository descriptionRepository;


        AndroidVersion selectedVersion;
        AndroidVersion SelectedVersion
        {
            get 
            { 
                return selectedVersion;
            }
            set
            {
                SetProperty(ref selectedVersion, value);
            }
        }

        private Description selectedDescription;
        public Description SelectedDescription
        {
            get 
            { 
                return selectedDescription; 
            }
            set
            {
                SetProperty(ref selectedDescription, value);
            }
        }


    

       

        public DetailViewModel(
            INavigationService navigationService,
            DescriptionRepository DescriptionRepository): base(navigationService)
        {
            descriptionRepository = DescriptionRepository;
            Title = "Detail";
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            if (parameters != null && parameters.ContainsKey("id"))
            {
                int id = -1;
                var didParse = int.TryParse(parameters["id"].ToString(), out id);
                if (didParse && id > -1)
                {
                    LoadDescription(id);
                }
            }
        }

        void LoadDescription(int id)
        {
            SelectedVersion = descriptionRepository.GetVersionById(id);
          
            if(SelectedVersion != null)
                SelectedDescription = descriptionRepository.GetDescriptionsByVersion(id);

        }


    }
}
