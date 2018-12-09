namespace E_Shop.Models
{
    public class Owner
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public long UserNameId { get; set; }
        public long PasswordId { get; set; }
        public long ImageId { get; set; }
        public bool Status { get; set; }
    }
}