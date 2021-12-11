using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    [ServiceContract]
    interface IStreetTableCRUD
    {
        [OperationContract]
        StreetTable[] ReadStreetTable();

        [OperationContract]
        void CreateStreetTable(string name);

        [OperationContract]
        void UpdateStreetTable(string name, int index);

        [OperationContract]
        void DeleteStreetTable(int index);
    }
}
