using System;

namespace GameStore.Api.Models;

public class Genre
{
    public int GenreId { get; set; }
    public required string Name { get; set; }
}
