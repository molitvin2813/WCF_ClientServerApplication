using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    [ServiceContract]
    interface IRequestTableCRUD
    {

        [OperationContract]
        RequestTable[] ReadRequestTable();


        [OperationContract]
        void CreateRequestTable(
                long accountBalance, long idRequestType, string commentForRequest,
                long? countTV, string speed, string ping, string commentMechanic,
                DateTime? dateCreate, long? idBrigade, long? idManager,
                long? idSystemAdministrator, string review, long idRequestState,
                string fioClient, int street, string house, string apartment,
                string phoneNumber, string port
            );


        [OperationContract]
        void UpdateRequestTable(
                long accountBalance, long idRequestType, string commentForRequest,
                long? countTV, string speed, string ping, string commentMechanic,
                DateTime? dateOfCompletion, long? idBrigade, long? idManager,
                long? idSystemAdministrator, string review, long idRequestState,
                string fioClient, int street, string house, string apartment,
                string phoneNumber, string port, int index
            );

        [OperationContract]
        void DeleteRequestTable(int index);
    }
}

