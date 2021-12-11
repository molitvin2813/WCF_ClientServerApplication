using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    partial class CRUD : IRequestTableCRUD,  IManagerTableCRUD, IRequestStateTableCRUD, IRequestTypeTableCRUD,
        ISystemAdministratorTableCRUD
    {
        public void CreateRequestTypeTable(string type, decimal price)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                RequestTypeTable requestTypeTable = 
                    new RequestTypeTable { Price = price, Type = type };

                db.RequestTypeTable.Add(requestTypeTable);
                db.SaveChanges();

            }
        }

        public void DeleteRequestTypeTable(long index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                db.RequestTypeTable.Remove(db.RequestTypeTable.Find(index));
                db.SaveChanges();
            }
        }

        public RequestTypeTable[] ReadRequestTypeTable()
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                RequestTypeTable[] requestTypeTables = db.RequestTypeTable.ToArray();
                return requestTypeTables;
            }
        }

        public void UpdateRequestTypeTable(string type, decimal price, long index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                RequestTypeTable requestTypeTable = db.RequestTypeTable.Find(index);
                if (requestTypeTable != null)
                {
                    requestTypeTable.Type = type;
                    requestTypeTable.Price = price;
                    db.SaveChanges();
                }
            }
        }
    }
}
