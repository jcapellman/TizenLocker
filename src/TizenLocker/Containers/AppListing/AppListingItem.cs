using System.Collections.Generic;

namespace TizenLocker.Tizen.Containers.AppListing
{
    public class AppListingItem
    {
        public string AppName { get; set; }

        public List<string> Privileges { get; set; }
    }
}