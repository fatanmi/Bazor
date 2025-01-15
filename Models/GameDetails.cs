using System.ComponentModel.DataAnnotations;

namespace GameApp.Frontend.Models;

public class GameDetails
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }
    public DateOnly ReleaseDate { get; set; }

}
