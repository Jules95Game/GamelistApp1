using GamelistApp1.DataAccess;
using GamelistApp1.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GamelistApp1.TestConsole;

internal class Program
{
    private static void Main()
    {
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Hello, World!");
        Console.ReadLine();

        IHost host = Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddDbContext<DataContext>(options => options.UseSqlServer(
                    "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameDB1;Integrated Security=True;"));
            })
            .Build();

        List<Game> games = host.Services.GetRequiredService<DataContext>().Games.ToList();
        foreach (Game game in games)
        {
            Console.WriteLine($"{game.Title}\t- {game.Developer}\t- {game.Platform}");
        }
        Console.ReadLine();
    }
}