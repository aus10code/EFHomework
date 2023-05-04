namespace EFMigrationEmployerLibrary.DataAccess;

using Microsoft.EntityFrameworkCore;
using Models;
public class EmployerContext : DbContext
{
    //private string _connectionString { get; init; }
    private DbContextOptionsBuilder<EmployerContext> _options { get; init; }
    public DbSet<Person> People { get; set; }
    public DbSet<Employer> Employers { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<AddressHolder> AddressHolders { get; set; }
    public DbSet<Employees> Employees { get; set; }
    public DbSet<EntityType> EntityTypes { get; set; }

    public EmployerContext(DbContextOptions<EmployerContext> options)
        : base(options)
    {

    }

    // public EmployerContext(DbContextOptionsBuilder<EmployerContext> options)
    // {
    //     _options = options;
    // }
    //
    // protected override void OnConfiguring(DbContextOptionsBuilder options)
    // {
    //     options.UseSqlServer("");
    //
    // }
}
