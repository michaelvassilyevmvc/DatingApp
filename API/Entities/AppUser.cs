namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswortHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        
    }
}