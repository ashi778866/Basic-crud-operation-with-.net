using AsharCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace AsharCrud.Data
{
    public class AppDbcontext: DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
