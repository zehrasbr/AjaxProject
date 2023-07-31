using Microsoft.EntityFrameworkCore;

namespace AjaxProject.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=UNKNOWN\\SQLEXPRESS;initial Catalog=CasgemAjaxDb; integrated security=true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
