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

var host = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder => webBuilder.ConfigureServices(services =>
    {
        services.AddDbContext<EmployerContext>(options => options
            .UseSqlServer(GetAppSettingsSectionValue("ConnectionStrings:Default")));
    }))
    .Build();

AddTim();


Console.WriteLine("lololol");
Console.ReadLine();


void AddTim()
{
    var service = host.Services.GetRequiredService<EmployerContext>();
}


// run CreateDatabase migration script
// run ef update
// build out functions
// Do autoit shit

string GetAppSettingsSectionValue(string section)
{
    var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json").Build();
    string sectionValue = config.GetSection(section).Value;

    return sectionValue;
}
