using WebPhoneBook.AuthApp;
using WebPhoneBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebPhoneBook.Context
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Person> People { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
