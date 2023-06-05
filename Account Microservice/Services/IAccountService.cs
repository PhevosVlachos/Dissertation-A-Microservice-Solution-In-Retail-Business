using Account_Microservice.Model;

namespace Account_Microservice.Services
{
    public interface IAccountService
    {

        public void CreateAccount(string email, string password, string userType);

        public void UpdateAccountByEmail(string email, string newEmail, string password, string newPassword);

        public void UpdateAccountById(int accountId, string newEmail, string password, string newPassword);

        public void ChangeEmailByEmail(string email,string newEmail);

        public void ChangeEmailById(int accountId, string newEmail);

        public void ChangePasswordByEmail(string email, string password, string newPassword);

        public void ChangePasswordById(int accountId, string password, string newPassword);

        public void DeleteAccountByEmail(string email);

        public void DeleteAccountById(string accountId);

        public List<Account> GetAllAccounts();

        public Account GetAccountByEmail(string email);

        public Account GetAccountById(int accountId);
    }
}
