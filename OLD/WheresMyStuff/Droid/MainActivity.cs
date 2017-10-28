using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using WheresMyStuff.Droid.Interfaces;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;

namespace WheresMyStuff.Droid
{
    [Activity(Label = "WheresMyStuff.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

      
            base.OnCreate(bundle);

            DependencyService.Register<FileHelperDroid>();
            DependencyService.Register<ISQLitePlatform, SQLitePlatformAndroid>();

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}
