using System.Net.Mail;

namespace Account_Microservice.Model
{
    public class Account
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateCreated { get; set; }

        public string UserType { get; set; }

       



    }
}
