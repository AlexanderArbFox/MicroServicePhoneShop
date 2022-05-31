using Microsoft.EntityFrameworkCore;
using Shop.Services.PhoneAPI.Models;

namespace Shop.Services.PhoneAPI.DbContexts
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options)   
        {

        }
        public DbSet<Goods> Goods { get; set; }
    }
}
