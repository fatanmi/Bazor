using GameApp.Frontend.Models;

namespace GameApp.Frontend.GameClient;

public class GamesClient
{
    private List<Game> games =
    [
        new()
        {
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 19.99M,
            ReleaseDate = new DateOnly(2023, 12, 01),
        },
        new()
        {
            Id = 1,
            Name = "Final Fantasy II",
            Genre = "Fighting",
            Price = 19.99M,
            ReleaseDate = new DateOnly(1992, 7, 01),
        },
    ];
    public Game[] getGames() => [.. games];
}
