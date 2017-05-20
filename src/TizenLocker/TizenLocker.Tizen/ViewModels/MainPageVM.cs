using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Tizen.Applications;
using TizenLocker.Tizen.Containers.AppListing;

namespace TizenLocker.Tizen.ViewModels
{
    public class MainPageVM : BaseViewModel
    {
        private ObservableCollection<AppListingItem> _appList;

        public ObservableCollection<AppListingItem> AppList
        {
            get { return _appList; }
            set { _appList = value; OnPropertyChanged(); }
        }

        public async void LoadData()
        {
           var appsInstalled = await ApplicationManager.GetInstalledApplicationsAsync();
           
            AppList = new ObservableCollection<AppListingItem>();

            foreach (var app in appsInstalled.ToList())
            {
                var appInfo = PackageManager.GetPackage(app.PackageId);

                var appListingItem = new AppListingItem
                {
                    AppName = app.ExecutablePath,
                    Privileges = appInfo.Privileges.ToList()
                };

                if (!appListingItem.Privileges.Any())
                {
                    appListingItem.Privileges.Add("<No Privileges Requested>");    
                }

                AppList.Add(appListingItem);
            }
        }
    }
}