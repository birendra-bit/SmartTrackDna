using System;
using Foundation;
using Xamarin.Forms;
using SmartTrackDna.iOS.src.Dependancies.Base;
using SmartTrackDna.Dependancies.Base;

[assembly: Dependency(typeof(PlatformService))]
namespace SmartTrackDna.iOS.src.Dependancies.Base
{
    public class PlatformService : IPlatformHelperService
    {
        public void ShowFlashingMessage(string message)
        {
            
        }

        public void ExitApplication()
        {
            // No action, able to exit from main app  
        }

        public string GetVersionNumber()
        {
            return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
        }

        public string GetBuildNumber()
        {
            return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString();
        }
    }
}
