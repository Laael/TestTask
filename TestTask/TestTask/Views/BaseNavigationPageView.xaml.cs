﻿using Prism.Navigation;

using Xamarin.Forms;

namespace TestTask.Views
{
    public partial class BaseNavigationPageView 
        : NavigationPage, INavigationPageOptions
    {

        public BaseNavigationPageView()
        {
            InitializeComponent();
        }

    

        public bool ClearNavigationStackOnNavigation 
        {
            get 
            {
                return true;
            }
        }



       

       
    }
}
