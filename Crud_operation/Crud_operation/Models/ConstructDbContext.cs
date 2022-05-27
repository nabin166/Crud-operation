using Microsoft.EntityFrameworkCore;


namespace Crud_operation.Models
{
    public class ConstructDbContext:DbContext
    {

        public ConstructDbContext(DbContextOptions<ConstructDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } = null!;


    }
}
