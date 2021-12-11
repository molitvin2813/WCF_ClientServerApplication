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
        public void CreateSystemAdministratorTable(string name)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                SystemAdministratorTable systemAdministratorTable = 
                    new SystemAdministratorTable { Name = name };

                db.SystemAdministratorTable.Add(systemAdministratorTable);
                db.SaveChanges();
            }
        }

        public void DeleteSystemAdministratorTable(long index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                db.SystemAdministratorTable.Remove(db.SystemAdministratorTable.Find(index));
                db.SaveChanges();
            }
        }

        public SystemAdministratorTable[] ReadSystemAdministratorTable()
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                return db.SystemAdministratorTable.ToArray();
            }
        }

        public void UpdateSystemAdministratorTable(string name, long index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                SystemAdministratorTable systemAdministratorTable = db.SystemAdministratorTable.Find(index);
                if(systemAdministratorTable != null)
                {
                    systemAdministratorTable.Name = name;
                    db.SaveChanges();
                }
            }
        }
    }
}
