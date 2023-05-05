
using System.Collections.Immutable;
using EFMigrationEmployerLibrary.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.WindowsServices;
using Microsoft.AspNetCore.Hosting.WindowsServices;
using Microsoft.EntityFrameworkCore.Design;


public class Program
{
    public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

    public static IHostBuilder CreateHostBuilder(string[] args)
        => Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(
                webBuilder => webBuilder.UseStartup<Startup>())
            .UseWindowsService()
            .UseSystemd();
}

public class Startup
{
    public void ConfigureServices(IServiceCollection services) => services.AddDbContext<EmployerContext>(options => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EFEmployerDB;Trusted_Connection=True;"));

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
    }
}

// string connectionString = GetAppSettingsSectionValue("ConnectionStrings:Default");
// //string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=EFEmployerDB;Trusted_Connection=True;";
//
// AddTim();
//
// void AddTim()
// {
//     var optionsBuilder = new DbContextOptionsBuilder<EmployerContext>();
//     optionsBuilder.UseSqlServer(connectionString);
//
//     using (var db = new EmployerContext(optionsBuilder))
//     {
//         // run CreateDatabase migration script
//         // run ef update
//         // build out functions
//         // Do autoit shit
//
//         db.SaveChanges();
//     }
// }
//
// //Console.WriteLine($"{connectionString}");
// Console.WriteLine("Done Processing...");
// Console.ReadLine();
//
//
// string GetAppSettingsSectionValue(string section)
// {
//     var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
//     string sectionValue = config.GetSection(section).Value;
//
//     return sectionValue;
// }
