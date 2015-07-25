using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListOfProducts.Droid
{
    [Activity(Label = "ListOfProducts", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            //Xamarin.Insights.Initialize("c3d88c6f124fdabdf8880b65845094bb7bad90ac", this);
            //Xamarin.Insights.ForceDataTransmission = true;

            LoadApplication(new App());
        }
    }
}

        //protected override void OnCreate (Bundle bundle)
        //{
        //    base.OnCreate (bundle);

        //    global::Xamarin.Forms.Forms.Init (this, bundle);
        //    global::Xamarin.FormsMaps.Init (this, bundle);

        //    Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
        //    Xamarin.Insights.Initialize("c3d88c6f124fdabdf8880b65845094bb7bad90ac", this);
        //    Xamarin.Insights.ForceDataTransmission = true;

        //    LoadApplication (new App ());
        //    ImageCircleRenderer.Init();

        //    ActionBar.SetIcon ( new ColorDrawable (Resources.GetColor (Android.Resource.Color.Transparent)));
        //}