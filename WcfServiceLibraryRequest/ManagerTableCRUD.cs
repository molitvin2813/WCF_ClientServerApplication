using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    partial class CRUD : IManagerTableCRUD
    {
        public void CreateManagerTable(string name, float percent)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                ManagerTable newRecord = new ManagerTable { Name = name, Percent = percent };

                db.ManagerTable.Add(newRecord);
                db.SaveChanges();
            }
        }

        public void DeleteManagerTable(long index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                db.ManagerTable.Remove(db.ManagerTable.Find(index));
                db.SaveChanges();
            }
        }

        public ManagerTable[] ReadManagerTable()
        {
            using (test_databaseContext db = new test_databaseContext())
            {

                ManagerTable[] managerTables = db.ManagerTable.ToArray();
                return managerTables;
            }
        }

        public void UpdateManagerTable(string name, float percent, long index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                ManagerTable managerTable = db.ManagerTable.Find(index);
                if(managerTable != null)
                {
                    managerTable.Name = name;
                    managerTable.Percent = percent;
                    db.SaveChanges();
                }
            }
        }
    }
}
