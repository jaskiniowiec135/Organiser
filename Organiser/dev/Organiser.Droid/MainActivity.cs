using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Organiser.Domain.Models.Data.Classes;
using System.Collections.Generic;

namespace Organiser.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        List<ActivityClass> activities;
        List<CategoryClass> categories;
        protected override void OnCreate(Bundle bundle)
        {
            activities = new List<ActivityClass>();
            categories = new List<CategoryClass>();
            categories.Add(new CategoryClass());

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}

