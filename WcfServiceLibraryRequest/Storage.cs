using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WcfServiceLibraryRequest
{
    public partial class Storage
    {
        public long IdStorage { get; set; }
        public long? IdStorageItem { get; set; }
        public DateTime? DateAdded { get; set; }

        public virtual StorageItem IdStorageItemNavigation { get; set; }
    }
}
