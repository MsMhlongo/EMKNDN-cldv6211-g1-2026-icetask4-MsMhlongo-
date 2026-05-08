using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models;
public class Gameplay
{
    public int Id { get; set; }
    [Required] public int GameId { get; set; }
    [Required] public int GamerId { get; set; }
    [Range(0, 100)] public int Score { get; set; }
}
