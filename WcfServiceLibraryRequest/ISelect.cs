using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryRequest
{
    [ServiceContract]
    interface ISelect
    {
        [OperationContract]
        int GetCountRequestByMonths(int year, int month, int index);

        [OperationContract]
        int GetTotalCount(int index);

        [OperationContract]
        CountByDay[] GetCountRequestByDay(int year, int month, int index);

        [OperationContract]
        Request[] GetRequestsBySomeDay(DateTime date);

        [OperationContract]
        WorkerReport[] GetWorkerReport(DateTime date);

        [OperationContract]
        ManagerReport[] GetManagerReport(DateTime date);
    }

    [DataContract]
    public class ManagerReport
    {
        private long idManager;
        private string name;
        private float percent;
        private double sum;

        [DataMember]
        public long IdManager
        {
            get { return idManager; }
            set { idManager = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public float Percent
        {
            get { return percent; }
            set { percent = value; }
        }
        [DataMember]
        public double Sum
        {
            get { return sum; }
            set { sum = value; }
        }
    }

    [DataContract]
    public class WorkerReport
    {
        private long idWorker;
        private string name;
        private float percent;
        private double sum;

        [DataMember]
        public long IdWorker
        {
            get { return idWorker; }
            set { idWorker = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public float Percent
        {
            get { return percent; }
            set { percent = value; }
        }
        [DataMember]
        public double Sum
        {
            get { return sum; }
            set { sum = value; }
        }
    }

    [DataContract]
    public class Request
    {
        int id;
        string street;
        string house;
        string apartment;
        string fio;
        string phoneNumber;
        string state;
        long accountBalance;
        string type;
        string commentForRequest;

        [DataMember]
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        [DataMember]
        public string House
        {
            get { return house; }
            set { house = value; }
        }
        [DataMember]
        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
        [DataMember]
        public string FIO
        {
            get { return fio; }
            set { fio = value; }
        }
        [DataMember]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        [DataMember]
        public long AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }
        [DataMember]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        [DataMember]
        public string CommentForRequest
        {
            get { return commentForRequest; }
            set { commentForRequest = value; }
        }
    }

    [DataContract]
    public class CountByDay
    {
        int day;
        int count ;

        [DataMember]
        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        [DataMember]
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }

}
   