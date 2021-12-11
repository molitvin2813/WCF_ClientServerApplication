using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WcfServiceLibraryRequest
{
    public partial class StreetTable
    {
        public StreetTable()
        {
            RequestTable = new HashSet<RequestTable>();
        }

        public int IdStreet { get; set; }
        public string Street { get; set; }

        public virtual ICollection<RequestTable> RequestTable { get; set; }
    }
}
