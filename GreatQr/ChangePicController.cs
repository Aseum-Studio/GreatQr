using System;
using Android.App;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
namespace GreatQr
{
    public class ChangePicController
    {
        private AppCompatActivity mActivity;
        public ChangePicController(AppCompatActivity activity)
        {
            mActivity = activity;
        }
        public void changePic()
        {
            mActivity.Finish();
        }
    }
}
