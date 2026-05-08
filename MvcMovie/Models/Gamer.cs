using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models;
public class Gamer
{
    public int Id { get; set; }
    [Required] public string Username { get; set; } = string.Empty;
    [Required] [EmailAddress] public string Email { get; set; } = string.Empty;
}
