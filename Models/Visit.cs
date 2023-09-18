using System;
using System.Threading;

namespace Hospital_App.Models
{
    public class Visit
    {
        public int VisitID { get; set; }
        public DateTime VistDate { get; set; }
        public DateTime ApproxArriTime { get; set; }
        public DateTime ArriveTime { get; set; }
        public string WoundCondition { get; set; }
        public string Note { get; set; }
        public Nurse Nurse { get; set; }
        public int NurseID { get; set;}
    }
}
