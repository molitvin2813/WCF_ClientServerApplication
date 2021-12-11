using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WcfServiceLibraryRequest
{
    public partial class RequestTable
    {
        public long IdRequestState { get; set; }
        public long AccountBalance { get; set; }
        public long IdRequestType { get; set; }
        public string CommentForRequest { get; set; }
        public long? CountTv { get; set; }
        public string Speed { get; set; }
        public string Ping { get; set; }
        public string CommentMechanic { get; set; }
        public DateTime? DateCreate { get; set; }
        public long? IdManager { get; set; }
        public long? IdSystemAdministrator { get; set; }
        public string Review { get; set; }
        public int IdRequest { get; set; }
        public DateTime? DateOfCompletion { get; set; }
        public string FioClient { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public string PhoneNumber { get; set; }
        public string Port { get; set; }
        public long? IdBrigade { get; set; }
        public int? IdStreet { get; set; }

        public virtual Brigade IdBrigadeNavigation { get; set; }
        public virtual ManagerTable IdManagerNavigation { get; set; }
        public virtual RequestStateTable IdRequestStateNavigation { get; set; }
        public virtual RequestTypeTable IdRequestTypeNavigation { get; set; }
        public virtual StreetTable IdStreetNavigation { get; set; }
        public virtual SystemAdministratorTable IdSystemAdministratorNavigation { get; set; }
    }
}
