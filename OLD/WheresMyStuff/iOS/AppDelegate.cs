using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinIOS;
using UIKit;
using WheresMyStuff.iOS.Interfaces;
using Xamarin.Forms;

namespace WheresMyStuff.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
			DependencyService.Register<FileHelperiOS>();
			DependencyService.Register<ISQLitePlatform, SQLitePlatformIOS>();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
