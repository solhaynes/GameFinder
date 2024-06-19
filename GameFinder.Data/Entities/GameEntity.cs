using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameFinder.Data.Entities;

public class GameEntity
{
  [Key]
  public int Id { get; set; }

  [Required, MinLength(1), MaxLength(100)]
  public string Name { get; set; } = string.Empty;

  [Required]
  [ForeignKey(nameof(GameSystemEntity))]
  public int GameSystemId { get; set; }
  public GameSystemEntity GameSystem  { get; set; } = null!;

  [Required]
  [ForeignKey(nameof(GenreEntity))]
  public int GenreId { get; set; }
  public GenreEntity Genre { get; set; } = null!;
}