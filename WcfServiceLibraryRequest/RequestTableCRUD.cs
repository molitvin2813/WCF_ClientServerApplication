using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    partial class CRUD : IRequestTableCRUD
    {
        public void CreateRequestTable
            (
                long accountBalance, long idRequestType, string commentForRequest,
                long? countTV, string speed, string ping, string commentMechanic,
                DateTime? dateCreate, long? idBrigade, long? idManager,
                long? idSystemAdministrator, string review, long idRequestState,
                string fioClient, int street, string house, string apartment,
                string phoneNumber, string port
            )
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                RequestTable requestTable = new RequestTable
                {
                    AccountBalance = accountBalance,
                    IdRequestType = idRequestType,
                    CommentForRequest = commentForRequest,
                    CountTv = countTV,
                    Speed = speed,
                    Ping = ping,
                    CommentMechanic = commentMechanic,
                    DateCreate = dateCreate,
                    IdBrigade = idBrigade,
                    IdManager = idManager,
                    IdSystemAdministrator = idSystemAdministrator,
                    Review = review,
                    IdRequestState = idRequestState,
                    FioClient = fioClient,
                    IdStreet = street,
                    House = house,
                    Apartment = apartment,
                    PhoneNumber = phoneNumber,
                    Port = port                    
                };

                db.RequestTable.Add(requestTable);
                db.SaveChanges();

            }
        }

        public void DeleteRequestTable(int index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                db.RequestTable.Remove(db.RequestTable.Find(index));
                db.SaveChanges();
            }
        }

        public RequestTable[] ReadRequestTable()
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                return db.RequestTable.ToArray();
            }
        }

        public void UpdateRequestTable
            (
                long accountBalance, long idRequestType, string commentForRequest,
                long? countTV, string speed, string ping, string commentMechanic,
                DateTime? dateOfCompletion, long? idBrigade, long? idManager,
                long? idSystemAdministrator, string review, long idRequestState,
                string fioClient, int street, string house, string apartment,
                string phoneNumber, string port, int index
            )
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                RequestTable requestTable = db.RequestTable.Find(index);

                if(requestTable != null)
                {
                    if (accountBalance != -1)
                        requestTable.AccountBalance = accountBalance;

                    if (idRequestType != -1)
                        requestTable.IdRequestType = idRequestType;

                    if(commentForRequest !="")
                        requestTable.CommentForRequest = commentForRequest;

                    if(countTV != -1)
                        requestTable.CountTv = countTV;
                    if (speed != "")
                        requestTable.Speed = speed;
                    if (ping != "")
                        requestTable.Ping = ping;
                    if (commentMechanic != "")
                        requestTable.CommentMechanic = commentMechanic;

                    if (dateOfCompletion != null)
                        requestTable.DateOfCompletion = dateOfCompletion;

                    if (idBrigade != -1)
                        requestTable.IdBrigade = idBrigade;
                    if (idManager != -1)
                        requestTable.IdManager = idManager;
                    if (idSystemAdministrator != -1)
                        requestTable.IdSystemAdministrator = idSystemAdministrator;
                    if (review != "")
                        requestTable.Review = review;

                    if (idRequestState != -1)
                        requestTable.IdRequestState = idRequestState;

                    if (fioClient != "")
                        requestTable.FioClient = fioClient;

                    if (street != -1)
                        requestTable.IdStreet = street;

                    if (house != "")
                        requestTable.House = house;

                    if (apartment != "")
                        requestTable.Apartment = apartment;

                    if (phoneNumber != "")
                        requestTable.PhoneNumber = phoneNumber;

                    if (port != "")
                        requestTable.Port = port;

                 
                    db.SaveChanges();
                }
            }
        }
    }
}
