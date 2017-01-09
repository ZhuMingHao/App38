using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App38
{
    public class OnPlatformExt<T> : OnPlatform<T>
    {
        public T Android { get; set; }
        public T iOS { get; set; }
        public T WinPhone { get; set; }
        public T Windows { get; set; }
        public T Other { get; set; }

        public OnPlatformExt()
        { 
            Android = default(T);
            iOS = default(T);
            WinPhone = default(T);
            Windows = default(T);
            Other = default(T);
        }

        public static implicit operator T(OnPlatformExt<T> onPlatform)
        {
            switch (Xamarin.Forms.Device.OS)
            {
                case Xamarin.Forms.TargetPlatform.Android:
                    return onPlatform.Android;

                case Xamarin.Forms.TargetPlatform.iOS:
                    return onPlatform.iOS;

                case Xamarin.Forms.TargetPlatform.WinPhone:
                    return onPlatform.WinPhone;

                case Xamarin.Forms.TargetPlatform.Windows:
                    return onPlatform.Windows;

                default:
                    return onPlatform.Other;
            }
        }
    }
}
