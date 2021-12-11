using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    partial class CRUD :  IWorkerTableCRUD
    {

        public void CreateWorkerTable(string name, float percent, long idBrigade)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                Worker worker = new Worker { Name = name, Percent = percent, IdBrigade = idBrigade };

                db.Worker.Add(worker);
                db.SaveChanges();
            }
        }

        public void DeleteWorkerTable(long index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                db.Worker.Remove(db.Worker.Find(index));
                db.SaveChanges();
            }
        }

        public Worker[] ReadWorkerTable()
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                return db.Worker.ToArray();
            }
        }

        public void UpdateWorkerTable(string name, float percent, long idBrigade, long index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                Worker worker = db.Worker.Find(index);
                if (worker != null)
                {
                    worker.Name = name;
                    worker.Percent = percent;
                    worker.IdBrigade = idBrigade;

                    db.SaveChanges();
                }
            }
        }
    }
}
