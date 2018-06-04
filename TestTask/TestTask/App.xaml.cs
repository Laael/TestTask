using Prism;
using Prism.Ioc;
using TestTask.ViewModels;
using TestTask.Views;
using Xamarin.Forms;
using TestTask.Model;
using Xamarin.Forms.Xaml;
using Prism.Unity;



[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TestTask
{
    public partial class App : PrismApplication
    {
      
        public App(IPlatformInitializer initializer) : base(initializer) { }

        public const string DataBaseName = "android_versions.db";
        private static  AndroidVersionsRepository database;
        public static  IRepository<AndroidVersion> Repository
        {
             get
            {
                if (database == null)
                {
                    database = AndroidVersionsRepository.Current;
                }
                return database;
            }
        }


        protected override async void OnInitialized()
        {


            InitializeComponent();
           

           

            await NavigationService.NavigateAsync("NavigationPage/VersionsView");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IRepository<AndroidVersion>, AndroidVersionsRepository>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<VersionsView, VersionsViewModel>();
            containerRegistry.RegisterForNavigation<DetailPageView, DetailViewModel>();
            containerRegistry.RegisterForNavigation<BaseNavigationPageView, BaseNavigationPageViewModel>();

        }
    }
}
