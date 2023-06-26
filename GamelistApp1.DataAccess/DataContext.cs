using GamelistApp1.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace GamelistApp1.DataAccess;

public class DataContext : DbContext
{
    public DbSet<Game> Games { get; set; }

    public DataContext(DbContextOptions options) : base(options) { }
}