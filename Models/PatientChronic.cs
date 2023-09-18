namespace Hospital_App.Models
{
    public class PatientChronic
    {
        public int PatientChronicID { get; set; }
        public Patient Patient { get; set; }
        public int PatientID { get; set;}
        public Chronic Chronic { get; set; }
        public int ChronicID { get; set; }
    }
}
