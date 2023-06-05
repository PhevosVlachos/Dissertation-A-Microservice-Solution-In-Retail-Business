using Account_Microservice.Model;
using Microsoft.EntityFrameworkCore;

namespace Account_Microservice.Data
{
    public class AccountData : DbContext
    {


        public DbSet<Account> Accounts { get; set; }

        public DbSet<Privileges> Privileges { get; set; }

        public AccountData(DbContextOptions<AccountData> options) : base(options)
        { }
    }
}
