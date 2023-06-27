using GamelistApp1.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace GamelistApp1.Domain.Models;

public class Game : IEntity
{
    public int Id { get; set; }

    [MaxLength(100)]
    public required string Title { get; set; }

    [MaxLength(50)]
    public required string Developer { get; set; }

    [MaxLength(50)]
    public required string Publisher { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }

    [MaxLength(32)]
    public required string Platform { get; set; }
}