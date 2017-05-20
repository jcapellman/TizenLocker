using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TizenLocker.Tizen.Containers.AppListing
{
    public class AppListingItem
    {
        public string AppName { get; set; }

        public List<string> Privileges { get; set; }
    }
}