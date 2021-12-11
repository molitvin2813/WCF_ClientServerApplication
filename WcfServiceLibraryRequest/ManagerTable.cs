using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WcfServiceLibraryRequest
{
    public partial class ManagerTable
    {
        public ManagerTable()
        {
            RequestTable = new HashSet<RequestTable>();
        }

        public long IdManager { get; set; }
        public string Name { get; set; }
        public float? Percent { get; set; }

        public virtual ICollection<RequestTable> RequestTable { get; set; }
    }
}
