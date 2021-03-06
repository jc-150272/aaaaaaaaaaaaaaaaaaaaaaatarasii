﻿using System.Diagnostics;
using System.Runtime.CompilerServices;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;

namespace KamishibaiSample.MasterDetailPage.ViewModels
{
    public class MyMasterDetailPageViewModel : ViewModelBase, IPageLifecycleAware
    {
        public NavigationRequestCommand PushToDetailRequestCommand { get; } = new NavigationRequestCommand();
        public NavigationRequestCommand SetDetailRequestCommand { get; } = new NavigationRequestCommand();
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
