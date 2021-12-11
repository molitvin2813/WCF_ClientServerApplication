using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    partial class CRUD : IBrigadeCRUD
    {
        public void CreateBrigadeTable(string name)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                Brigade newRecord = new Brigade { Name = name };

                db.Brigade.Add(newRecord);
                db.SaveChanges();
            }
        }

        public void DeleteBrigadeTable(long index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                db.Brigade.Remove(db.Brigade.Find(index));
                db.SaveChanges();
            }
        }

        public Brigade[] ReadBrigadeTable()
        {
            using (test_databaseContext db = new test_databaseContext())
            {

                Brigade[] brigadeTables = db.Brigade.ToArray();
                return brigadeTables;
            }
        }

        public void UpdateBrigadeTable(string name, long index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                Brigade brigadeTable = db.Brigade.Find(index);
                if (brigadeTable != null)
                {
                    brigadeTable.Name = name;
                    db.SaveChanges();
                }
            }
        }
    }
}
