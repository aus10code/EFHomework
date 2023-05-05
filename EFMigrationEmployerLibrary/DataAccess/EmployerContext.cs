namespace EFMigrationEmployerLibrary.DataAccess;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Models;
public class EmployerContext : DbContext
{
    public EmployerContext(DbContextOptions<EmployerContext> options) : base(options)
    {

    }

    public DbSet<Person> People { get; set; }
    public DbSet<Employer> Employers { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<AddressHolder> AddressHolders { get; set; }
    public DbSet<Employees> Employees { get; set; }
    public DbSet<EntityType> EntityTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            options.UseSqlServer(this.Database.GetConnectionString());
        }
    }
}
