using System.ComponentModel.DataAnnotations;

namespace GameApp.Frontend.Models;

public class Game
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Genre { get; set; }
    public decimal Price { get; set; }  
    public DateOnly ReleaseDate { get; set; }

}
