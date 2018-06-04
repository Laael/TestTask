using Prism.Navigation;

namespace TestTask.ViewModels
{
    public class BaseNavigationPageViewModel: BaseViewModel

    {
        public BaseNavigationPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
           
        }
    }
}
