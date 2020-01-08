using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace SmartTrackDna.Utils.Base
{
    public class AppResourceManager
    {
        static readonly Lazy<ResourceManager> ResourceManager =
            new Lazy<ResourceManager>(() =>
                new ResourceManager(AppConstants.AppResourceId, typeof(TranslateExtension)
                    .GetTypeInfo().Assembly));

        public static string GetString(string key)
        {
            return ResourceManager.Value.GetString(key, CultureInfo.CurrentCulture);
        }
    }
}