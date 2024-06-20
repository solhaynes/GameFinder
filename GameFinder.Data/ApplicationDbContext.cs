using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GameFinder.Data.Entities;

namespace GameFinder.Data;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

  public DbSet<GenreEntity> Genres { get; set; } = null!;
  public DbSet<GameEntity> Games { get; set; } = null!;
  public DbSet<