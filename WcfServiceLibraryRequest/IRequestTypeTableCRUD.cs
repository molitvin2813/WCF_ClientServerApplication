using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    [ServiceContract]
    interface IRequestTypeTableCRUD
    {
        [OperationContract]
        RequestTypeTable[] ReadRequestTypeTable();

        [OperationContract]
        void CreateRequestTypeTable(string type, decimal price);


        [OperationContract]
        void UpdateRequestTypeTable(string type, decimal price, long index);

        [OperationContract]
        void DeleteRequestTypeTable(long index);
    }
}
