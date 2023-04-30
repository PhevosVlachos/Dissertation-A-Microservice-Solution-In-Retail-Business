using Account_Microservice.Data;
using Account_Microservice.Model;
using System.Net.Http.Headers;

namespace Account_Microservice.Services
{
    public class AccountService : IAccountService
    {

        private AccountData _context;

        public AccountService(AccountData context)
        {
            _context = context;
        }

        public void CreateAccount(string username, string password)
        {
            Account account = new Account()
            {
                Password = password,
                Username = username
                
            };

            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void DeleteAccount(string username)
        {
            throw new NotImplementedException();
        }


        public void UpdateAccount(string username, string password)
        {
            throw new NotImplementedException();
        }


        public Account GetAccountById(string accountId)
        {
            throw new NotImplementedException();
        }

        public Account GetAccountByName(string username)
        {
            List<Account> acc = _context.Accounts.ToList();
            Account select = new();

            foreach (Account account in acc)
            {
                if (account.Username == username) {
                    select = account;
                
                }
            }

            return select;
           
        }

        public List<Account> GetAllAccounts()
        {
            return _context.Accounts.ToList();
        }
    }
}
