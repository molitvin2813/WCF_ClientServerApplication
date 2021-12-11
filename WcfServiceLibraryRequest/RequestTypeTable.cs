using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WcfServiceLibraryRequest
{
    public partial class RequestTypeTable
    {
        public RequestTypeTable()
        {
            RequestTable = new HashSet<RequestTable>();
        }

        public long IdRequestType { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<RequestTable> RequestTable { get; set; }
    }
}
