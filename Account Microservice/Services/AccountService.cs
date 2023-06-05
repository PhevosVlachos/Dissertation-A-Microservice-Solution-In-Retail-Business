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

        public void CreateAccount(string email, string password, string userType)
        {
            Boolean existsInContext = false ;
            List<Account> savedAccounts = _context.Accounts.ToList(); 


            Account account = new Account()
            {
                Password = password,
                Email = email,
                DateCreated= DateTime.Now,
                UserType = userType
                
            };


            foreach (Account acc in savedAccounts) 
            {
                if(acc.Email == email)
                {
                    existsInContext = true;

                }   

            }


            if (!existsInContext && email != "") 
            {
                _context.Accounts.Add(account);
                _context.SaveChanges();
            }
           
        }

        public void DeleteAccountByEmail(string email)
        {
            Account toDelete = _context.Accounts.FirstOrDefault(acc => acc.Email == email);

            _context.Accounts.Remove(toDelete);
            _context.SaveChanges();
        }


        public void UpdateAccountByEmail(string email,string newEmail, string password, string newPassword)
        {
            Account toUpdate = _context.Accounts.FirstOrDefault(acc => acc.Email == email);

            
            
        }


        public Account GetAccountById(int accountId)
        {
            List<Account> acc = _context.Accounts.ToList();
            Account select = new();

            foreach (Account account in acc)
            {
                if (account.Id == accountId)
                {
                    select = account;

                }
            }

            return select;
        }

        public Account GetAccountByEmail(string email)
        {
            List<Account> acc = _context.Accounts.ToList();
            Account select = new();

            foreach (Account account in acc)
            {
                if (account.Email == email) {
                    select = account;
                
                }
            }

            return select;
           
        }

        public List<Account> GetAllAccounts()
        {
            return _context.Accounts.ToList();
        }

        public void DeleteAccountById(string accountId)
        {
          
        }

  

        public void UpdateAccountById(int accountId, string password, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void UpdateAccountById(int accountId, string newEmail, string password, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void ChangeEmailByEmail(string email, string newEmail)
        {
            throw new NotImplementedException();
        }

        public void ChangeEmailById(int accountId, string newEmail)
        {
            throw new NotImplementedException();
        }

        public void ChangePasswordByEmail(string email, string password, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void ChangePasswordById(int accountId, string password, string newPassword)
        {
            throw new NotImplementedException();
        }
    }
}
