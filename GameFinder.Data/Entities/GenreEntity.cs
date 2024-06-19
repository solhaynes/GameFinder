using System.ComponentModel.DataAnnotations;

namespace GameFinder.Data.Entities;

public class GenreEntity
{
  [Key]
  public int Id { get; set; }
  
  [Required, MinLength(1), MaxLength(100)]
  public string Name { get; set; } = string.Empty;
}