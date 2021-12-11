using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    partial class CRUD : IStreetTableCRUD
    {
        public void CreateStreetTable(string name)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                StreetTable newRecord = new StreetTable { Street = name };

                db.StreetTable.Add(newRecord);
                db.SaveChanges();
            }
        }

        public void DeleteStreetTable(int index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                db.StreetTable.Remove(db.StreetTable.Find(index));
                db.SaveChanges();
            }
        }

        public StreetTable[] ReadStreetTable()
        {
            using (test_databaseContext db = new test_databaseContext())
            {

                StreetTable[] streetTables = db.StreetTable.ToArray();
                return streetTables;
            }
        }

        public void UpdateStreetTable(string name, int index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                StreetTable streetTable = db.StreetTable.Find(index);
                if (streetTable != null)
                {
                    streetTable.Street = name;
                    db.SaveChanges();
                }
            }
        }
    }
}
