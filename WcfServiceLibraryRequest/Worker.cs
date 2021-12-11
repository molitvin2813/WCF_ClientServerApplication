using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WcfServiceLibraryRequest
{
    public partial class Worker
    {
        public long IdWorker { get; set; }
        public string Name { get; set; }
        public float Percent { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public long? IdBrigade { get; set; }

        public virtual Brigade IdBrigadeNavigation { get; set; }
    }
}
