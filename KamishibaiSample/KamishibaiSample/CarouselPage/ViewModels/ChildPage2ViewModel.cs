﻿using System.Diagnostics;
using System.Runtime.CompilerServices;
using Kamishibai.Xamarin.Forms;

namespace KamishibaiSample.CarouselPage.ViewModels
{
    public class ChildPage2ViewModel : ViewModelBase, IPageLifecycleAware
    {
        public void OnInitialize()
        {
            WriteLog();
        }

        public void OnLoaded()
        {
            WriteLog();
        }

        public void OnUnloaded()
        {
            WriteLog();
        }

        public void OnClosed()
        {
            WriteLog();
        }

        private void WriteLog(object param = null, [CallerMemberName] string name = null)
        {
            Debug.WriteLine($"{GetType().Name}${name}({param})");
        }

    }
}
