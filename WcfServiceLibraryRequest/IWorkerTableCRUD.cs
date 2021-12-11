using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    [ServiceContract]
    interface IWorkerTableCRUD
    {
        [OperationContract]
        Worker[] ReadWorkerTable();

        [OperationContract]
        void CreateWorkerTable(string name, float percent, long idBrigade);

        [OperationContract]
        void UpdateWorkerTable(string name, float percent, long idBrigade, long index);

        [OperationContract]
        void DeleteWorkerTable(long index);
    }
}
