using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    [ServiceContract]
    interface IBrigadeCRUD
    {
        [OperationContract]
        Brigade[] ReadBrigadeTable();

        [OperationContract]
        void CreateBrigadeTable(string name);


        [OperationContract]
        void UpdateBrigadeTable(string name, long index);

        [OperationContract]
        void DeleteBrigadeTable(long index);
    }
}
