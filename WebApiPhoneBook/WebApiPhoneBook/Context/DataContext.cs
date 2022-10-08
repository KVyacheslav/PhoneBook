using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApiPhoneBook.Data;
using WpfPhoneBook.AuthApp;

namespace WebApiPhoneBook.Context
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Person> People { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
