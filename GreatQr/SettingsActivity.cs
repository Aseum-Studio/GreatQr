using System;
using Android.App;
using Android.OS;
using Android.Widget;
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

            FindViewById<ImageButton>(Resource.Id.backBtn).Click += backBtnClicked;
            FindViewById<ImageButton>(Resource.Id.changeBtn).Click += changeBtnClicked;
        }

        private void changeBtnClicked(object sender, EventArgs e)
        {
            ChangePicController changePicController = new ChangePicController(this);
            changePicController.changePic();
        }

        private void backBtnClicked(object sender, EventArgs e)
        {
            Finish();
        }
    }
}
