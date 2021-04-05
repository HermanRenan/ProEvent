using Microsoft.EntityFrameworkCore;
using projectFullS.Models;

namespace projectFullS.Data
{
    public class DataContext : DbContext    
    {   
        public DataContext(DbContextOptions<DataContext> param) : base (param) {  }
        public DbSet<Event> Events { get; set; }
    }
}