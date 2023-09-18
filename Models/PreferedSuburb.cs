namespace Hospital_App.Models
{
    public class PreferedSuburb
    {
        public int PreferedSuburbID { get; set; }
        public Nurse Nurse { get; set; }
        public int NurserID { get; set; }
        public Suburb Suburb { get; set; }
        public int SuburbID { get; set;}
    }
}
