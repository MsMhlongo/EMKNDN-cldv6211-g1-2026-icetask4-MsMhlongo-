using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models;
public class Game
{
    public int Id { get; set; }
    [Required] public string Title { get; set; } = string.Empty;
    [Required] public string Genre { get; set; } = string.Empty;
    public string? ImagePath { get; set; }
}
