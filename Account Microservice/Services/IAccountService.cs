using Account_Microservice.Model;

namespace Account_Microservice.Services
{
    public interface IAccountService
    {

        public void CreateAccount(string username, string password);

        public void UpdateAccount(string username, string password);

        public void DeleteAccount(string username);

        public List<Account> GetAllAccounts();

        public Account GetAccountByName(string username);

        public Account GetAccountById(string accountId);
    }
}
