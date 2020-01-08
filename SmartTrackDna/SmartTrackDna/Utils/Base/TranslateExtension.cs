using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartTrackDna.Utils.Base
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return GetValue(Text);
        }

        public static string GetValue(string key)
        {
            if (key == null)
                return null;

            return AppResourceManager.GetString(key);
        }
    }
}
