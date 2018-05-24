using Prism;
using Prism.Ioc;
using TestTask.ViewModels;
using TestTask.Views;
using Xamarin.Forms;
using TestTask.Model;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using System.Threading.Tasks;
using Java.Util.Logging;
using System;



[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TestTask
{
    public partial class App : PrismApplication
    {
      
        public App(IPlatformInitializer initializer) : base(initializer) { }

        public const string DATABASE_NAME = "android_versions.db";
        public static AndroidVersionsRepository database;
        public static AndroidVersionsRepository Repository
        {
            get
            {
                if (database == null)
                {
                    database = new AndroidVersionsRepository(DATABASE_NAME);
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
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<VersionsView, VersionsViewModel>();
            containerRegistry.RegisterForNavigation<DetailPageView, DetailViewModel>();
            containerRegistry.RegisterForNavigation<BaseNavigationPageView, BaseNavigationPageViewModel>();

        }
    }
}
