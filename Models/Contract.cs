using System;

namespace Hospital_App.Models
{
    public class Contract
    {
        public int ContractID { get; set; }
        public DateTime ContractDate { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string WoundDesc { get; set; }
        public string Status { get; set; }
        public Nurse Nurse { get; set; }
        public int NurseID { get; set; }
        public Patient Patient { get; set; }
        public int PatientID { get; set; }
        public Suburb Suburb { get; set; }
        public int SuburbID { get; set;}

    }
}
