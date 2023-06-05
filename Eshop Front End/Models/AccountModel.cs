namespace Eshop_Front_End.Models
{
    public class AccountModel
    {

        public int Id { get; set; }
        public string Email { get; set; } = "";
        public string? NewEmail { get; set; }
        public string Password { get; set; }
        public string? NewPassword { get; set; }
        public DateTime? DateCreated { get; set; }

    }
}
