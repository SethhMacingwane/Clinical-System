namespace Hospital_App.Models
{
    public class Suburb
    { 
        public int SuburbID { get; set; }
        public string SuburbName { get; set; }
        public int PostalCode { get; set; }
        public City City { get; set; }
        public int CityID { get; set; }
    }
}
