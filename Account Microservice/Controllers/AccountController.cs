using Account_Microservice.DTO;
using Account_Microservice.Model;
using Account_Microservice.Services;
using Microsoft.AspNetCore.Mvc;
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
           _accounts.CreateAccount(accountDTO.Username, accountDTO.Password);


        }

        [HttpGet("GetAccountByUsername/{username}")]
        public Account GetAccountByUsername (string username) { 
        
        return _accounts.GetAccountByName(username);
        }

        [HttpGet("GetAllAccounts")]
            public List<Account> GetAllAccounts() {
                
              return _accounts.GetAllAccounts();
        
        }


    
        
    }
}
