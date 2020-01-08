using System;
using System.ComponentModel;

namespace SmartTrackDna.Utils.Base
{
    public class AppLogger
    {
        public static void log(params Object[] msgs)
        {
            Console.WriteLine(string.Format("{0} : {1}", AppConstants.AppName, string.Join(" - ", msgs)));
        }

        public static void logObject(Object obj)
        {
            if (obj == null) return;

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
            {
                log(descriptor.Name, descriptor.GetValue(obj));
            }
        }
    }
}
