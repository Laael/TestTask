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
    public class DetailViewModel : BaseViewModel
    {
        private readonly DescriptionRepository _descriptionRepository;


        private AndroidVersion _SelectedVersion;
        public AndroidVersion SelectedVersion
        {
            get { 
                return _SelectedVersion; }
            set
            {
                SetProperty(ref _SelectedVersion, value);
            }
        }

        private Description _SelectedDescription;
        public Description SelectedDescription
        {
            get { 
                return _SelectedDescription; }
            set
            {
                SetProperty(ref _SelectedDescription, value);
            }
        }


    

       

        public DetailViewModel(
            INavigationService navigationService,
            DescriptionRepository descriptionRepository
        )
            : base(navigationService)
        {
            _descriptionRepository = descriptionRepository;
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
            SelectedVersion = _descriptionRepository.GetVersionById(id);
          
            if(SelectedVersion != null)
                SelectedDescription = _descriptionRepository.GetDescriptionsByVersion(id);

        }


    }
}
