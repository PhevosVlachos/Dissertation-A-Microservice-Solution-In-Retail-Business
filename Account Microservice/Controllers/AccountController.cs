using Account_Microservice.DTO;
using Account_Microservice.Model;
using Account_Microservice.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update;
using static System.Net.WebRequestMethods;

namespace Account_Microservice.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {

        private readonly ILogger<AccountController> _logger;
        private readonly IAccountService _accounts;

        public AccountController(ILogger<AccountController> logger, IAccountService accounts)
        {
            _logger = logger;
            _accounts = accounts;
        }

        [HttpPost("CreateAccount")]
        public void CreateAccount([FromBody] AccountDTO accountDTO)
        {
           _accounts.CreateAccount(accountDTO.Email, accountDTO.Password, accountDTO.UserType);


        }

        [HttpPost("UpdateAccountByEmail")]
        public void UpdateAccountByEmail([FromBody] AccountDTO accountDTO)
        {
            _accounts.UpdateAccountByEmail(accountDTO.Email, accountDTO.NewEmail, accountDTO.Password, accountDTO.NewPassword);


        }

        [HttpPost("UpdateAccountById")]
        public void UpdateAccountById([FromBody] AccountDTO accountDTO)
        {
            _accounts.UpdateAccountById(accountDTO.Id, accountDTO.NewEmail, accountDTO.Password, accountDTO.NewPassword);


        }

        [HttpPost("ChangeEmailByEmail")]
        public void ChangeEmailByEmail([FromBody] AccountDTO accountDTO)
        {
            _accounts.ChangeEmailByEmail(accountDTO.Email, accountDTO.NewEmail );


        }

        [HttpPost("ChangeEmailById")]
        public void ChangeEmailById([FromBody] AccountDTO accountDTO)
        {
            _accounts.ChangeEmailById(accountDTO.Id, accountDTO.NewEmail);


        }

        [HttpPost("ChangePasswordByEmail")]
        public void ChangePasswordByEmail([FromBody] AccountDTO accountDTO)
        {
            _accounts.ChangePasswordByEmail(accountDTO.Email, accountDTO.Password, accountDTO.NewPassword);


        }

        [HttpPost("ChangePasswordById")]
        public void ChangePasswordById([FromBody] AccountDTO accountDTO)
        {
            _accounts.ChangePasswordById(accountDTO.Id, accountDTO.Password, accountDTO.NewPassword);


        }

      




        [HttpGet("GetAccountByEmail/{email}")]
        public Account GetAccountByEmail (string email) { 
        
        return _accounts.GetAccountByEmail(email);
        }

        [HttpGet("GetAccountById/{id}")]
        public Account GetAccountById(int id)
        {

            return _accounts.GetAccountById(id);
        }

        [HttpGet("GetAllAccounts")]
            public List<Account> GetAllAccounts() {
                
              return _accounts.GetAllAccounts();
        
        }


    
        
    }
}
