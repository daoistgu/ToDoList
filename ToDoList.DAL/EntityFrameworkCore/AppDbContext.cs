using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DAL;
public class AppDbContext : DbContext
{
    public AppDbContext()
    {
        Database.EnsureCreated();
    }
    public const string ConnectionString =
   "host=localhost;" +
   "port=5432;" +
   "User ID=postgres;" +
   "password=123;" +
   "database=ToDoListDb;";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(ConnectionString);
    }
}
