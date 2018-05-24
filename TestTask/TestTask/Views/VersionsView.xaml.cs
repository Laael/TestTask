using System;
using System.Collections.Generic;
using System.Diagnostics;
using TestTask.Model;
using TestTask.ViewModels;

using Xamarin.Forms;

namespace TestTask.Views
{
    public partial class VersionsView : ContentPage
    {

        public VersionsViewModel ViewModel 
        { 
            get
            { 
                return BindingContext as VersionsViewModel; 
            }
        }

        public VersionsView()
        {
            InitializeComponent();
           
                lvVersions.ItemSelected += (o, e) =>
                {
                    if (e.SelectedItem is AndroidVersion)
                    {
                        var version = e.SelectedItem as AndroidVersion;
                        ViewModel.ItemClicked.Execute(version);
                    }

                };
            
           

        }
    }
}
