using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    [ServiceContract]
    interface ISystemAdministratorTableCRUD
    {
        [OperationContract]
        SystemAdministratorTable[] ReadSystemAdministratorTable();

        [OperationContract]
        void CreateSystemAdministratorTable(string name);


        [OperationContract]
        void UpdateSystemAdministratorTable(string name, long index);

        [OperationContract]
        void DeleteSystemAdministratorTable(long index);

    }
}
