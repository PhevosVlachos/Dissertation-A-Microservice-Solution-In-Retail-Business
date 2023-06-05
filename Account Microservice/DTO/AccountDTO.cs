namespace Account_Microservice.DTO
{
    public class AccountDTO
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string? NewEmail { get; set; }

        public string Password { get; set; }

        public string? NewPassword { get; set; }

        public string UserType { get; set; }

       
    }
}
