using CompyterAccounting.Models;
using Microsoft.EntityFrameworkCore;

namespace CompyterAccounting.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
           // Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        //public DbSet<Ups> UpsRepository { get; set; }

        public DbSet<ModelUps> ModelUps { get; set; }
    }
}
