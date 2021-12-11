using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    partial class CRUD : ISelect
    {
        public int GetCountRequestByMonths(int year, int month,  int index)
        {

            using (test_databaseContext db = new test_databaseContext())
            {
                var result  = from sto in db.RequestTable
                                      join ser in db.RequestStateTable on sto.IdRequestState equals ser.IdRequestState

                                      where
                                      sto.DateCreate.Value.Month == month &&
                                      sto.DateCreate.Value.Year == year

                                      select new
                                      {
                                          State = ser.State

                                      }; ;
                switch (index)
                {
                    case 1:
                        result = from sto in db.RequestTable
                                     join ser in db.RequestStateTable on sto.IdRequestState equals ser.IdRequestState

                                     where
                                     sto.DateCreate.Value.Month == month &&
                                     sto.DateCreate.Value.Year == year

                                     select new
                                     {
                                         State = ser.State

                                     };
                        break;
                    case 2:
                        result = from sto in db.RequestTable
                                     join ser in db.RequestStateTable on sto.IdRequestState equals ser.IdRequestState

                                     where
                                     sto.DateCreate.Value.Month == month &&
                                     sto.DateCreate.Value.Year == year &&
                                     ser.IdRequestState == 4

                                     select new
                                     {
                                         State = ser.State

                                     };
                        break;
                    case 3:
                        result = from sto in db.RequestTable
                                 join ser in db.RequestStateTable on sto.IdRequestState equals ser.IdRequestState

                                 where
                                 sto.DateCreate.Value.Month == month &&
                                 sto.DateCreate.Value.Year == year &&
                                 (
                                     ser.IdRequestState == 1 ||
                                     ser.IdRequestState == 2 ||
                                     ser.IdRequestState == 3 ||
                                     ser.IdRequestState == 5
                                 )
                                 select new
                                 {
                                     State = ser.State

                                 };
                        break;


                }
              
                return result.ToArray().Length;
             
            }
                
        }

        public int GetTotalCount( int index)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                var result = from sto in db.RequestTable

                             select new
                             {
                                 State = sto.IdRequest
                             };
                return result.ToArray().Count();
            }
        }

        public CountByDay[] GetCountRequestByDay(int year, int month, int index)
        {
            using (test_databaseContext db =new test_databaseContext())
            {
                CountByDay[] countByDays = new CountByDay[DateTime.DaysInMonth(year, month)];
                for (int i = 0; i < DateTime.DaysInMonth(year, month); i++)
                {
                    countByDays[i] = new CountByDay();
                    countByDays[i].Count = 0;
                    countByDays[i].Day = 0;
                }

                CountByDay[] summary = null;
                switch (index)
                {
                    case 2:

                        summary = (
                            from p in db.RequestTable
                            where (
                                    p.DateCreate.Value.Year == year &&
                                    p.DateCreate.Value.Month == month &&
                                    p.IdRequestState == 4
                                )
                            let k = new
                            {
                                Day = p.DateCreate.Value.Day,
                                ID = p.IdRequestState
                            }
                            group p by k into t
                            select new CountByDay
                            {
                                Day = t.Key.Day,
                                Count = t.Count()
                            }

                        ).ToArray();

                        break;
                    case 3:
                        summary = (
                             from p in db.RequestTable
                             where (
                                     p.DateCreate.Value.Year == year &&
                                     p.DateCreate.Value.Month == month &&
                                     (
                                        p.IdRequestState == 1 ||
                                        p.IdRequestState == 2 ||
                                        p.IdRequestState == 3 ||
                                        p.IdRequestState == 5 
                                     )
                                 )
                             let k = new
                             {
                                 Day = p.DateCreate.Value.Day,
                                 ID = p.IdRequestState
                             }
                             group p by k into t
                             select new CountByDay
                             {
                                 Day = t.Key.Day,
                                 Count = t.Count()
                             }

                        ).ToArray();
                        break;
                }
                
                for (int i = 0; i < summary.Length; i++)
                {
                    countByDays[summary[i].Day -1].Count += summary[i].Count;
                    countByDays[summary[i].Day -1].Day = summary[i].Day;
                }
                
                return countByDays;
            }
            
        }

        public Request[] GetRequestsBySomeDay(DateTime date)
        {
            
            using (test_databaseContext db = new test_databaseContext())
            {
                Request[] summary = null;

                summary = (

                    from request in db.RequestTable
                    join type in db.RequestTypeTable on request.IdRequestType equals type.IdRequestType
                    join state in db.RequestStateTable on request.IdRequestState equals state.IdRequestState
                    
                    where (
                        request.DateCreate.Value.Year == date.Year &&
                        request.DateCreate.Value.Month == date.Month &&
                        request.DateCreate.Value.Day == date.Day 
                    )
                           
                    select new Request
                    {
                        ID = request.IdRequest,
                        Street = (from ss in db.StreetTable
                                  where ss.IdStreet == request.IdStreet
                                  select new
                                  {
                                      ss.Street
                                  }).ToArray()[0].Street,
                        House = request.House,
                        Apartment = request.Apartment,
                        FIO = request.FioClient,
                        PhoneNumber = request.PhoneNumber,
                        State = state.State,
                        AccountBalance = request.AccountBalance,
                        Type = type.Type,
                        CommentForRequest = request.CommentForRequest
                    }

                ).ToArray();

                return summary;
            }                      
        }

        public ManagerReport[] GetManagerReport(DateTime date)
        {
            using (test_databaseContext db = new test_databaseContext())
            {
                var result = (from request in db.RequestTable
                              join manager in db.ManagerTable on request.IdManager equals manager.IdManager
                              join type in db.RequestTypeTable on request.IdRequestType equals type.IdRequestType

                              where (request.DateCreate.Value.Year == date.Year &&
                                    request.DateCreate.Value.Month == date.Month &&
                                    request.DateCreate.Value.Day == date.Day &&
                                    request.IdRequestState == 4
                                    )

                              select new ManagerReport
                              {
                                  IdManager = manager.IdManager,
                                  Name = manager.Name,
                                  Percent = (float)manager.Percent,
                                  Sum = (double)( manager.Percent * (double)type.Price)
                              }
                              ).ToArray();
                return result;
            }
        }
        public WorkerReport[] GetWorkerReport(DateTime date)
        {

            using (test_databaseContext db = new test_databaseContext())
            {
                var result = (from request in db.RequestTable
                              join worker in db.Worker on request.IdBrigade equals worker.IdBrigade
                              join type in db.RequestTypeTable on request.IdRequestType equals type.IdRequestType

                              where (request.DateCreate.Value.Year == date.Year &&
                                    request.DateCreate.Value.Month == date.Month &&
                                    request.DateCreate.Value.Day == date.Day &&
                                    request.IdRequestState == 4
                                    )

                              select new WorkerReport
                              {
                                  IdWorker = worker.IdWorker,
                                  Name = worker.Name,
                                  Percent = worker.Percent,
                                  Sum = worker.Percent * (double)type.Price
                              }
                              ).ToArray();
                return result;
            }
        }
    }
}
