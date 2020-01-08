using System;
using System.Threading.Tasks;
using Android.App;
using Android.Content.PM;
using Android.Support.Design.Widget;
using Plugin.CurrentActivity;
using SmartTrackDna.Dependancies.Base;
using SmartTrackDna.Droid.src.Dependancies.Base;
using SmartTrackDna.Utils.Base;
using Xamarin.Forms;

[assembly: Dependency(typeof(PlatformService))]
namespace SmartTrackDna.Droid.src.Dependancies.Base
{
    public class PlatformService : IPlatformHelperService
    {
        public void ShowFlashingMessage(string message)
        {
            Activity activity = CrossCurrentActivity.Current.Activity;
            Android.Views.View view = activity.FindViewById(Android.Resource.Id.Content);
            Snackbar.Make(view, message, Snackbar.LengthLong).Show();
        }

        public void ExitApplication()
        {
            // No action, able to exit from main app   
        }

        public string GetVersionNumber()
        {
            using (PackageInfo appInfo = CrossCurrentActivity.Current.AppContext.PackageManager.GetPackageInfo(CrossCurrentActivity.Current.AppContext.PackageName, 0))
            {
                return appInfo.VersionName;
            }
        }

        public string GetBuildNumber()
        {
            using (PackageInfo appInfo = CrossCurrentActivity.Current.AppContext.PackageManager.GetPackageInfo(CrossCurrentActivity.Current.AppContext.PackageName, 0))
            {
                return appInfo.VersionCode.ToString();
            }
        }
    }
}
