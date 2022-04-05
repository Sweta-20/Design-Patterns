using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_pattern.Model
{
    public class AppDbContext :DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
        public  override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                var entity = entry.Entity;
                if(entry.State==EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entry.GetType().GetProperty("Status").SetValue(entity, "D");
                }
            }
            return base.SaveChanges();
        }
    }
}
