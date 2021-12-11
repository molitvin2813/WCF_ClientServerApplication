using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WcfServiceLibraryRequest
{
    public partial class StorageItem
    {
        public StorageItem()
        {
            Storage = new HashSet<Storage>();
        }

        public long IdStorageItem { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Storage> Storage { get; set; }
    }
}
