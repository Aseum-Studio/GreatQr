using System;
using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using Debug = System.Diagnostics.Debug;

namespace GreatQr
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class SettingsActivity: AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_settings);
        }
    }
}
