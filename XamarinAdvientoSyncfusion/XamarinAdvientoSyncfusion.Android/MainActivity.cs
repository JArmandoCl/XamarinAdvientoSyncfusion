using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;

namespace XamarinAdvientoSyncfusion.Droid
{
    [Activity(Label = "XamarinAdvientoSyncfusion", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            try
            {
                TabLayoutResource = Resource.Layout.Tabbar;
                ToolbarResource = Resource.Layout.Toolbar;

                base.OnCreate(savedInstanceState);
                Forms.Init(this, savedInstanceState);
                Syncfusion.XForms.Android.PopupLayout.SfPopupLayoutRenderer.Init();
                LoadApplication(new App());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}