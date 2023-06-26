using GamelistApp1.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace GamelistApp1.DataAccess;

public class DataContext : DbContext
{
    public DbSet<Game> Games { get; set; }

    public DataContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>().HasData(
            new Game
            {
                Id = 1,
                Title = "Super Mario Odyssey",
                Developer = "Nintendo EPD",
                Publisher = "Nintendo",
                Description = "Wahoo!",
                Platform = "Nintendo Switch"
            },
            new Game
            {
                Id = 2,
                Title = "The Legend of Zelda: Breath of the Wild",
                Developer = "Nintendo EPD",
                Publisher = "Nintendo",
                Description = "Yahaha!",
                Platform = "Nintendo Switch"
            },
            new Game
            {
                Id = 3,
                Title = "Kirby's Return to Dream Land Deluxe",
                Developer = "HAL Laboratory",
                Publisher = "Nintendo",
                Description = "Haiya!",
                Platform = "Nintendo Switch"
            },
            new Game
            {
                Id = 4,
                Title = "The Legend of Zelda: Ocarina of Time",
                Developer = "Nintendo EAD",
                Publisher = "Nintendo",
                Description = "Hey! Listen!",
                Platform = "Nintendo 64"
            });
    }
}