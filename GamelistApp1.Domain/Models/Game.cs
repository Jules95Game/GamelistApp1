using GamelistApp1.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace GamelistApp1.Domain.Models;

public class Game : IEntity
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Title { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Developer { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Publisher { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }

    [Required]
    [MaxLength(16)]
    public required string Platform { get; set; }
}