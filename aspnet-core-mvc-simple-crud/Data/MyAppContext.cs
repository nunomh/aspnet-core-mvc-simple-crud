using aspnet_core_mvc_simple_crud.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_core_mvc_simple_crud.Data
{
    public class MyAppContext : DbContext // DbContext has the information needed to connect to the database
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) // contructor
        {
        }

        public DbSet<Item> Items { get; set; } // instance of each model we have in the project
    }
}
