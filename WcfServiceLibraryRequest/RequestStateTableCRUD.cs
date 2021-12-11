using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    partial class CRUD : IRequestTableCRUD, IManagerTableCRUD, IRequestStateTableCRUD, IRequestTypeTableCRUD,
        ISystemAdministratorTableCRUD
    {
        public void CreateRequestStateTable(string state)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                RequestStateTable requestState = new RequestStateTable { State = state };
                db.RequestStateTable.Add(requestState);
                db.SaveChanges();
            }
        }

        public RequestStateTable[] ReadRequestStateTable()
        {
            using (test_databaseContext db = new test_databaseContext())
            {

                RequestStateTable[] requestStateTables = db.RequestStateTable.ToArray();
                return requestStateTables;
            }
        }

      public void DeleteRequestStateTable(long index)
      {
          using (test_databaseContext db = new test_databaseContext())
          {

              db.RequestStateTable.Remove(db.RequestStateTable.Find(index));
              db.SaveChanges();
          }
      }
        
        public void UpdateRequestStateTable(string state, long index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {

                RequestStateTable requestStateTable = db.RequestStateTable.Find(index);
                if (requestStateTable != null)
                {
                    requestStateTable.State = state;
                    db.SaveChanges();
                }
            }
        }
        
    }
}
