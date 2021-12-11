using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    [ServiceContract]
    interface IRequestStateTableCRUD
    {
        [OperationContract]
        RequestStateTable[] ReadRequestStateTable();

        [OperationContract]
        void CreateRequestStateTable(string state);

        [OperationContract]
        void UpdateRequestStateTable(string state, long index);

        [OperationContract]
        void DeleteRequestStateTable(long index);
    }
}
