using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Organiser.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        bool on_start_page;
        protected override void OnCreate(Bundle bundle)
        {
            //TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;
            on_start_page = true;
            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            SetContentView(Resource.Layout.Toolbar);
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            LoadApplication(new App());
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.navigation, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Resource.Id.add_activity)
            {
                SetContentView(Resource.Layout.Add_Activity);
                on_start_page = false;
            }
            return base.OnOptionsItemSelected(item);
        }
        public override void OnBackPressed()
        {
            if (on_start_page == false)
            {
                SetContentView(Resource.Layout.Toolbar);
                on_start_page = true;
            }
            base.OnBackPressed();
        }
    }
}

