namespace Hospital_App.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ContactPhone { get; set; }
        public char UserType { get; set; }
        public char Status { get; set; }
        public string Password { get; set; }
    }
}
