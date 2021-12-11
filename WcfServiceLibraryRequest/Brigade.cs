using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WcfServiceLibraryRequest
{
    public partial class Brigade
    {
        public Brigade()
        {
            RequestTable = new HashSet<RequestTable>();
            Worker = new HashSet<Worker>();
        }

        public long IdBrigade { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RequestTable> RequestTable { get; set; }
        public virtual ICollection<Worker> Worker { get; set; }
    }
}
