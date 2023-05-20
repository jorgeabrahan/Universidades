using Microsoft.EntityFrameworkCore;
using universidades.Models;

namespace universidades;

public class UniversidadesContext : DbContext
{
  public DbSet<Country>? Country { get; set; }
  public DbSet<RankingCriteria>? RankingCriteria { get; set; }
  public DbSet<RankingSystem>? RankingSystem { get; set; }
  public DbSet<University>? University { get; set; }
  public DbSet<UniversityRankingYear>? UniversityRankingYear { get; set; }
  public DbSet<UniversityYear>? UniversityYear { get; set; }

  public UniversidadesContext(DbContextOptions<UniversidadesContext> options) : base(options) { }
}
