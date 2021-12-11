using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    [ServiceContract]
    interface IManagerTableCRUD
    {
        [OperationContract]
        ManagerTable[] ReadManagerTable();

        [OperationContract]
        void CreateManagerTable(string name, float percent);


        [OperationContract]
        void UpdateManagerTable(string name, float percent,  long index);

        [OperationContract]
        void DeleteManagerTable(long index);
    }
}
