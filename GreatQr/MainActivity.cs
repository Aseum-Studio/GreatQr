using System;
using Android.App;
using Android.Views;
using Android.OS;
using Debug = System.Diagnostics.Debug;
using AndroidX.AppCompat.App;
using System.Threading.Tasks;
using Android.Widget;
using Android.Content;

namespace GreatQr
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, GestureDetector.IOnGestureListener
    {
        private GestureDetector mDetector;
        private DataSaver dataSaver;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            mDetector = new GestureDetector(this);
            dataSaver = new DataSaver();

            _ = CheckIsFirstStart();
        }

        private async Task CheckIsFirstStart()
        {
            dataSaver.setKey("firstStart");
            bool isFirstStart = await dataSaver.getStringValue() == null;
            Debug.WriteLineIf(isFirstStart, "first start");
            Debug.WriteLineIf(!isFirstStart, "other start");
            if (isFirstStart)
            {
                Toast
                    .MakeText(this, "长按屏幕可以设置图片哦!", ToastLength.Long)
                    .Show();
                _ = dataSaver.setStringValue("yes");
            }
        }

        public bool OnDown(MotionEvent e)
        {
            return false;
        }

        public bool OnFling(MotionEvent e1, MotionEvent e2, float velocityX, float velocityY)
        {
            return false;
        }

        public void OnLongPress(MotionEvent e)
        {
            Debug.WriteLine("Long press");
            StartActivity(typeof(SettingsActivity));
        }

        public bool OnScroll(MotionEvent e1, MotionEvent e2, float distanceX, float distanceY)
        {
            return false;
        }

        public void OnShowPress(MotionEvent e)
        {
        }

        public bool OnSingleTapUp(MotionEvent e)
        {
            return false;
        }

        public override bool OnTouchEvent(MotionEvent e)
        {
            mDetector.OnTouchEvent(e);
            return false;
        }

    }
}
