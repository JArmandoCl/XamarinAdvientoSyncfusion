﻿using Syncfusion.Licensing;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinAdvientoSyncfusion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SyncfusionLicenseProvider.RegisterLicense("<AQUI VA TU KEY DE SYNCFUSION>");
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
