using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;
using MappyRoads.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceInfo))]
namespace MappyRoads.Droid
{
    public class DeviceInfo : IDevice
    {
        private static DeviceInfo instance;
        private DisplayMetrics dpm;

        public DeviceInfo()
        {
            dpm = MainActivity.dpm;
        }

        public int getheight()
        {

            return dpm.HeightPixels;
        }

        public int getwidth()
        {
            return dpm.WidthPixels;
        }
    }
}
