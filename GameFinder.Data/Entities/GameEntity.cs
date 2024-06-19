using System.ComponentModel.DataAnnotations;

namespace GameFinder.Data.Entities;

public class GameEntity
{
  [Key]
  public int Id { get; set; }

  [Required, MinLength(1), MaxLength(100)]
  public string Name { get; set; } = string.Empty;

  [Required]
  public int GameSystemId { get; set; }

  [Required]
  public int GenreId { get; set; }

}