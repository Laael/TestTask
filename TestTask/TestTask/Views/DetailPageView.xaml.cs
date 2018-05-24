using TestTask.Model;
using TestTask.ViewModels;


using Xamarin.Forms;

namespace TestTask.Views
{
    public partial class DetailPageView : ContentPage
    {

        public DetailViewModel ViewModel
        {
            get
            {
                return BindingContext as DetailViewModel;
            }
        }

        public DetailPageView()
        {
            InitializeComponent();


        }
    }
}